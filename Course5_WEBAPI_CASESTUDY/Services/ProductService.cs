using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
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

        public List<Product> ProductCategory(string category)
        {
            // Retrieve and filter products based on the category
            var products = _repository.GetProducts().Where(x => x.Category == category).ToList();

            // Return the list of filtered products
            return products;
        }

        public string StockEnquiry(string category)
        {
            var stock = _repository.GetProducts().Where(x => x.Quantity ==0).ToList();
            if(stock!=null)
            {
                return "out of stock";
            }
            else
            {
                return "Stock exists";
            }
        }

        public List<Product> GetProductByPrice(int start, int end)
        {
            var FilterProducts = _repository.GetProducts().Where(prod => prod.UnitPrice > start && prod.UnitPrice < end).ToList();

                return FilterProducts;
           
                
            
        }

        public List<string> GetCategories()
        {
            var cat = _repository.GetProducts().Select(prod => prod.Category).Distinct().ToList();
            return cat;
        }

    }


    //void StockEnquiry(string category);
    ////Product RangeOfProducts(int start, int end);
    ////Product Category(string category);


}
