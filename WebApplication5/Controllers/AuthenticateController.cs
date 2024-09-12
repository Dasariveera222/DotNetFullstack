using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;


namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        ProductDbContext _context;
        public AuthenticateController(ProductDbContext context)
        {
            _context = context;
        }


        [HttpPost]

        public IActionResult  Login(String uname, string pswd)
        {
            var user = _context.Users.SingleOrDefault(u => u.UserName == uname);
            var password = _context.Users.SingleOrDefault(u => u.Password == pswd);
            if (user == null)
            {
                // User not found
                return Unauthorized("Invalid username or password.");

            }
            else
            {
                if (password == null) 
                {
                    return Unauthorized("Invalid username or password.");
                }
                else
                {
                    return Ok("Login successful.");
                }
            }
        }




    }


}
