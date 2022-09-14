using Microsoft.AspNetCore.Mvc;
namespace TestWebApi.Net6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _IproductService;
        private readonly IMapper _mapper;
        public ProductController(IProductService IProductService, IMapper mapper)
        {
            _IproductService = IProductService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> Create(ProductDTO product)
        {
            var newProduct = _mapper.Map<Product>(product);
            var productToDisplay = _mapper.Map<ProductDTO>(await _IproductService.Create(newProduct));
            return Ok(productToDisplay);

        }

        [HttpGet]
        public IActionResult SayHi()
            => Ok("Hi");
    }
}
