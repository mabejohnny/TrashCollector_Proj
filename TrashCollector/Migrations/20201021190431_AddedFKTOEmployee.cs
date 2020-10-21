using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedFKTOEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "078b5d08-cb2f-4e2a-9184-4700757b22ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2133c909-9386-43f3-90a1-4d60d0ecd4aa");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Employees",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ed92edf-66d4-4f86-8549-32ff0200b0f5", "4eaccb5c-e6ea-412b-91a2-c84f6f802158", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38501c8a-dd50-433e-8ea0-ce38539ffa5b", "a2a6eaf9-839d-4c2d-b5e3-68089ee4681d", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38501c8a-dd50-433e-8ea0-ce38539ffa5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ed92edf-66d4-4f86-8549-32ff0200b0f5");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2133c909-9386-43f3-90a1-4d60d0ecd4aa", "8ca41001-bee5-4013-b3d2-f7d5618c2994", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "078b5d08-cb2f-4e2a-9184-4700757b22ee", "34d80c07-b6b4-4af4-b377-658f028ce5ac", "Employee", "EMPLOYEE" });
        }
    }
}
