using HardwareStoreApp.Models;

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
	}
}
