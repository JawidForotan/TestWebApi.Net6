using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok("Hi");
        }
    }
}
