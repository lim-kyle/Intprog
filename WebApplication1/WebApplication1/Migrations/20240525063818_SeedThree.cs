using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "456e0e09-43b9-4fee-8527-a05a5b846f2e", null, "client", "client" },
                    { "a7947312-1bdd-44d8-8feb-5f196e2bfccb", null, "admin", "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9697), "car-2.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9699), "car-3.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9701), "car-4.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9703), "car-5.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9743), "car-6.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9745), "car-7.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9747), "car-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ImageFileName" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9749), "car-3.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "456e0e09-43b9-4fee-8527-a05a5b846f2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7947312-1bdd-44d8-8feb-5f196e2bfccb");

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
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 35, 32, 608, DateTimeKind.Local).AddTicks(8167));

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
    }
}
