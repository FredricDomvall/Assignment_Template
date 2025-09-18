using Infrastructure.Models;

namespace Infrastructure.Interfaces;

public interface IProductService
{
    AnswerOutcome<Product> AddProduct(Product product);
    AnswerOutcome<IEnumerable<Product>> GetAllProducts();

}
