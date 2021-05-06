using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using server.DB;
using Microsoft.EntityFrameworkCore;
using HotChocolate;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using server.Models;
using server.Schema;
using System.Text;
using server.Services;
using server.Middlewares;
using NetCasbin;
using NetCasbin.Persist;
using Casbin.Adapter.EFCore;
using server.Logger;

namespace server
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			//db connection
			services.AddPooledDbContextFactory<ApplicationDbContext>(options =>
			{
				options.UseNpgsql(Configuration.GetConnectionString("Default"));
			});

			//db connection for identity service
			services.AddDbContext<ApplicationDbContext>(options =>
			{
				options.UseNpgsql(Configuration.GetConnectionString("Default"));
			},

			contextLifetime: ServiceLifetime.Transient,
			optionsLifetime: ServiceLifetime.Singleton
			);

			//identity service
			var builder = services.AddIdentityCore<User>(opt =>
			{
				opt.Password.RequireNonAlphanumeric = false;
				opt.Password.RequireUppercase = false;
			});
			builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            builder.AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddRoleValidator<RoleValidator<IdentityRole>>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddSignInManager<SignInManager<User>>();
			//auth
			services.Configure<TokenSettings>(Configuration.GetSection("TokenSettings"));
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(options =>
				{
					options.RequireHttpsMetadata = false;
					options.TokenValidationParameters = new TokenValidationParameters()
					{
						ValidIssuer = Configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
						ValidateIssuer = true,
						ValidAudience = Configuration.GetSection("TokenSettings").GetValue<string>("Audience"),
						ValidateAudience = true,
						IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
						ValidateIssuerSigningKey = true
					};
				});
			services.AddScoped<ITokenService, TokenService>();
			services.AddScoped<IIdentityService, IdentityService>();
			services.AddScoped<TokenMiddleware>();
			services.AddStackExchangeRedisCache(action =>
			{
				action.Configuration = Configuration.GetConnectionString("Redis");
			});
			//services.AddAuthorization();

			//graphql
			services.AddGraphQLServer()
				.AddQueryType<Query>()
				.AddMutationType<Mutation>()
				.AddFiltering()
				.AddSorting()
				.AddProjections()
				.AddDiagnosticEventListener(sp =>
					new MiniProfilerQueryLogger());

			services.AddMiniProfiler(options =>
			{ options.RouteBasePath = "/profiler"; }).AddEntityFramework();

			//services.AddDbContext<ApplicationDbContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("Default")));
			services.AddScoped<IAdapter>(x => new EFCoreAdapter<int>(x.GetRequiredService<ApplicationDbContext>()));
			//services.AddScoped(x => new Enforcer("./Casbin/auth_model.conf", x.GetRequiredService<IAdapter>()));
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseMiniProfiler();
			app.UseRouting();
			app.UseAuthentication();
			//app.UseAuthorization();
			app.UseMiddleware<TokenMiddleware>();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapGraphQL("/");
			});
		}
	}
}
