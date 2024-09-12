using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductDbContext _context;

        public ProductController(ProductDbContext context)
        {
            _context = context;
        }


        
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> Products = _context.Products.ToList();
            return Ok(Products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(new { status = "Data added successfully" });
        }

        [HttpPut]
        public IActionResult EditProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return Ok(new { status = "Data Updated successfully" });
        }

        [HttpDelete]

        public IActionResult DeleteProduct(int id) 
        {
            Product pid = _context.Products.Find(id);

            if (pid != null)
            {
                _context.Products.Remove(pid);
                _context.SaveChanges();
                return Ok(new { status = "Data deleted successfully" });

            }
            else
            {
                return NotFound(new { status = "Data Not found" });
            }

        }


    }
}
