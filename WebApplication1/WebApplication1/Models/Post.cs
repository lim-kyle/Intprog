namespace WebApplication1.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string OwnerName { get; set; } = "";

        public string OwnerContact { get; set; } = "";

        public string OwnerLocation { get; set; } = "";

        public string CarName { get; set; } = "";

        public string CarBrand { get; set; } = "";

        public string CarYear { get; set; } = "";

        public string Mileage { get; set; } = "";

        public string CarType { get; set; } = "";

        public string HorsePower { get; set; } = "";

        public string FuelType { get; set; } = "";

        public string Price { get; set; } = "";

        public string SellType { get; set; } = "";

        public string ImageFileName { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}
