using OnionSample.Infrastructure.Dtos;

namespace OnionSample.Infrastructure.Repositories.Product
{
    public interface ICategoryRepository
    {
        List<CategoryDto> GetAllCategories();
        // Diğer repository metotları...
    }
}
