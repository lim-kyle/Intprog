using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing.Text;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class CarsCreateModel : PageModel
    {
        private readonly IWebHostEnvironment environment;
        private readonly ApplicationDbContext context;

        [BindProperty]
        public PostDto PostDto { get; set; } = new PostDto();

        public CarsCreateModel(IWebHostEnvironment environment, ApplicationDbContext context)
        {
            this.environment = environment;
            this.context = context;
        }

        public void OnGet()
        {
        
        }

        public string errorMessage = "";
        public string successMessage = "";

        public void OnPost()
        {
            if (PostDto.ImageFile == null)
                {
                    ModelState.AddModelError("PostDto.ImageFile", "The Image file is required");
                }

            if (!ModelState.IsValid)
            {
                errorMessage = "Please provide all he required fields";
                return;
            }

            // save the image file
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            newFileName += Path.GetExtension(PostDto.ImageFile!.FileName);

            string imageFullPath = environment.WebRootPath + "/images/" + newFileName;
            using (var stream = System.IO.File.Create(imageFullPath))
            {
                PostDto.ImageFile.CopyTo(stream);
            }

            //save the post in the database
            Post post = new Post()
            {
                OwnerName = PostDto.OwnerName,
                OwnerContact = PostDto.OwnerContact,
                OwnerLocation = PostDto.OwnerLocation,
                CarName = PostDto.CarName,
                CarBrand = PostDto.CarBrand,
                CarYear = PostDto.CarYear,
                Mileage = PostDto.Mileage,
                CarType = PostDto.CarType,
                HorsePower = PostDto.HorsePower,
                FuelType = PostDto.FuelType,
                Price = PostDto.Price,
                SellType = PostDto.SellType,
                ImageFileName = newFileName,
                CreatedAt = DateTime.Now,
            };

            context.Posts.Add(post);
            context.SaveChanges();

            // clear the form
            PostDto.OwnerName = "";
            PostDto.OwnerContact = "";
            PostDto.OwnerLocation = "";
            PostDto.CarName = "";
            PostDto.CarBrand = "";
            PostDto.CarYear = "";
            PostDto.Mileage = "";
            PostDto.CarType = "";
            PostDto.HorsePower = "";
            PostDto.FuelType = "";
            PostDto.Price = "";
            PostDto.SellType = "";
            PostDto.ImageFile = null;

            ModelState.Clear();

            successMessage = "Post created successfully";

            Response.Redirect("/Cars");





        }
    }
}
