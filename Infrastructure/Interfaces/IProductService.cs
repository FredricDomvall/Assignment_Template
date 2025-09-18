using Infrastructure.Models;

namespace Infrastructure.Interfaces;

public interface IProductService
{
    ProductResult<Product> AddProduct(Product product);
    ProductResult<IEnumerable<Product>> GetAllProducts();

}
