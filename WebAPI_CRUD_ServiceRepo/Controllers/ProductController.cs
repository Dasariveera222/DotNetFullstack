using Microsoft.AspNetCore.Mvc;
using Product_Api.models;
using Microsoft.AspNetCore.Http;
using Product_Api.Services;

namespace Product_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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


            
    }
}
