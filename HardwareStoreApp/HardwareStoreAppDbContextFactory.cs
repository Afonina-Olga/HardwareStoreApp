using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace HardwareStoreApp
{
	public class HardwareStoreAppDbContextFactory : IDesignTimeDbContextFactory<HardwareStoreAppDbContext>
	{
		private readonly Action<DbContextOptionsBuilder> _configureDbContext;

		public HardwareStoreAppDbContextFactory() { }

		public HardwareStoreAppDbContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
		{
			_configureDbContext = configureDbContext;
		}

		public HardwareStoreAppDbContext CreateDbContext(string[] args = null)
		{
			var options = new DbContextOptionsBuilder<HardwareStoreAppDbContext>();
			options.UseSqlite(@"Data Source=HardwareStoreAppDb.db");
			return new HardwareStoreAppDbContext(options.Options);
		}
	}
}
