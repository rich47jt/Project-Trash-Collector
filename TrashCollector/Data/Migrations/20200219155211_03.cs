using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4223147c-cc94-4f04-abeb-6c02e78a5414");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88034a03-d20b-4126-8725-ff7e504d9bac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d882f9db-e2a9-4423-b4f6-6470b800132b");

            migrationBuilder.AlterColumn<double>(
                name: "Balance",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01c239c4-4425-4db9-84e1-f28bbcf2311b", "41ecd883-de06-4959-94c1-b3881d742694", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62d3cc5c-a700-47dd-8a7f-6f7cb1e37be5", "e8586ef4-b4d5-443f-b953-18040c07c547", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0536b2c8-3bcb-4e7e-8414-1b2fb48c5c3e", "5cbd93ec-5600-4018-9adf-684e8b8b33e8", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01c239c4-4425-4db9-84e1-f28bbcf2311b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0536b2c8-3bcb-4e7e-8414-1b2fb48c5c3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62d3cc5c-a700-47dd-8a7f-6f7cb1e37be5");

            migrationBuilder.AlterColumn<int>(
                name: "Balance",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4223147c-cc94-4f04-abeb-6c02e78a5414", "aef142ec-9f8a-4211-bfb0-4fde5b4d5588", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d882f9db-e2a9-4423-b4f6-6470b800132b", "df806105-7a03-44a2-a04d-c808acc121a2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88034a03-d20b-4126-8725-ff7e504d9bac", "7f885da6-eb56-45ab-a339-4d66dd315233", "Employee", "EMPLOYEE" });
        }
    }
}
