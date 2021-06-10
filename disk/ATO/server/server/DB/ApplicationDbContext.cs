using Casbin.Adapter.EFCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using server.Models;
using server.DB;

namespace server.DB
{
	public class ApplicationDbContext : IdentityDbContext<User>
	{
		public DbSet<Air> Airs { get; set; } = default!;
		public DbSet<Card> Cards { get; set; } = default!;
		public DbSet<Client> Clients { get; set; } = default!;
		public DbSet<Flight> Flights  { get; set; } = default!;
		public DbSet<Order> Orders { get; set; } = default!;
		public DbSet<Route> Routes  { get; set; } = default!;
		public DbSet<Sotrudnik> Sotrudniks  { get; set; } = default!;
		public DbSet<Token> Tokens  { get; set; } = default!;

		public DbSet<CasbinRule<int>> CasbinRule  { get; set; } = default!;

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.SeedAll();
		}



	}
}
