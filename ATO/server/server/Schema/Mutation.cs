using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using HotChocolate;
using HotChocolate.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using server.DB;
using server.Models;
using server.Schema.Types;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore;
using System.Text;
using System.Net;
using System.Web;
using System.Text.Json;
using System.IO;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using server.Services;

namespace server.Schema
{
    public class Mutation
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Payload> SignUp([Service] IIdentityService identity, string email, string password)
        {
            var result = await identity.SignUpAsync(email, password);
            var errors = new List<Types.Error>();
            foreach (var err in result.Errors)
            {
                errors.Add(new Types.Error(err.Code, err.Description));
            }
            return new Payload(result.Succeeded, errors);
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<LoginPayload> SignIn([Service] IIdentityService identity, string email, string password)
        {
            return new LoginPayload(await identity.SignInAsync(email, password));
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Payload> SignOut([Service] IIdentityService identity)
        {
            await identity.SignOutAsync();
            return new Payload();
        }
    }
}
