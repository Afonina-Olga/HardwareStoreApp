namespace HardwareStoreApp.Models
{
	/// <summary>
	/// Адрес магазина
	/// </summary>
	public class Address : DomainObject
	{
		/// <summary>
		/// Район
		/// </summary>
		public string Region { get; set; }

		/// <summary>
		/// Улица
		/// </summary>
		public string Street { get; set; }

		/// <summary>
		/// Дом
		/// </summary>
		public string House { get; set; }

		public override string ToString()
		{
			return $"{Region}, ул. {Street}, д. {House}";
		}
	}
}
