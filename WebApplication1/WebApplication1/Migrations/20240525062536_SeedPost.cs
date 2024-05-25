using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e121029-ae47-4558-9d03-2f81fc5019d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a71588bc-d26c-42aa-b907-117cf60fce58");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e8d7ca6-ad20-47ee-953f-b1b68f27ff56", null, "client", "client" },
                    { "47ef74a3-12a1-46be-92e2-101e65633f9f", null, "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CarBrand", "CarName", "CarType", "CarYear", "CreatedAt", "FuelType", "HorsePower", "ImageFileName", "Mileage", "OwnerContact", "OwnerLocation", "OwnerName", "Price", "SellType" },
                values: new object[,]
                {
                    { 1, "BMW", "Territory", "Automatic", "2000", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9621), "", "700", "images/car-1.jpg", "4000", "kyle@gmail.com", "Cebu", "Kyle", "40000", "Rent" },
                    { 2, "BMW", "Territory", "Automatic", "2000", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9639), "", "700", "images/car-1.jpg", "4000", "alba@gmail.com", "Cebu", "Alba", "40000", "Rent" },
                    { 3, "Honda", "Civic", "Manual", "2018", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9642), "", "158", "images/car-1.jpg", "30000", "john@gmail.com", "Manila", "John", "20000", "Sale" },
                    { 4, "Toyota", "Camry", "Automatic", "2017", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9644), "", "203", "images/car-1.jpg", "35000", "jane@gmail.com", "Davao", "Jane", "22000", "Sale" },
                    { 5, "Honda", "Accord", "Automatic", "2016", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9646), "", "190", "images/car-1.jpg", "40000", "michael@gmail.com", "Quezon City", "Michael", "18000", "Sale" },
                    { 6, "Tesla", "Model S", "Automatic", "2020", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9647), "", "670", "images/car-1.jpg", "15000", "laura@gmail.com", "Taguig", "Laura", "80000", "Sale" },
                    { 7, "Ford", "Mustang", "Manual", "2019", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9650), "", "450", "images/car-1.jpg", "20000", "peter@gmail.com", "Makati", "Peter", "35000", "Sale" },
                    { 8, "Tesla", "Model 3", "Automatic", "2021", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9651), "", "283", "images/car-1.jpg", "10000", "emma@gmail.com", "Pasig", "Emma", "55000", "Sale" },
                    { 9, "Ford", "Ranger", "Manual", "2018", new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9653), "", "300", "images/car-1.jpg", "25000", "lucas@gmail.com", "Cebu", "Lucas", "29000", "Sale" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e8d7ca6-ad20-47ee-953f-b1b68f27ff56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47ef74a3-12a1-46be-92e2-101e65633f9f");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e121029-ae47-4558-9d03-2f81fc5019d9", null, "client", "client" },
                    { "a71588bc-d26c-42aa-b907-117cf60fce58", null, "admin", "admin" }
                });
        }
    }
}
