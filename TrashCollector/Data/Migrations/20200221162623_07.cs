using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "292c7c45-1e3c-4c3f-88c0-00e9be1f44ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0e86613-8435-47a6-91fe-a53fef4d72fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d201ecd6-682a-4505-8715-2b6326409fe6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b14c4321-1083-435e-8931-123c409569a4", "6e75b788-c07a-4f0c-be01-0768028535a9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "933502dd-200d-475b-91e9-05112eeb2795", "8a48eade-a321-44e0-9346-d60b9f66e408", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2f263cb9-2a41-45c6-9866-b1f8eee9518b", "db6bd20b-ef96-49e3-8d7e-5fecca31f033", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f263cb9-2a41-45c6-9866-b1f8eee9518b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "933502dd-200d-475b-91e9-05112eeb2795");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b14c4321-1083-435e-8931-123c409569a4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "292c7c45-1e3c-4c3f-88c0-00e9be1f44ce", "13bfb775-8382-48b5-bfcd-817259e77c52", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0e86613-8435-47a6-91fe-a53fef4d72fd", "b5e8664d-6dde-4131-857c-dfec551406af", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d201ecd6-682a-4505-8715-2b6326409fe6", "969c3de5-9449-450e-a23c-6fa2f19f4e89", "Employee", "EMPLOYEE" });
        }
    }
}
