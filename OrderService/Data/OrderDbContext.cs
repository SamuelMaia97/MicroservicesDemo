using Microsoft.EntityFrameworkCore;
using OrderService.Models;

namespace OrderService.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.ProductPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>().Ignore(o => o.TotalAmount);

            base.OnModelCreating(modelBuilder);
        }
    }
}
