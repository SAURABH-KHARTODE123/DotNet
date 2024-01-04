using Microsoft.EntityFrameworkCore;
using IOCWebApp.Models;
using MySql.Data.MySqlClient;

namespace IOCWebApp.Contexts
{
    public class CollectionContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = "server=localhost;port=3306;user=root;pwd=welcome;database=ecommerce";
            optionsBuilder.UseMySQL(conString);
            // Console.WriteLine(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);
                entity.Property(e => e.Title);
                entity.Property(e => e.Picture);
                entity.Property(e => e.Description);
                entity.Property(e => e.UnitPrice);
                entity.Property(e => e.Available);
                entity.Property(e => e.CategoryId);
                entity.Property(e => e.UnitInStock);
            });
        }
    }
}