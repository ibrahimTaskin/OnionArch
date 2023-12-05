using OnionSample.Domain.Entities;

namespace OnionSample.Infrastructure.Dtos
{
    public record CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Kategorinin ürünleri
        public List<Product> Products { get; set; }
    }
}
