using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HardwareStoreApp.Repositories;
using HardwareStoreApp.Services;
using HardwareStoreApp.Stores;

namespace HardwareStoreApp
{
	internal static class Program
	{
		public static IHost HostInstance { get; set; }

		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			HostInstance = CreateHostBuilder().Build();
			HostInstance.Start();

			var contextFactory = HostInstance.Services.GetRequiredService<HardwareStoreAppDbContextFactory>();
			using var context = contextFactory.CreateDbContext();
			context.Database.Migrate();
			Application.Run(HostInstance.Services.GetRequiredService<MainForm>());
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
					services.AddTransient<LoginForm>();
					services.AddTransient<ManageUserAccounts>();
					services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
					services.AddSingleton<IUserRepository, UserRepository>();
					services.AddSingleton<IAuthenticationService, AuthenticationService>();
					services.AddSingleton<IUserStore, UserStore>();
				});
		}
	}
}
