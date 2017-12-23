using Microsoft.EntityFrameworkCore;
using FastFood.Models;

namespace FastFood.Data
{
	public class FastFoodDbContext : DbContext
	{
		public FastFoodDbContext()
		{
		}

		public FastFoodDbContext(DbContextOptions options)
			: base(options)
		{
		}

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			if (!builder.IsConfigured)
			{
				builder.UseSqlServer(Configuration.ConnectionString);
			}
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.Entity<Position>()
                .HasAlternateKey(s => s.Name);

            builder.Entity<Item>()
                .HasAlternateKey(s => s.Name);

            builder.Entity<OrderItem>()
                .HasKey(s => new
                {
                    s.ItemId,
                    s.OrderId
                });

            builder.Entity<OrderItem>()
                .HasOne(om => om.Order)
                .WithMany(o => o.OrderItems)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderItem>()
                .HasOne(om => om.Item)
                .WithMany(i => i.OrderItems)
                .OnDelete(DeleteBehavior.Restrict);

        }
	}
}