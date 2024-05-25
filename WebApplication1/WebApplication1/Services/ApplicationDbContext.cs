using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var client = new IdentityRole("client");
            client.NormalizedName = "client";

            builder.Entity<IdentityRole>().HasData(admin, client);

            // =====================================================

            // Seed admin client/user
            var adminUserId = Guid.NewGuid().ToString();
            var adminUser = new ApplicationUser
            {
                Id = adminUserId,
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var clientUserId = Guid.NewGuid().ToString();
            var clientUser = new ApplicationUser
            {
                Id = clientUserId,
                UserName = "client@gmail.com",
                NormalizedUserName = "CLIENT@GMAIL.COM",
                Email = "client@gmail.com",
                NormalizedEmail = "CLIENT@GMAIL.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };

            var passwordHasher = new PasswordHasher<ApplicationUser>();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin@123");
            clientUser.PasswordHash = passwordHasher.HashPassword(clientUser, "Client@123");

            builder.Entity<ApplicationUser>().HasData(adminUser, clientUser);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = admin.Id,
                    UserId = adminUserId
                },
                new IdentityUserRole<string>
                {
                    RoleId = client.Id,
                    UserId = clientUserId
                }
            );

            // ==== Seed for Post ====

            builder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    OwnerName = "Kyle",
                    OwnerContact = "kyle@gmail.com",
                    OwnerLocation = "Cebu",
                    CarName = "Territory",
                    CarBrand = "BMW",
                    CarYear = "2000",
                    Mileage = "4000",
                    CarType = "Automatic",
                    HorsePower = "700",
                    Price = "40000",
                    SellType = "Rent",
                    ImageFileName = "car-1.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 2,
                    OwnerName = "Alba",
                    OwnerContact = "alba@gmail.com",
                    OwnerLocation = "Cebu",
                    CarName = "Territory",
                    CarBrand = "BMW",
                    CarYear = "2000",
                    Mileage = "4000",
                    CarType = "Automatic",
                    HorsePower = "700",
                    Price = "40000",
                    SellType = "Rent",
                    ImageFileName = "car-2.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 3,
                    OwnerName = "John",
                    OwnerContact = "john@gmail.com",
                    OwnerLocation = "Manila",
                    CarName = "Civic",
                    CarBrand = "Honda",
                    CarYear = "2018",
                    Mileage = "30000",
                    CarType = "Manual",
                    HorsePower = "158",
                    Price = "20000",
                    SellType = "Sale",
                    ImageFileName = "car-3.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 4,
                    OwnerName = "Jane",
                    OwnerContact = "jane@gmail.com",
                    OwnerLocation = "Davao",
                    CarName = "Camry",
                    CarBrand = "Toyota",
                    CarYear = "2017",
                    Mileage = "35000",
                    CarType = "Automatic",
                    HorsePower = "203",
                    Price = "22000",
                    SellType = "Sale",
                    ImageFileName = "car-4.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 5,
                    OwnerName = "Michael",
                    OwnerContact = "michael@gmail.com",
                    OwnerLocation = "Quezon City",
                    CarName = "Accord",
                    CarBrand = "Honda",
                    CarYear = "2016",
                    Mileage = "40000",
                    CarType = "Automatic",
                    HorsePower = "190",
                    Price = "18000",
                    SellType = "Sale",
                    ImageFileName = "car-5.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 6,
                    OwnerName = "Laura",
                    OwnerContact = "laura@gmail.com",
                    OwnerLocation = "Taguig",
                    CarName = "Model S",
                    CarBrand = "Tesla",
                    CarYear = "2020",
                    Mileage = "15000",
                    CarType = "Automatic",
                    HorsePower = "670",
                    Price = "80000",
                    SellType = "Sale",
                    ImageFileName = "car-6.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 7,
                    OwnerName = "Peter",
                    OwnerContact = "peter@gmail.com",
                    OwnerLocation = "Makati",
                    CarName = "Mustang",
                    CarBrand = "Ford",
                    CarYear = "2019",
                    Mileage = "20000",
                    CarType = "Manual",
                    HorsePower = "450",
                    Price = "35000",
                    SellType = "Sale",
                    ImageFileName = "car-7.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 8,
                    OwnerName = "Emma",
                    OwnerContact = "emma@gmail.com",
                    OwnerLocation = "Pasig",
                    CarName = "Model 3",
                    CarBrand = "Tesla",
                    CarYear = "2021",
                    Mileage = "10000",
                    CarType = "Manual",
                    HorsePower = "283",
                    Price = "55000",
                    SellType = "Sale",
                    ImageFileName = "car-1.jpg",
                    CreatedAt = DateTime.Now
                },
                new Post
                {
                    Id = 9,
                    OwnerName = "Lucas",
                    OwnerContact = "lucas@gmail.com",
                    OwnerLocation = "Cebu",
                    CarName = "Ranger",
                    CarBrand = "Ford",
                    CarYear = "2018",
                    Mileage = "25000",
                    CarType = "Manual",
                    HorsePower = "300",
                    Price = "29000",
                    SellType = "Sale",
                    ImageFileName = "car-3.jpg",
                    CreatedAt = DateTime.Now
                }
            );
        }

    }
}
