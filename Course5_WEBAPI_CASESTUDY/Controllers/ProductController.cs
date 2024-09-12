using Microsoft.AspNetCore.Mvc;
using Product_Api.models;
using Microsoft.AspNetCore.Http;
using Product_Api.Services;
using Microsoft.AspNetCore.Authorization;

namespace Product_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _service.AddProduct(product);
            return Ok(new { result = "Product Details added to db" });
        }
        [HttpGet("id")]

        public IActionResult GetProduct(int id)
        {
            return Ok(_service.GetProduct(id));
        }

        [HttpGet]

        public IActionResult GetProducts()
        {
            return Ok(_service.GetProducts());
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _service.UpdateProduct(product);
            return Ok(new { result = "Product Details Updated to db" });
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _service.DeleteProduct(id);
            return Ok(new { result = "Product removed from db" });
        }

        [HttpGet("category")]
        public IActionResult ProductCategory(string category)
        {
            return Ok(_service.ProductCategory(category));
        }
        [Route("[action]/{category}")]

        [HttpGet]
        public IActionResult StockEnquiry(string category)
        {
            return Ok(_service.StockEnquiry(category));
        }


        [HttpGet]
        [Route("ProductsApiController/GetProductByPrice")]
        // Or use [HttpGet("nostock")]
        public IActionResult GetProductByPrice(int start, int end)

        {
            
                return Ok(_service.GetProductByPrice(start, end));
            
        }

        [HttpGet]
        [Route("ProductsApiController/GetCategories")]
        public IActionResult GetCategories()

        {
            if (_service.GetCategories() == null)
            {
                return NotFound(new { result = "No such record found " });
            }
            else
            {
                return Ok(_service.GetCategories());
            }
        }

    }
}
