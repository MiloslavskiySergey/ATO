using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace server.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IHttpContextAccessor _httpContext;

        public IdentityService(UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService, IHttpContextAccessor httpContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _httpContext = httpContext;
        }

        public async Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword)
        {
            //revoke all tokens
            return await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
        }

        public async Task<User> GetCurrentUser()
        {
            return await _userManager.FindByIdAsync(GetCurrentUserId()); //_tokenService.CurrentToken()?.User ?? throw new NullReferenceException("Please SignIn");
        }

        public string GetCurrentUserId()
        {
            return _httpContext.HttpContext?.User.Claims.First().Value ?? string.Empty;
        }

        public async Task<Token> SignInAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var signInRes = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            if (signInRes.Succeeded)
            {
                return await _tokenService.CreateAsync(user);
            }
            else
                throw new Exception("Wrong username or password");
        }

        public async Task SignOutAsync()
        {
            await _tokenService.RevokeAsyncByAccess(_tokenService.CurrentAccessToken());
        }

        public async Task<IdentityResult> SignUpAsync(string email, string password)
        {
            var user = new User() { Email = email, UserName = email };
            var result = await _userManager.CreateAsync(user, password);
            return result;
        }
    }
}
