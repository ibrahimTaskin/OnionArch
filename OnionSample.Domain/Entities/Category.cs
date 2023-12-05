namespace OnionSample.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Kategorinin ürünleri
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
