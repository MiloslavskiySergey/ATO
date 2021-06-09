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
            //int airId,
            int flightId,
            int clientId,
            int cardId
           /* DateTime dateStart,
            DateTime timeStart,
            string start,
            string target,
            string name,
            decimal price, 
            decimal Percent,
            string lastName*/)
		{
            var order = new Order()
            {
                Mesto = mesto,
                Counts = counts,
                FlightId = flightId,
                ClientId = clientId,
                CardId = cardId
               /* Client = new()
				{
                    LastName = lastName
                    
                },
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
                }*/
            };
            await context.Orders.AddAsync(order);
			await context.SaveChangesAsync();
            return new Payload();
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Payload> AddRoute([ScopedService] ApplicationDbContext context, string start, string target, int time, decimal price)
		{
            var route = new Route()
            {
                Start = start,
                Target = target,
                Time = time,
                Price = price
            };

            await context.Routes.AddAsync(route);
            await context.SaveChangesAsync();
            return new Payload();
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Payload> AddAir([ScopedService] ApplicationDbContext context,
            string bortNumber, 
            string models, 
            int lifeTime,
            int seats,
            DateTime dateCreate,
            bool isActive,
            int sotrudnikId
            )
        {
            var air = new Air()
            {
                BortNumber = bortNumber,
                Model = models,
                LifeTime = lifeTime,
                Seats = seats,
                Date_create = dateCreate,
                IsActive = isActive,
                SotrudnikId = sotrudnikId
            };

            await context.Airs.AddAsync(air);
            await context.SaveChangesAsync();
            return new Payload();
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Payload> AddSotrudnik([ScopedService] ApplicationDbContext context,
        string lastName,
        string name,
        string surName,
        string addres,
        string phone,
        int stage
        )
        {
            var sotrudnik = new Sotrudnik()
            {
                Last_name = lastName,
                Name = name,
                Sur_name = surName,
                Addres = addres,
                Phone = phone,
                Stage = stage
            };

            await context.Sotrudniks.AddAsync(sotrudnik);
            await context.SaveChangesAsync();
            return new Payload();
         }

        [UseDbContext(typeof(ApplicationDbContext))]
        public async Task<Payload> DelRoute([ScopedService] ApplicationDbContext context, int id, string start, string target, int time, decimal price)
        {
            var route = new Route()
            {
                Id = id,
                Start = start,
                Target = target,
                Time = time,
                Price = price
            };

            await context.Routes.AddAsync(route);
            await context.SaveChangesAsync();
            return new Payload();
        }

    }
}
