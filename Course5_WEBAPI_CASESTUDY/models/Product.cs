using Microsoft.EntityFrameworkCore;

namespace Product_Api.models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }


    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
    
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }


    public class ProductDbContext : DbContext
    {
        public DbSet<Product> products {  get; set; }
        public DbSet<User> Users {  get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
         : base(options)
        {

        }



    }
}
