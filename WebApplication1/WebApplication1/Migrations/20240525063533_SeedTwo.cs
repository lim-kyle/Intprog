using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e8d7ca6-ad20-47ee-953f-b1b68f27ff56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47ef74a3-12a1-46be-92e2-101e65633f9f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61c46846-5c80-402b-af5f-76bef6a6ecb8", null, "client", "client" },
                    { "9a9b6e8e-f740-4bef-b061-579e3be73b55", null, "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8167), "car-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8182), "images/car-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8184), "images/car-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8186), "images/car-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8188), "images/car-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8190), "images/car-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8192), "images/car-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8194), "images/car-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8196), "images/car-8.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61c46846-5c80-402b-af5f-76bef6a6ecb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a9b6e8e-f740-4bef-b061-579e3be73b55");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e8d7ca6-ad20-47ee-953f-b1b68f27ff56", null, "client", "client" },
                    { "47ef74a3-12a1-46be-92e2-101e65633f9f", null, "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9621), "img/cars/car-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9639), "img/cars/car-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9642), "img/cars/car-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9644), "img/cars/car-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9646), "img/cars/car-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9647), "img/cars/car-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9650), "img/cars/car-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9651), "img/cars/car-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 25, 36, 144, DateTimeKind.Local).AddTicks(9653), "img/cars/car-2.jpg" });
        }
    }
}
