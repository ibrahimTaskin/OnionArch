using OnionSample.Application.Interfaces;
using OnionSample.Infrastructure.Dtos;
using OnionSample.Infrastructure.Repositories.Product;

namespace OnionSample.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductDto> GetAllProducts()
        {
            // İş mantığına özgü gerekirse başka işlemler yapabilirsiniz.
            var products = _productRepository.GetAllProducts();
            return products;
        }
        // Diğer iş mantığı hizmeti metotları...
    }
}
