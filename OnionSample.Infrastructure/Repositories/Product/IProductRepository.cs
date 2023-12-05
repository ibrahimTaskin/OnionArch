using OnionSample.Infrastructure.Dtos;

namespace OnionSample.Infrastructure.Repositories.Product
{
    public interface IProductRepository
    {
        List<ProductDto> GetAllProducts();
        // Diğer repository metotları...
    }
}
