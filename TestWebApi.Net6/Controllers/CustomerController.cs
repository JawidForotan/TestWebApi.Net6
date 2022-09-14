using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _ICustomerService;

        public CustomerController(ICustomerService ICustomerService)
        {
            _ICustomerService = ICustomerService;

        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            await _ICustomerService.Create(customer);
            return Ok("Created successfully");
        }
    }
}
