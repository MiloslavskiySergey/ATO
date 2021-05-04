using System;
using System.Threading.Tasks;
using server.Models;

namespace server.Services
{
    public interface ITokenService
    {
        Task<Token> UpdateAsync(string refreshToken);
        Task RevokeAsyncByRefresh(string refreshToken);
        Task RevokeAsyncByAccess(string accessToken);
        Task<Token> CreateAsync(User user);
        Task<bool> IsActive(string accessToken);
        Token? CurrentToken();
        string CurrentAccessToken();
    }
}
