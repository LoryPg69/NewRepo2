using laPiadineria.Dtos;
using laPiadineria.Models;

namespace laPiadineria.Services.ProductDataService
{
    public class LocalProductDataService : IProductDataService
    {

        List<Product> _products;

        public LocalProductDataService()
        {
            _products = new List<Product>()
            {
                new Piadina()
                {
                    Id = 1,
                    Name = "La Superiore",
                    Price = 5.00,
                    Sku = new Guid(),
                    Ingredients = new List<Piadina.Ingredient>()
                    {
                        new Piadina.Ingredient()
                        {
                            Id = 1,
                            Name = "Culatta",

                        },
                        new Piadina.Ingredient()
                        {
                            Id = 2,
                            Name = "Pomodoro",

                        }
                    },
                    Shape = Piadina.Shapes.Shape1
                },

                 new Piadina()
                {
                    Id = 2,
                    Name = "La Malga",
                    Price = 6.00,
                    Sku = new Guid(),
                    Ingredients = new List<Piadina.Ingredient>()
                    {
                        new Piadina.Ingredient()
                        {
                            Id = 1,
                            Name = "Funghi",

                        },
                        new Piadina.Ingredient()
                        {
                            Id = 2,
                            Name = "Rucola",

                        }
                    },
                    Shape = Piadina.Shapes.Shape1
                },

                new Snack()
                {
                    Id = 2,
                    Name = "Patatine",
                    Price = 2.00,
                    Sku = new Guid(),
                },
                new Drink()
                {
                    Id = 3,
                    Name = "Fanta",
                    Price = 4.00,
                    Sku = new Guid(),
                },

                new Snack()
                {
                    Id = 4,
                    Name = "Patatine",
                    Price = 1.00,
                    Sku = new Guid(),
                },
                new Drink()
                {
                    Id = 5,
                    Name = "Coca Cola",
                    Price = 2.00,
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
