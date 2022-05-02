using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HardwareStoreApp.Repositories;
using HardwareStoreApp.Services;

namespace HardwareStoreApp
{
	internal static class Program
	{
		private static IHost _host;

		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			_host = CreateHostBuilder().Build();
			_host.Start();

			var contextFactory = _host.Services.GetRequiredService<HardwareStoreAppDbContextFactory>();
			using (var context = contextFactory.CreateDbContext())
			{
				context.Database.Migrate();
			}

			Application.Run(_host.Services.GetRequiredService<MainForm>());
		}

		public static IHostBuilder CreateHostBuilder(string[] args = null)
		{
			return Host
				.CreateDefaultBuilder(args)
				.ConfigureServices((context, services) =>
				{
					services.AddDbContext<HardwareStoreAppDbContext>();
					services.AddSingleton(new HardwareStoreAppDbContextFactory());
					services.AddTransient<MainForm>();
					services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
					services.AddSingleton<IUserRepository, UserRepository>();
					services.AddSingleton<IAuthenticationService, AuthenticationService>();
				});
		}
	}
}
