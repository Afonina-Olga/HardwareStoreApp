using HardwareStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HardwareStoreApp
{
	public class HardwareStoreAppDbContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public DbSet<Sale> Sales { get; set; }

		public DbSet<Store> Stores { get; set; }

		public DbSet<Product> Products { get; set; }

		public DbSet<Balance> Balances { get; set; }

		public HardwareStoreAppDbContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Users table

			modelBuilder.Entity<User>().Property(user => user.Role).IsRequired();
			modelBuilder.Entity<User>().Property(user => user.Login).IsRequired();
			modelBuilder.Entity<User>().Property(user => user.Password).IsRequired();
			modelBuilder.Entity<User>().Property(user => user.Login).HasMaxLength(50);
			modelBuilder.Entity<User>().Property(user => user.Password).HasMaxLength(20);
			modelBuilder.Entity<User>().HasData(new User
			{
				Id = 1,
				Login = "SuperAdmin",
				Password = "123",
				Role = Role.Admin
			});

			#endregion

			#region Products table

			modelBuilder.Entity<Product>().Property(product => product.Name).IsRequired();
			modelBuilder.Entity<Product>().Property(product => product.Name).HasMaxLength(100);
			modelBuilder.Entity<Product>().OwnsOne(product => product.Category);

			#endregion

			#region Sales table

			modelBuilder.Entity<Sale>().Property(sale => sale.Date).IsRequired();
			modelBuilder.Entity<Sale>().Property(sale => sale.Price).IsRequired();

			#endregion

			#region Store table

			modelBuilder.Entity<Store>().OwnsOne(store => store.Address);

			#endregion

			#region Balances table

			modelBuilder.Entity<Balance>().Property(balance => balance.Price).IsRequired();
			modelBuilder.Entity<Balance>().Property(balance => balance.Count).IsRequired();

			#endregion

			#region Relations

			modelBuilder.Entity<Sale>()
				.HasOne(sale => sale.Product)
				.WithMany(product => product.Sales)
				.HasForeignKey(sale => sale.ProductId);

			modelBuilder.Entity<Sale>()
				.HasOne(sale => sale.Store)
				.WithOne(store => store.Sale)
				.HasForeignKey<Store>(store => store.SaleId);

			modelBuilder.Entity<Balance>()
				.HasOne(balance => balance.Product)
				.WithMany(product => product.Balances)
				.HasForeignKey(balance => balance.ProductId);

			modelBuilder.Entity<Balance>()
				.HasOne(balance => balance.Store)
				.WithOne(product => product.Balance)
				.HasForeignKey<Store>(sale => sale.BalanceId);

			#endregion

			base.OnModelCreating(modelBuilder);
		}
	}
}
