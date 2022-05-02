namespace HardwareStoreApp.Models
{
	/// <summary>
	/// Учет товаров в магазинах
	/// </summary>
	public class Balance : DomainObject
	{
		/// <summary>
		/// Товар
		/// </summary>
		public Product Product { get; set; }

		/// <summary>
		/// Внешний ключ в таблице Product
		/// </summary>
		public int ProductId { get; set; }

		/// <summary>
		/// Магазин
		/// </summary>
		public Store Store { get; set; }

		public int StoreId { get; set; }

		/// <summary>
		/// Цена
		/// </summary>
		public decimal Price { get; set; }

		/// <summary>
		/// Количество товара в наличии
		/// </summary>
		public int Count { get; set; }
	}
}
