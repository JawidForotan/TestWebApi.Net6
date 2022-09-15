

namespace TestWebApi.Net6.Interfaces
{
    public interface IProductService
    {
        Task<Product> Create(Product newProduct);
        Task<Product> getOneProduct(int productId);
        Task<List<Product>> getAllProduct();
        Task<Product> updateProduct(Product product);
        Task deleteProduct(int productId);
    }
}
