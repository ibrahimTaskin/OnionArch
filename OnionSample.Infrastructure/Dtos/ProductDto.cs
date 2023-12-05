namespace OnionSample.Infrastructure.Dtos
{
    public record ProductDto
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public int StockQuantity { get; init; }
        public List<string> Categories { get; init; } // Birden çok kategori için
    }
}
