using OnionSample.Infrastructure.Dtos;

namespace OnionSample.Application.Interfaces
{
    public interface IProductService
    {
        List<ProductDto> GetAllProducts();
        // Diğer iş mantığı hizmeti metotları...
    }
}
