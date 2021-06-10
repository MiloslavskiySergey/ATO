using Microsoft.AspNetCore.Identity;
using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Services
{
    public interface IIdentityService
    {
        Task<IdentityResult> SignUpAsync(string email, string password);
        Task<Token> SignInAsync(string email, string password);
        Task SignOutAsync();
        string GetCurrentUserId();
        Task<User> GetCurrentUser();
        Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword);
    }
}
