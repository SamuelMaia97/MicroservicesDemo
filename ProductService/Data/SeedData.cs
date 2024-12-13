using ProductService.Models;

namespace ProductService.Data
{
    public static class SeedData
    {
        public static void Initialize(ProductDbContext dbContext)
        {
            if (!dbContext.Products.Any())
            {
                dbContext.Products.AddRange(
                    new Product { Name = "Laptop", Price = 1200.00m },
                    new Product { Name = "Smartphone", Price = 799.99m },
                    new Product { Name = "Headphones", Price = 199.99m }
                );

                dbContext.SaveChanges();
            }
        }
    }
}
