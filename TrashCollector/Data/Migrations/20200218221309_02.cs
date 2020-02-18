using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "End",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Customers");

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
    }
}
