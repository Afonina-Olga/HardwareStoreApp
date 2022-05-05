using System;
using System.Threading.Tasks;

namespace HardwareStoreApp.Services
{
	public interface IAccountingService
	{
		Task<bool> RegisterSale(int productId, int storeId, DateTime date, decimal price, int count);
	}
}
