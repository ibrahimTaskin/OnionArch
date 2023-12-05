using OnionSample.Infrastructure.Context;
using OnionSample.Infrastructure.Dtos;
using Microsoft.EntityFrameworkCore;

namespace OnionSample.Infrastructure.Repositories.Product
{

    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ProductDto> GetAllProducts()
        {
            return _context.Products.Include(p => p.ProductCategories).ThenInclude(t => t.Category).Select(s => s.ToDto()).ToList();
        }
        // Diğer repository metotları...
    }
}
