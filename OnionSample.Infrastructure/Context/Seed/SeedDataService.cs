using Microsoft.Extensions.DependencyInjection;
using OnionSample.Domain.Entities;

namespace OnionSample.Infrastructure.Context.Seed
{
    public static class SeedDataService
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                if (context.Products.Any())
                {
                    // Veritabanında zaten veri varsa seed işlemini yapma
                    return;
                }

                // Dummy veri ekleme
                var products = new List<Product>
                {
                    new Product { Name = "Product 1", Price = 19.99m, StockQuantity = 100 },
                    new Product { Name = "Product 2", Price = 29.99m, StockQuantity = 50 },
                    // Diğer dummy ürünler...
                };

                context.Products.AddRange(products);

                // Dummy Category verileri
                var categories = new List<Category>
                {
                    new Category { Name = "Category 1" },
                    new Category { Name = "Category 2" },
                    // Diğer dummy kategoriler...
                };

                context.Categories.AddRange(categories);

                // Dummy ProductCategory verileri
                var productCategories = new List<ProductCategory>
                {
                    new ProductCategory { ProductId = 1, CategoryId = 1 },
                    new ProductCategory { ProductId = 2, CategoryId = 1 },
                    // Diğer dummy ProductCategory'ler...
                };

                //context.ProductCategories.AddRange(productCategories);
                context.SaveChanges();
            }
        }
    }
}
