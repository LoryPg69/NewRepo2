using LaPiadinereia.API.Models;
using LaPiadinereia.API.Services.ProductDataService;

namespace laPiadineriaAPI.Controllers.Repository
{

        public class ProductRepository : IProductDataService
        {

            List<Product> _products;

            public ProductRepository()
            {
                _products = new List<Product>()
            {
                new Piadina()
                {
                    Id = 1,
                    Name = "Piadina",
                    Price = 1,
                    Sku = new Guid(),
                    Ingredients = new List<Piadina.Ingredient>()
                    {
                        new Piadina.Ingredient()
                        {
                            Id = 1,
                            Name = "Ingridient1",
                            Price = 1,
                        },
                        new Piadina.Ingredient()
                        {
                            Id = 2,
                            Name = "Ingridient2",
                            Price = 1,
                        }
                    },
                    Shape = Piadina.Shapes.Shape1
                },
                new Snack()
                {
                    Id = 2,
                    Name = "Snack",
                    Price = 1,
                    Sku = new Guid(),
                },
                new Drink()
                {
                    Id = 3,
                    Name = "Drink",
                    Price = 1,
                    Sku = new Guid(),
                }
            };
            }

            public IEnumerable<Product> GetProducts()
            {
                return _products;
            }

            bool IProductDataService.DeleteProduct(Product product)
            {
                return _products.Remove(product);
            }
        }
    }
