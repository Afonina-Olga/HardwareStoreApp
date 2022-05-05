using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public class BalanceRepository : Repository<Balance>, IBalanceRepository
	{
		private readonly HardwareStoreAppDbContextFactory _contextFactory;

		public BalanceRepository(HardwareStoreAppDbContextFactory contextFactory)
			: base(contextFactory)
		{
			_contextFactory = contextFactory;
		}

		public async Task<Balance> Get(int productId, int storeId, decimal price)
		{
			using var context = _contextFactory.CreateDbContext();
			var user = await context.Balances
				.FirstOrDefaultAsync(_ => _.ProductId == productId && _.StoreId == storeId && _.Price == price);
			return user;
		}

		public async Task<Balance> Get(int productId, int storeId, bool inStock = false)
		{
			using var context = _contextFactory.CreateDbContext();
			if (inStock)
			{
				return await context.Balances
					.FirstOrDefaultAsync(_ => _.ProductId == productId && _.StoreId == storeId && _.Count > 0);
			}

			return await context.Balances
					.FirstOrDefaultAsync(_ => _.ProductId == productId && _.StoreId == storeId);
		}

		public async Task<IEnumerable<Balance>> Get(bool inStock = false)
		{
			using var context = _contextFactory.CreateDbContext();

			var enities = await context.Balances
				.Include(_ => _.Product)
				.Include(_ => _.Store)
				.ToListAsync();

			if (inStock)
				return enities.Where(_ => _.Count > 0);

			return enities;
		}
	}
}
