
using Product_Api.models;
using System.Linq;

namespace Product_Api.Repositories
{
    public class ProductRepo : IProductRepo
    {
        ProductDbContext _context;
        public ProductRepo(ProductDbContext context) 
        {
            _context = context ;
        }
        public void AddProduct(Product product)
        {
            _context.products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product p = _context.products.Find(id);
            _context.Remove(p);
            _context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _context.products.Find(id);
        }

        public List<Product> GetProducts()
        {
            List<Product> products = _context.products.ToList();
            return products;
        }

        public void UpdateProduct(Product  product)
        {
            _context.products.Update(product);
            _context.SaveChanges();
        }
    }
}
