using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public class ProductRepository : Repository<Product>, IProductRepository
	{
		private readonly HardwareStoreAppDbContextFactory _contextFactory;

		public ProductRepository(HardwareStoreAppDbContextFactory contextFactory)
			: base(contextFactory)
		{
			_contextFactory = contextFactory;
		}

		public async Task<IEnumerable<Category>> GetAllCategories()
		{
			using var context = _contextFactory.CreateDbContext();
			var entities = await context.Products.ToListAsync();
			return entities.Select(_ => _.Category);
		}

		public async Task<bool> IsExists(string name, string category)
		{
			using var context = _contextFactory.CreateDbContext();
			var store = await context.Products.FirstOrDefaultAsync(
				_ => _.Name == name && _.Category.Name == category);
			return store != null;
		}
	}
}
