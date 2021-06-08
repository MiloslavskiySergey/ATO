using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
	static class Program
	{
		public static IServiceProvider ServiceProvider { get; private set; } = default!;
		public static string AccessToken = "";
		public static string RefreshToken = "";

		private static void ConfigureServices()
		{
			var services = new ServiceCollection();
			services.
				AddGqlClient()
				.ConfigureHttpClient(client => {
					client.BaseAddress = new Uri("https://localhost:5001/");
					client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessToken);
				});
			ServiceProvider = services.BuildServiceProvider();
		}
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ConfigureServices();
			Application.Run(new FormAvtorization());
		}
	}
}
