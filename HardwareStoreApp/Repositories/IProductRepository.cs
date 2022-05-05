using System.Collections.Generic;
using System.Threading.Tasks;

using HardwareStoreApp.Models;

namespace HardwareStoreApp.Repositories
{
	public interface IProductRepository : IRepository<Product>
	{
		Task<bool> IsExists(string name, string category);

		Task<IEnumerable<Category>> GetAllCategories();
	}
}
