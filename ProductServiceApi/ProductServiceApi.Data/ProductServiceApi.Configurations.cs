using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductServiceApi.Model;

namespace ProductServiceApi.Data
{
    public partial class ProductSeedConfiguration
    {
        public static void Configure(EntityTypeBuilder<Product> builder)
        {
            // Seed data for Products table
            builder.HasData(
                new Product { Id = 1, Name = "Laptop", Price = 999.99M, Description = "A powerful laptop", Quantity = 5 },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99M, Description = "A high-end smartphone", Quantity = 10 },
                new Product { Id = 3, Name = "Tablet", Price = 299.99M, Description = "A lightweight tablet", Quantity = 15 }
            );
        }
    }
}
