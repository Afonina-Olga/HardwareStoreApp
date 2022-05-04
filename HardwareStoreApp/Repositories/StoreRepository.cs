using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public class StoreRepository : Repository<Store>, IStoreRepository
	{
		private readonly HardwareStoreAppDbContextFactory _contextFactory;

		public StoreRepository(HardwareStoreAppDbContextFactory contextFactory)
			: base(contextFactory)
		{
			_contextFactory = contextFactory;
		}

		public async Task<bool> IsExists(string region, string name)
		{
			using var context = _contextFactory.CreateDbContext();
			var store = await context.Stores.FirstOrDefaultAsync(
				_ => _.Name == name && _.Address.Region == region);
			return store != null;
		}
	}
}
