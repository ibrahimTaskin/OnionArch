using OnionSample.Infrastructure.Dtos;

namespace OnionSample.Application.Interfaces
{
    public interface ICategoryService
    {
        List<CategoryDto> GetAllCategories();
        // Diğer iş mantığı hizmeti metotları...
    }
}
