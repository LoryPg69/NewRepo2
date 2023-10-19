using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static LaPiadinereia.API.Models.Product;

namespace laPiadineriaAPI.DbContent.Entities
{
    public class PiadinaEntities
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public double Price { get; set; }

    public enum Shapes
    {
        Shape1,
        Shape2,
        Shape3,
        Shape4,
        Shape5,
    }

    public List<Ingredient> Ingredients { get; set; }
    public Shapes Shape { get; set; }
    public ICollection<Ingredient> ItemList{ get; set; } = new List<Ingredient>();

        public PiadinaEntities(string name)
        {
            Name = name;
        }
    }
}
