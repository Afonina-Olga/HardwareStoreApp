using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

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

		public async Task<IEnumerable<Address>> GetLocations()
		{
			using var context = _contextFactory.CreateDbContext();
			var entities = await context.Stores.ToListAsync();
			return entities.Select(_ => _.Address);
		}

		public async Task<IEnumerable<Store>> GetStores()
		{
			using var context = _contextFactory.CreateDbContext();
			var entities = await context.Stores.ToListAsync();
			return entities;
		}

		public async Task<IEnumerable<Store>> GetStoresByRegion(string region)
		{
			using var context = _contextFactory.CreateDbContext();
			var entities = await context.Stores
				.AsNoTracking()
				.Where(_ => _.Address.Region == region)
				.ToListAsync();
			return entities;
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
