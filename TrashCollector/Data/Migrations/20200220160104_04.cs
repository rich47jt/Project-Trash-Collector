using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "End",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Pickup",
                table: "Customers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "721586da-1ef8-4974-8755-69c63ef58658", "77c0ce89-aea2-4706-9a1d-c4edf2b34020", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "321195ce-c2ad-4659-be53-ec8c663ecbdb", "0c6a58c9-0ffb-4290-a0d7-2b341c651ae8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ce007af-01dc-48a5-ba20-a8611d2366c1", "1115638a-e7f5-4190-96af-510109d9726d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "321195ce-c2ad-4659-be53-ec8c663ecbdb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ce007af-01dc-48a5-ba20-a8611d2366c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "721586da-1ef8-4974-8755-69c63ef58658");

            migrationBuilder.DropColumn(
                name: "Pickup",
                table: "Customers");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PickUpDay",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}
