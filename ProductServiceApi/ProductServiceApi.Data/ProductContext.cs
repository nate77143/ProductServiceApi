using Microsoft.EntityFrameworkCore;
using ProductServiceApi.Model;

namespace ProductServiceApi.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductSeedConfiguration.Configure(modelBuilder.Entity<Product>());

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)"); 
        }

    }
}
