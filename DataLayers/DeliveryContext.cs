using Delivery.DataLayers.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.DataLayers
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options)
        {

        }

        public DbSet<Entities.User> Users { get; set; }
        public DbSet<Entities.Restaurant> Restaurants { get; set; }
        public DbSet<Entities.MenuItem> MenuItems { get; set; }
        public DbSet<Entities.Order> Orders { get; set; }
        public DbSet<Entities.OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("DeliverySchema");

            modelBuilder.Entity<User>().ToTable("User").HasKey(k => k.UserID);
            modelBuilder.Entity<User>().HasMany(u => u.Orders).WithOne(u => u.User);

            modelBuilder.Entity<Restaurant>().ToTable("Restaurant").HasKey(k => k.RestaurantID);
            modelBuilder.Entity<Restaurant>().HasMany(r => r.MenuItems).WithOne(mi => mi.Restaurant);
            modelBuilder.Entity<Restaurant>().HasMany(r => r.Orders).WithOne(mi => mi.Restaurant);

            modelBuilder.Entity<OrderItem>().HasKey(oi => oi.OrderItemID);
            modelBuilder.Entity<OrderItem>().HasOne(oi => oi.Order).WithMany(o => o.OrderItems).HasForeignKey(oi => oi.OrderID);
            modelBuilder.Entity<OrderItem>().HasOne(oi => oi.MenuItem).WithMany().HasForeignKey(oi => oi.MenuItemId);

            modelBuilder.Entity<Order>().ToTable("Order").HasKey(k => k.OrderID);
            modelBuilder.Entity<Order>().HasOne(e => e.User).WithMany(u => u.Orders).HasForeignKey(e => e.UserID);
            modelBuilder.Entity<Order>().HasOne(e => e.Courier).WithMany().HasForeignKey(e => e.CourierID);
            modelBuilder.Entity<Order>().HasOne(e => e.Restaurant).WithMany().HasForeignKey(e => e.RestaurantID_Order);

            modelBuilder.Entity<MenuItem>().ToTable("MenuItem").HasKey(k => k.ProductID);
            modelBuilder.Entity<MenuItem>().HasOne(mi => mi.Restaurant).WithMany(r => r.MenuItems).HasForeignKey(mi => mi.RestaurantID_MenuItem);

            modelBuilder.Entity<Courier>().ToTable("Courier").HasKey(k => k.CourierID);
        }
    }
}
