namespace TestWebApi.Net6.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Details { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
