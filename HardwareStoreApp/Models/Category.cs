namespace HardwareStoreApp.Models
{
	public class Category : DomainObject
	{
		public string Name { get; set; }

		public Category(string name)
		{
			Name = name;
		}
	}
}
