using Domain;

namespace Automapper.UI.Services
{
    public interface IProductRepository
    {
        Product UpdateExistingProduct(Product product);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}
