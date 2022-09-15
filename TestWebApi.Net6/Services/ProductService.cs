namespace TestWebApi.Net6.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _applicationDbContext;


        public ProductService(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;

        }
        public async Task<Product> Create(Product product)
        {
            _applicationDbContext.products.Add(product);
            await _applicationDbContext.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> getAllProduct()
        {
            return await _applicationDbContext.products.ToListAsync();
        }

        public async Task<Product> getOneProduct(int productId)
        {
            var productById = await _applicationDbContext.products.FindAsync(productId);
            return productById;
        }

        public async Task<Product> updateProduct(Product product)
        {
            _applicationDbContext.products.Update(product);
            await _applicationDbContext.SaveChangesAsync();
            return product;
        }

        public async Task deleteProduct(int productId)
        {
            var productTodelete = await _applicationDbContext.products.FindAsync(productId);
            _applicationDbContext.products.Remove(productTodelete);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
