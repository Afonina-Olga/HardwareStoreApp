using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;

namespace HardwareStoreApp.Services
{
	public class ProductService : IProductService
	{
		private readonly IBalanceRepository _balanceRepository;
		private readonly IProductRepository _productRepository;
		private readonly IStoreRepository _storeRepository;

		public ProductService(
			IBalanceRepository balanceRepository,
			IProductRepository productRepository,
			IStoreRepository storeRepository)
		{
			_balanceRepository = balanceRepository;
			_productRepository = productRepository;
			_storeRepository = storeRepository;
		}

		public async Task<IEnumerable<Balance>> Find(
			string region,
			string store,
			string name,
			string category,
			bool fullSearcMode)
		{
			var result = await _balanceRepository.Get();
			var withRegion = !string.IsNullOrEmpty(region);
			var withStore = !string.IsNullOrEmpty(store);
			var withName = !string.IsNullOrEmpty(name);
			var withCategory = !string.IsNullOrEmpty(category);

			if (withRegion)
				result = result.Where(_ => _.Store.Address.Region == region);

			if (withStore)
				result = result.Where(_ => _.Store.Name == store);

			if (withName)
				result = result.Where(_ => _.Product.Name.StartsWith(name));

			if (withCategory)
				result = result.Where(_ => _.Product.Category.Name == category);

			if (!result.Any() && fullSearcMode)
			{
				var fullSearchResult = await _balanceRepository.Get();
				return fullSearchResult.Where(_ => _.Product.Name == name);
			}

			return result;
		}

		public async Task<IEnumerable<Balance>> GetAll()
		{
			var result = await _balanceRepository.Get();
			return result;
		}

		public async Task<string[]> GetCategories()
		{
			var result = await _productRepository.GetAllCategories();
			return result.Select(_ => _.Name).ToArray();
		}

		public async Task<string[]> GetRegions()
		{
			var result = await _storeRepository.GetLocations();
			return result.Select(_ => _.Region).ToArray();
		}

		public async Task<IEnumerable<Store>> GetStores()
		{
			var result = await _storeRepository.GetStores();
			return result;
		}

		public async Task<IEnumerable<Store>> GetStoresByRegion(string region)
		{
			var result = await _storeRepository.GetStoresByRegion(region);
			return result;
		}
	}
}
