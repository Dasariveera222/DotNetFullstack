using Product_Api.models;


//API also provides extra methods for the following requirements:
//a.Method to returns Products based on Category
//b. Method to returns Out of Stock Products
//c. Method to returns Products between the given range of
//Price.
//d. Method that returns only Categories names

namespace Product_Api.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        List<Product> ProductCategory(string category);
        string StockEnquiry(string category);
       List< Product> GetProductByPrice(int start, int end);
        List<string> GetCategories();





    }
}
