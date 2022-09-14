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
    }
}
