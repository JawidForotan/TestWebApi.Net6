

namespace TestWebApi.Net6.Interfaces
{
    public interface IProductService
    {
        Task<Product> Create(Product newProduct);
    }
}
