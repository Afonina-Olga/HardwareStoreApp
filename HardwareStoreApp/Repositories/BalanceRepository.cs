using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
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
	}
}
