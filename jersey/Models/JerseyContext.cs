using Microsoft.EntityFrameworkCore;
using jersey.Models;
namespace jersey.Data
{
    
    
        public class JerseyContext : DbContext
        {
            public JerseyContext(DbContextOptions<JerseyContext> options) : base(options) { }

            public DbSet<Customer> Customers { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<Payment> Payments { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Customer>()
                    .HasMany(c => c.Orders)
                    .WithOne(o => o.Customer)
                    .HasForeignKey(o => o.CustomerId);

                modelBuilder.Entity<Order>()
                    .HasMany(o => o.Payments)
                    .WithOne(p => p.Order)
                    .HasForeignKey(p => p.OrderId);
            }
        }
    
}
