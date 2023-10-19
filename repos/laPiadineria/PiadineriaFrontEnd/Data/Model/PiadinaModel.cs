using laPiadineria.Data.Model;

namespace laPiadineria.Dtos
{
    public class PiadinaModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public class Ingredient
        {
         public string Name { get; set; }
            
        }
        public string Shapes { get; set; }
   

        public List<Ingredient> Ingredients { get; set; }

    }
}
