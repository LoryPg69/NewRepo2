using System.ComponentModel.DataAnnotations;

namespace PrimoController.DTO
{
    public class ShipperDto
    {
        [Required]
        [StringLength(24,ErrorMessage = "phone sbsbs")]
        public string Phone { get; set;}
        [EmailAddress]
        public string Email { get; set;}
    }
}
