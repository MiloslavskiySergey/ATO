using Microsoft.IdentityModel.JsonWebTokens;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.DB;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace server.Services
{
    public class TokenService : ITokenService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IDistributedCache _cache;
        private readonly IOptions<TokenSettings> _tokenSettings;
        private readonly SymmetricSecurityKey _symmetricSecurityKey;
        private readonly IHttpContextAccessor _httpContext;

        public TokenService(ApplicationDbContext applicationDbContext, IOptions<TokenSettings> tokenSettings, IDistributedCache cache, IHttpContextAccessor httpContext)
        {
            _applicationDbContext = applicationDbContext;
            _tokenSettings = tokenSettings;
            _symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenSettings.Value.Key));
            _cache = cache;
            _httpContext = httpContext;
        }

        public async Task<Token> CreateAsync(User user)
        {
            //access token generation
            var identity = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
            });
            
            var credentials = new SigningCredentials(_symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(
                issuer: _tokenSettings.Value.Issuer,
                audience: _tokenSettings.Value.Audience,
                expires: DateTime.Now.AddMinutes(20),
                signingCredentials: credentials,
                claims: identity.Claims
            );
            string accessToken = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            //refresh token generation
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            var refreshToken = Convert.ToBase64String(randomNumber);
            //Создание запси в бд
            var token = new Token() { AccessToken = accessToken, RefreshToken = refreshToken, User_id = user.Id };
            //Сохраняем
            await _applicationDbContext.Tokens.AddAsync(token);
            await _applicationDbContext.SaveChangesAsync();
            return token;
        }

        public async Task RevokeAsyncByRefresh(string refreshToken)
        {
            var token = _applicationDbContext.Tokens.SingleOrDefault(x => x.RefreshToken == refreshToken);
            if (token is not null && !token.Revoked)
            {
                token.Revoked = true;
                await _applicationDbContext.SaveChangesAsync();
                //add access token to reddis blacklist
                await DiactivateAsync(token.AccessToken);

            }
            else
                throw new NullReferenceException("Not valid token");
        }

        public async Task RevokeAsyncByAccess(string accessToken)
        {
            var token = _applicationDbContext.Tokens.SingleOrDefault(x => x.AccessToken == accessToken);
            if (token is not null && !token.Revoked)
            {
                token.Revoked = true;
                await _applicationDbContext.SaveChangesAsync();
                //add access token to reddis blacklist
                await DiactivateAsync(token.AccessToken);

            }
            else
                throw new NullReferenceException("Not valid token");
        }

        public async Task<Token> UpdateAsync(string refreshToken)
        {
            var token = _applicationDbContext.Tokens.SingleOrDefault(x => x.RefreshToken == refreshToken);
            if (token is not null && !token.Revoked)
            {
                token.Revoked = true;
                await DiactivateAsync(token.AccessToken);
                return await CreateAsync(token.User);
            }
            else
                throw new NullReferenceException("Not valid token");
        }

        public async Task<bool> IsActive(string accessToken)
        {
            return (await _cache.GetStringAsync($"tokens:{accessToken}:deactivated")) is null;
        }
        private async Task DiactivateAsync(string accessToken)
        {
            await _cache.SetStringAsync($"tokens:{accessToken}:deactivated", " ", new DistributedCacheEntryOptions(){
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(20)
            });
        }

        public Token? CurrentToken()//todo: broken
        {
            var curr = CurrentAccessToken();
            return _applicationDbContext.Tokens.SingleOrDefault(x => x.AccessToken==curr);
        }

        public string CurrentAccessToken()
        {
            var authorizationHeader = _httpContext.HttpContext?.Request?.Headers?["authorization"];
           
        return authorizationHeader is null || authorizationHeader.Value == StringValues.Empty
            ? string.Empty
            : authorizationHeader.Value.Single().Split(" ").Last();
        }
    }
}
