using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

		public async Task<IEnumerable<Sale>> Get(DateTime start, DateTime end)
		{
			var sales = await Get();
			return sales.Where(_ => _.Date.Date >= start.Date && _.Date.Date <= end.Date).ToList();
		}

		public async Task<IEnumerable<Sale>> GetByStore(DateTime start, DateTime end, int? id = null)
		{
			var sales = await Get(start, end);

			if (id != null)
				return sales.Where(_ => _.Store.Id == id).ToList();

			return sales;
		}
	}
}
