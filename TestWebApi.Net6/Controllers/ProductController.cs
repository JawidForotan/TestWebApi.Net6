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

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetOne(int id)
        {
            var entity = await _IproductService.getOneProduct(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var entity = await _IproductService.getAllProduct();
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPut]
        public async Task<ActionResult<Product>> Update(Product product)
        {
            await _IproductService.updateProduct(product);
            return Ok(product);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var productToDelete = await _IproductService.getOneProduct(id);
            if (productToDelete == null)
            {
                return NotFound();
            }
            await _IproductService.deleteProduct(id);
            return Ok();
        }

    }
}
