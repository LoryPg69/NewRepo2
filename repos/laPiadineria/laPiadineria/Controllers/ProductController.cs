
using laPiadineria.Services.ProductDataService;
using Microsoft.AspNetCore.Mvc;

namespace laPiadineria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductDataService _productDataService;

        public ProductController(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }

        [HttpGet("s")]
        public IActionResult GetPiadine()     //trova gli ingredienti con id piada
        {
            return Ok(_productDataService.GetProducts());
        }

        [HttpGet]     //trova tutti i prodotti
        public IActionResult GetProducts()
        {
            return Ok(_productDataService.GetProducts());
        }

        [HttpGet("{productId:int}")]     //trova il prdotto co id
        public IActionResult GetProductAllProduct(int productId)
        {
            try
            {
                return Ok(_productDataService.GetProducts().Where(x => x.Id == productId));
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpDelete("{productId:int}")] //elimina prodotti
        public IActionResult DeleteProduct(int productId)
        {
            try
            {
                var x = _productDataService.GetProducts().First(x => x.Id == productId);
                _productDataService.DeleteProduct(x);
                return NoContent();
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
