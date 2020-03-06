using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fbe46bc-3381-4673-a185-e6201a9db0d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d0a7083-e09d-41ab-aa2f-fdd8324c7593");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b016dbb9-6b44-45c4-bddc-f98f1c6e90b1");

            migrationBuilder.DropColumn(
                name: "PickUpId",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "IsPickUp",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "PickUps");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PickUps",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartTime",
                table: "PickUps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d42af6ee-42af-4118-b992-315f6896929e", "7cbc3b82-695b-4e3b-8754-da7a78fff929", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c107df7a-f077-4fd0-beb2-5640ed44bcd3", "f378837d-84bc-4689-a6e3-683e29b012e6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c0bbfea-d5a7-48d2-999a-ac609f2da638", "19516d40-9756-4795-91f3-5653655cddf5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c0bbfea-d5a7-48d2-999a-ac609f2da638");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c107df7a-f077-4fd0-beb2-5640ed44bcd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d42af6ee-42af-4118-b992-315f6896929e");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "PickUps");

            migrationBuilder.AddColumn<int>(
                name: "PickUpId",
                table: "PickUps",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsPickUp",
                table: "PickUps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "PickUps",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps",
                column: "PickUpId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b016dbb9-6b44-45c4-bddc-f98f1c6e90b1", "6fd991ec-40a3-4a62-8bd6-87dad1599399", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0fbe46bc-3381-4673-a185-e6201a9db0d1", "971d7bc7-c781-408b-9df6-222da46efb2b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d0a7083-e09d-41ab-aa2f-fdd8324c7593", "1d50bdcb-0724-44b8-b2cf-bedca0ee1115", "Employee", "EMPLOYEE" });
        }
    }
}
