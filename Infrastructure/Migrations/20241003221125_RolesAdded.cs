using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b81e93a0-4fef-42f2-8046-044fd4281b23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd60995d-1160-4c46-92b3-8d2913b0a153");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "084ee737-28a1-49fb-b65c-84582b7b5fae", null, "Customer", "CUSTOMER" },
                    { "46a53a0e-87a7-4dc4-b40f-b4a499755f8c", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "084ee737-28a1-49fb-b65c-84582b7b5fae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46a53a0e-87a7-4dc4-b40f-b4a499755f8c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b81e93a0-4fef-42f2-8046-044fd4281b23", null, "Customer", "CUSTOMER" },
                    { "bd60995d-1160-4c46-92b3-8d2913b0a153", null, "Admin", "ADMIN" }
                });
        }
    }
}
