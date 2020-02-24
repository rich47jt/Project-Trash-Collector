using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "684041a7-8f70-4cab-81a6-c332c9e2d291");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71a97536-2070-4067-afd2-13ad624871d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95fdbfd2-019d-4123-9bd1-739fb67eddc7");

            migrationBuilder.DropColumn(
                name: "End",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Suspend",
                table: "Customers");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "PickUps",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "PickUps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsPickUp",
                table: "PickUps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "PickUps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Suspend",
                table: "PickUps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62be17ce-4274-468e-a725-3004ff9b05df", "02be05a8-f16b-46d8-9252-591ac78a10d1", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4864967d-2db3-414d-8c38-9663b9a2460e", "b5908105-5f3b-48a2-88b0-a9395c926766", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87cac559-13c8-4ff8-9397-ba5b15c95c1f", "96df2128-338b-4426-a416-00257b0fdb3d", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4864967d-2db3-414d-8c38-9663b9a2460e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62be17ce-4274-468e-a725-3004ff9b05df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87cac559-13c8-4ff8-9397-ba5b15c95c1f");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "IsPickUp",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "Suspend",
                table: "PickUps");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "PickUps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "PickUps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "Suspend",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "684041a7-8f70-4cab-81a6-c332c9e2d291", "baf0e578-ea10-4d1f-abc4-219e725f58c6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "71a97536-2070-4067-afd2-13ad624871d5", "6d64af56-1337-4920-bd50-e222860f393b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95fdbfd2-019d-4123-9bd1-739fb67eddc7", "e6650f8b-092d-43c4-a8ad-c4fe04a9b8f2", "Employee", "EMPLOYEE" });
        }
    }
}
