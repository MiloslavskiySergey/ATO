using System.Net;
using System.Security.Authentication;
using System.Security.Claims;
using System.Threading.Tasks;
using HotChocolate;
using Microsoft.AspNetCore.Http;
using server.Services;

namespace server.Middlewares
{
    public class TokenMiddleware : IMiddleware
    {
        private ITokenService _tokenService;
        public TokenMiddleware(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (await _tokenService.IsActive(_tokenService.CurrentAccessToken()))
            {
                await next(context);
                return;
            }
            context.User = new System.Security.Claims.ClaimsPrincipal(new ClaimsIdentity());
            await next(context);
        }
    }
}