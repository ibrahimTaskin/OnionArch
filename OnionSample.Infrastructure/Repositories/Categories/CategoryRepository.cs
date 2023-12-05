using OnionSample.Infrastructure.Context;
using OnionSample.Infrastructure.Dtos;
using Microsoft.EntityFrameworkCore;

namespace OnionSample.Infrastructure.Repositories.Product
{

    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<CategoryDto> GetAllCategories()
        {
            return _context.Categories.Include(p => p.ProductCategories).ThenInclude(t => t.Product).Select(s => s.ToDto()).ToList();
        }
        // Diğer repository metotları...
    }
}
