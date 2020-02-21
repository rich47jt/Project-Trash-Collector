using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class _06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16b9d80c-1665-41f4-a127-5a099f550695");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca872d24-223f-44b6-b6aa-16bba5b86410");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4c19b82-c5f3-4e88-b0f6-da872de66f7f");

            migrationBuilder.DropColumn(
                name: "IsPickUp",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "PickUpDay",
                table: "PickUps",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "PickUpId",
                table: "PickUps",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PickUps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "customerId",
                table: "PickUps",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps",
                column: "PickUpId");

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

            migrationBuilder.CreateIndex(
                name: "IX_PickUps_customerId",
                table: "PickUps",
                column: "customerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AccountId",
                table: "Customers",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PickUps_Customers_customerId",
                table: "PickUps",
                column: "customerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_PickUps_Customers_customerId",
                table: "PickUps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps");

            migrationBuilder.DropIndex(
                name: "IX_PickUps_customerId",
                table: "PickUps");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AccountId",
                table: "Customers");

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

            migrationBuilder.DropColumn(
                name: "PickUpId",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "customerId",
                table: "PickUps");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "PickUpDay",
                table: "PickUps",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPickUp",
                table: "PickUps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Customers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PickUps",
                table: "PickUps",
                column: "PickUpDay");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16b9d80c-1665-41f4-a127-5a099f550695", "71a77e9e-72b8-4bf6-b8ea-7efdb8eae0ba", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4c19b82-c5f3-4e88-b0f6-da872de66f7f", "e7d751ed-850a-4dfc-9960-352f875dbc88", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca872d24-223f-44b6-b6aa-16bba5b86410", "181eb09e-0769-4797-96c0-d8f022f1f177", "Employee", "EMPLOYEE" });
        }
    }
}
