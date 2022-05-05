using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public class SaleRepository : Repository<Sale>, ISaleRepository
	{
		private readonly HardwareStoreAppDbContextFactory _contextFactory;

		public SaleRepository(HardwareStoreAppDbContextFactory contextFactory)
			: base(contextFactory)
		{
			_contextFactory = contextFactory;
		}

		public override async Task<IEnumerable<Sale>> Get()
		{
			using var context = _contextFactory.CreateDbContext();

			var sales = await context.Sales
				.Include(_ => _.Product)
				.Include(_ => _.Store)
				.ToListAsync();

			return sales;
		}
	}
}
