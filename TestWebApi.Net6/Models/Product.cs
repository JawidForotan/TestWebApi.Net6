namespace TestWebApi.Net6.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<ProductCategory>? ProductCategories { get; set; }

    }
}

