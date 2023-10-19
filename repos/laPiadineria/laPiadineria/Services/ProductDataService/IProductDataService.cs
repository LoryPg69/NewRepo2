using laPiadineria.Dtos;
using laPiadineria.Models;

namespace laPiadineria.Services.ProductDataService
{
    public interface IProductDataService
    {
        IEnumerable<Product> GetProducts();
        bool DeleteProduct(Product product);
    }
}
