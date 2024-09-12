using Product_Api.models;
using Product_Api.Repositories;

namespace Product_Api.Services
{
    public class ProductService : IProductService
    {
        public IProductRepo _repository;
        public ProductService(IProductRepo repository)
        {
            _repository = repository;
        }

        public void AddProduct(Product product)
        {
            _repository.AddProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }

        public Product GetProduct(int id)
        {
            return _repository.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }

        public void UpdateProduct(Product product)
        {
            _repository.UpdateProduct(product);
        }
    }
}
