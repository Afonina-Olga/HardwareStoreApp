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
		private static IHost _host;

		public static IServiceProvider Services => _host.Services;

		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.ApplicationExit += new EventHandler(OnApplicationExit);

			_host = CreateHostBuilder().Build();
			_host.Start();

			var contextFactory = _host.Services.GetRequiredService<HardwareStoreAppDbContextFactory>();
			using var context = contextFactory.CreateDbContext();
			context.Database.Migrate();

			Application.Run(_host.Services.GetRequiredService<MainForm>());
		}

		private async static void OnApplicationExit(object sender, EventArgs e)
		{
			await _host.StopAsync();
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
					services.AddTransient<ManageUserAccountsForm>();
					services.AddTransient<CreateProductsAndStoresForm>();
					services.AddTransient<BalanceForm>();
					services.AddTransient<SalesForm>();
					services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
					services.AddSingleton<IBalanceRepository, BalanceRepository>();
					services.AddSingleton<IUserRepository, UserRepository>();
					services.AddSingleton<IProductRepository, ProductRepository>();
					services.AddSingleton<IStoreRepository, StoreRepository>();
					services.AddSingleton<ISaleRepository, SaleRepository>();
					services.AddSingleton<IAuthenticationService, AuthenticationService>();
					services.AddSingleton<IAccountingService, AccountingService>();
					services.AddSingleton<IProductService, ProductService>();
					services.AddSingleton<IUserStore, UserStore>();
				});
		}
	}
}
