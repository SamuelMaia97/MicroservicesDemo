using OrderService.Models;

namespace OrderService.Data
{
    public class SeedData
    {
        public static void Initialize(OrderDbContext dbContext)
        {
            if (!dbContext.Orders.Any())
            {
                dbContext.Orders.AddRange(
                    new Order 
                    { 
                        ProductId = 1, 
                        ProductName = "Laptop", 
                        ProductPrice = 1200.00m, 
                        Quantity = 2
                    },
                    new Order 
                    { 
                        ProductId = 2, 
                        ProductName = "Smartphone", 
                        ProductPrice = 799.99m, 
                        Quantity = 1
                    },
                    new Order 
                    { 
                        ProductId = 3, 
                        ProductName = "Headphones", 
                        ProductPrice = 199.99m, 
                        Quantity = 5
                    }
                );

                dbContext.SaveChanges();
            }
        }
    }
}
