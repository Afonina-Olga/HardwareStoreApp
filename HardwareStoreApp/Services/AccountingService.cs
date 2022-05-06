using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;
using System;
using System.Threading.Tasks;

namespace HardwareStoreApp.Services
{
	public class AccountingService : IAccountingService
	{
		private readonly IBalanceRepository _balanceRepository;
		private readonly ISaleRepository _saleRepository;

		public AccountingService(IBalanceRepository balanceRepository, ISaleRepository saleRepository)
		{
			_balanceRepository = balanceRepository;
			_saleRepository = saleRepository;
		}

		public async Task<bool> RegisterSale(int productId, int storeId, DateTime date, decimal price, int count)
		{
			var balance = await _balanceRepository.Get(productId, storeId);
			if (balance != null)
			{
				await _saleRepository.Create(new Sale()
				{
					Date = date,
					Price = price,
					IdProduct = productId,
					IdStore = storeId,
					Count = count
				});

				balance.Count -= count;
				
				if (balance.Count == 0)
					await _balanceRepository.Delete(balance.Id);
				else
					await _balanceRepository.Update(balance.Id, balance);
				return true;
			}
			return false;
		}
	}
}
