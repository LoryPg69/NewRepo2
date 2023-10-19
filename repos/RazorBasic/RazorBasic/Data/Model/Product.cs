using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorBasic.NewFolder.NewFolder
{
    public class Product
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public string Description { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string? ImageFule {  get; set; }

        [Required]
        public DateTime? CreatedDate { get; set; }

        [Required]
        public string Category { get; set; }

        [NotMapped]
        public IFormFile Upload {  get; set; }  
    }
}
