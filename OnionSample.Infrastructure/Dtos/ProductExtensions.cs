using OnionSample.Domain.Entities;

namespace OnionSample.Infrastructure.Dtos
{
    public static class ProductExtensions
    {
        public static ProductDto ToDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                Categories = product.ProductCategories.Select(pc => pc.Category.Name).ToList()
            };
        }

        public static CategoryDto ToDto(this Category product)
        {
            return new CategoryDto
            {
                Id = product.Id,
                Name = product.Name,
                Products = product.ProductCategories.Select(pc => pc.Product).ToList()
            };
        }
    }
}
