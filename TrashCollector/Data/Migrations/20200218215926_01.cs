using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7495f9c-8357-4650-b79f-3035b27bce17");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32bcfc45-8e74-4dd6-8b3b-85699c97ae87", "39a3cd25-aed7-4715-b32a-984337e2201a", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bd295f4-58b7-457e-b0ec-4c8369bbd713", "07b6af9e-1ada-4113-84f5-e8802ddcfdb8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c79e1fc6-5db6-4398-8434-d6452d84db49", "35160cc9-0906-4003-90fb-8d412d3ff541", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32bcfc45-8e74-4dd6-8b3b-85699c97ae87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bd295f4-58b7-457e-b0ec-4c8369bbd713");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c79e1fc6-5db6-4398-8434-d6452d84db49");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7495f9c-8357-4650-b79f-3035b27bce17", "2a972503-cd43-4c2e-9361-c7b8be48d777", "Admin", "ADMIN" });
        }
    }
}
