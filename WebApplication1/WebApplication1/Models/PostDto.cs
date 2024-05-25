using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PostDto
    {
        [Required]
        public string OwnerName { get; set; } = "";

        [Required]
        public string OwnerContact { get; set; } = "";

        [Required]
        public string OwnerLocation { get; set; } = "";

        [Required]
        public string CarName { get; set; } = "";

        [Required]
        public string CarBrand { get; set; } = "";

        [Required]
        public string CarYear { get; set; } = "";

        [Required]
        public string Mileage { get; set; } = "";

        [Required]
        public string CarType { get; set; } = "";

        [Required]
        public string HorsePower { get; set; } = "";

        [Required]
        public string FuelType { get; set; } = "";

        [Required]
        public string Price { get; set; } = "";

        [Required]
        public string SellType { get; set; } = "";

        public IFormFile? ImageFile { get; set; }

    }
}
