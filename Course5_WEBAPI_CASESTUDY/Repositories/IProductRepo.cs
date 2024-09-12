using Product_Api.models;

namespace Product_Api.Repositories
{
    public interface IProductRepo
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);


    }
}
