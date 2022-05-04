using System;
using System.Windows.Forms;
using HardwareStoreApp.Models;
using HardwareStoreApp.Repositories;

namespace HardwareStoreApp
{
	public partial class CreateProductsAndStoresForm : Form
	{
		private readonly IStoreRepository _storeRepository;
		private readonly IProductRepository _productRepository;

		public CreateProductsAndStoresForm(IProductRepository productRepository, IStoreRepository storeRepository)
		{
			_storeRepository = storeRepository;
			_productRepository = productRepository;
			InitializeComponent();
		}

		private async void BtnAddProduct_Click(object sender, EventArgs e)
		{
			var name = txtProductName.Text.Trim();
			var category = txtCategory.Text.Trim();

			try
			{
				var isExists = await _productRepository.IsExists(name, category);
				if (!isExists)
				{
					var result = await _productRepository.Create(new Product()
					{
						Category = new Category(category),
						Name = name
					});

					if (result != null)
						MessageBox.Show("Успешно");
				}
				else
					MessageBox.Show("Товар уже добавлен");
			}
			catch
			{
				MessageBox.Show("Что-то пошло не так...");
			}
		}

		private async void BtnAddStore_Click(object sender, EventArgs e)
		{
			var name = txtStoreName.Text.Trim();
			var district = txtDistrict.Text.Trim();
			var street = txtStreet.Text.Trim();
			var house = txtHouse.Text.Trim();

			try
			{
				var isExists = await _storeRepository.IsExists(district, name);
				if (!isExists)
				{
					var result = await _storeRepository.Create(new Store()
					{
						Name = name,
						Address = new Address()
						{
							Region = district,
							Street = street,
							House = house
						}
					});

					if (result != null)
						MessageBox.Show("Успешно");
				}
				else
					MessageBox.Show("Магазин уже добавлен");
			}
			catch
			{
				MessageBox.Show("Что-то пошло не так...");
			}
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
