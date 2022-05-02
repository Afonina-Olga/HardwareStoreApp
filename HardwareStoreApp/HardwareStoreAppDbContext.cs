using Microsoft.EntityFrameworkCore;

namespace HardwareStoreApp
{
	public class HardwareStoreAppDbContext : DbContext
	{
		public HardwareStoreAppDbContext(DbContextOptions options) : base(options) { }
	}
}
