namespace TestWebApi.Net6.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Adress { get; set; } = string.Empty;
        public List<Order> orders { get; set; }
    }

}
