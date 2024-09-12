using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }

    public class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Users> Users { get; set; }
        
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
         : base(options)
        {

        }
    }
}
