using OnionSample.Application.Interfaces;
using OnionSample.Infrastructure.Dtos;
using OnionSample.Infrastructure.Repositories.Product;

namespace OnionSample.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<CategoryDto> GetAllCategories()
        {
            // İş mantığına özgü gerekirse başka işlemler yapabilirsiniz.
            var categories = _categoryRepository.GetAllCategories();
            return categories;
        }
    }
}
