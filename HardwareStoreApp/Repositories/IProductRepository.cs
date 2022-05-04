using HardwareStoreApp.Models;
using System.Threading.Tasks;

namespace HardwareStoreApp.Repositories
{
	public interface IProductRepository : IRepository<Product>
	{
		Task<bool> IsExists(string name, string category);
	}
}
