using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PickUps_Customers_customerId",
                table: "PickUps");

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
                name: "Id",
                table: "PickUps");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "PickUps",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_PickUps_customerId",
                table: "PickUps",
                newName: "IX_PickUps_CustomerId");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "PickUps",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Confirmation",
                table: "Employees",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PickUps_Customers_CustomerId",
                table: "PickUps",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PickUps_Customers_CustomerId",
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
                name: "Confirmation",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "PickUps",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_PickUps_CustomerId",
                table: "PickUps",
                newName: "IX_PickUps_customerId");

            migrationBuilder.AlterColumn<int>(
                name: "customerId",
                table: "PickUps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PickUps",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PickUps_Customers_customerId",
                table: "PickUps",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
