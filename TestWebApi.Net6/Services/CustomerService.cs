namespace TestWebApi.Net6.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;

        }
        public async Task Create(Customer customer)
        {

            _applicationDbContext.customers.Add(customer);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
