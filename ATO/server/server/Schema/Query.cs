using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;
using NetCasbin;
using server.DB;
using server.Models;
using server.Services;
using server.Schema.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Schema
{
	public class Query
	{

		[UseDbContext(typeof(ApplicationDbContext))]
		[UsePaging]
		[UseProjection]
		[UseFiltering]
		//sorting
		public async Task<IQueryable<Air>> GetAirs([Service] IIdentityService identity,
			//[Service] Enforcer enforcer,
			[ScopedService] ApplicationDbContext context)
		{
			//var user = await identity.GetCurrentUser();
			//enforcer.LoadPolicy();
			//if (enforcer.Enforce(user.Id, "airs", "read"))
				return context.Airs;
			//throw new System.Exception();
		}

		[UseDbContext(typeof(ApplicationDbContext))]
		[UsePaging]
		[UseProjection]
		[UseFiltering]
		//sorting
		public async Task<IQueryable<Card>> GetCards([Service] IIdentityService identity,
			//[Service] Enforcer enforcer,
			[ScopedService] ApplicationDbContext context)
		{
			//var user = await identity.GetCurrentUser();
			//enforcer.LoadPolicy();
			//if (enforcer.Enforce(user.Id, "cards", "read"))
				return context.Cards;
			//throw new System.Exception();
		}

		[UseDbContext(typeof(ApplicationDbContext))]
		[UsePaging]
		[UseProjection]
		[UseFiltering]
		//sorting
		public async Task<IQueryable<Client>> GetClients([Service] IIdentityService identity,
			//[Service] Enforcer enforcer,
			[ScopedService] ApplicationDbContext context)
		{
			//var user = await identity.GetCurrentUser();
			//enforcer.LoadPolicy();
			//if (enforcer.Enforce(user.Id, "clients", "read"))
				return context.Clients;
			//throw new System.Exception();
		}

		[UseDbContext(typeof(ApplicationDbContext))]
		[UsePaging]
		[UseProjection]
		[UseFiltering]
		//sorting
		public async Task<IQueryable<Flight>> GetFlights([Service] IIdentityService identity,
			//[Service] Enforcer enforcer,
			[ScopedService] ApplicationDbContext context)
		{
			//var user = await identity.GetCurrentUser();
			//enforcer.LoadPolicy();
			//if (enforcer.Enforce(user.Id, "flights", "read"))
				return context.Flights;
			//throw new System.Exception();
		}

		[UseDbContext(typeof(ApplicationDbContext))]
		[UsePaging]
		[UseProjection]
		[UseFiltering]
		//sorting
		public async Task<IQueryable<Order>> GetOrders([Service] IIdentityService identity,
			//[Service] Enforcer enforcer,
			[ScopedService] ApplicationDbContext context)
		{
			//var user = await identity.GetCurrentUser();
			//enforcer.LoadPolicy();
			//if (enforcer.Enforce(user.Id, "orders", "read"))
				return context.Orders;
			//throw new System.Exception();
		}

		[UseDbContext(typeof(ApplicationDbContext))]
		[UsePaging]
		[UseProjection]
		[UseFiltering]
		//sorting
		public async Task<IQueryable<Route>> GetRoutes([Service] IIdentityService identity,
			[Service] Enforcer enforcer,
			[ScopedService] ApplicationDbContext context)
		{
			//var user = await identity.GetCurrentUser();
			//enforcer.LoadPolicy();
			//if (enforcer.Enforce(user.Id, "routes", "read"))
				return context.Routes;
			//throw new System.Exception();
		}

		[UseDbContext(typeof(ApplicationDbContext))]
		[UsePaging]
		[UseProjection]
		[UseFiltering]
		//sorting
		public async Task<IQueryable<Sotrudnik>> GetSotrudniks([Service] IIdentityService identity,
			//[Service] Enforcer enforcer,
			[ScopedService] ApplicationDbContext context)
		{
			//var user = await identity.GetCurrentUser();
			//enforcer.LoadPolicy();
			//if (enforcer.Enforce(user.Id, "sotrudniks", "read"))
				return context.Sotrudniks;
			//throw new System.Exception();
		}

		[UseDbContext(typeof(ApplicationDbContext))]
		[UseSingleOrDefault]
		public async Task<User> Me([Service] IIdentityService identity, [Service] Enforcer enforcer)
		{
			var user = await identity.GetCurrentUser();
			enforcer.LoadPolicy();
			if (enforcer.Enforce(user.Id, "users", "read"))
				return user;
			throw new System.Exception();
		}
	}
}
