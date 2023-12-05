namespace OnionSample.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        // Ürünün birden çok kategorisi
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
