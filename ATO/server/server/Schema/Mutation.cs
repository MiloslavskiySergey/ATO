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
            return new Payload(errors, result.Succeeded);
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

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<LoginPayload> RefreshToken([Service] ITokenService tokenService, string refreshToken)
        {
            return new LoginPayload(await tokenService.UpdateAsync(refreshToken));
        }

		[UseDbContext(typeof(ApplicationDbContext))]
		public async Task<Payload> AddOrder([ScopedService] ApplicationDbContext context, 
            string mesto, 
            int counts, 
            int airId,
            DateTime dateStart,
            DateTime timeStart,
            string start,
            string target,
            string name,
            decimal price, 
            decimal Percent)
		{
            var order = new Order()
            {
                Mesto = mesto,
                Counts = counts,
                Flight = new()
                {
                    AirId = airId,
                    DateStart = dateStart,
                    TimeStart = timeStart,
                    Route = new()
                    {
                        Start = start,
                        Target = target,
                        Price = price
                    },

                },
                Card = new() 
                { 
                    Name = name, 
                    Percent = Percent 
                }
            };
            await context.Orders.AddAsync(order);
            //await context.Orders.SaveChangesAsync();
            return new Payload();
        }
	}
}
