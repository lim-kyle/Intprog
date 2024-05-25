using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedFour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2910d9ca-48b2-4e46-838b-dccd735cfe6f", null, "client", "client" },
                    { "7016283c-6c32-44b8-a219-5500eae3e42e", null, "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "609eb6a3-07ae-4c95-9d41-2bb0e7798a45", 0, "", "ee7aa8be-00fb-4a1a-9403-fd5902f78733", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "client@gmail.com", true, "", "", false, null, "CLIENT@GMAIL.COM", "CLIENT@GMAIL.COM", "AQAAAAIAAYagAAAAELcsWs9YpxxRAJcd+fF6hbPM2+njdwMTT//KwFqFd/sAh4GDjyY4ysm5lN3/kXwdIg==", null, false, "0567dbc7-0376-4394-ae82-04ecefb3b749", false, "client@gmail.com" },
                    { "9a10b1ca-3ce7-4a70-bcac-716813f78c34", 0, "", "16050bf1-1f35-482a-a722-e91c263b86c9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "", "", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEN4eOBDBPoSvHrA2of+0h1vjEGE1Nfum0QjWQbs0dkNF+WCQey47FKC0JGs3QP2ABA==", null, false, "ff13bb0a-d7ec-418f-96cc-e5d76c8107fb", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarType", "CreatedAt" },
                values: new object[] { "Manual", new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 15, 7, 27, 659, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2910d9ca-48b2-4e46-838b-dccd735cfe6f", "609eb6a3-07ae-4c95-9d41-2bb0e7798a45" },
                    { "7016283c-6c32-44b8-a219-5500eae3e42e", "9a10b1ca-3ce7-4a70-bcac-716813f78c34" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2910d9ca-48b2-4e46-838b-dccd735cfe6f", "609eb6a3-07ae-4c95-9d41-2bb0e7798a45" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7016283c-6c32-44b8-a219-5500eae3e42e", "9a10b1ca-3ce7-4a70-bcac-716813f78c34" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2910d9ca-48b2-4e46-838b-dccd735cfe6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7016283c-6c32-44b8-a219-5500eae3e42e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "609eb6a3-07ae-4c95-9d41-2bb0e7798a45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a10b1ca-3ce7-4a70-bcac-716813f78c34");

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
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarType", "CreatedAt" },
                values: new object[] { "Automatic", new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 25, 14, 38, 17, 824, DateTimeKind.Local).AddTicks(9749));
        }
    }
}
