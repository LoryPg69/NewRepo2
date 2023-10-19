using LaPiadineriaApi.Models;

namespace LaPiadineria.Models
{
    public class DrinkModel
    {
        public int Id { get; set; }    
        public double Price { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Type { get; set; }
        public string? Sku { get; set;}

        public int ItemPiadaModel
        {

            get
            {
                return Items.Count;
            }

        }

        public ICollection<ItemPiadaModel> Items { get; set; } = new List<ItemPiadaModel>();
    }
}
