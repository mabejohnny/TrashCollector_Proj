using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class AddedDisplayNameToEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38501c8a-dd50-433e-8ea0-ce38539ffa5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ed92edf-66d4-4f86-8549-32ff0200b0f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90689338-3aac-4cc8-8f41-25cdb283caa7", "f799aff6-acaf-488d-b6b6-b0e35fa15307", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed6c4759-900c-4764-8967-e6eaa73d3594", "10a6d143-9008-4b1d-9dbf-39e9209c1890", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90689338-3aac-4cc8-8f41-25cdb283caa7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed6c4759-900c-4764-8967-e6eaa73d3594");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ed92edf-66d4-4f86-8549-32ff0200b0f5", "4eaccb5c-e6ea-412b-91a2-c84f6f802158", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "38501c8a-dd50-433e-8ea0-ce38539ffa5b", "a2a6eaf9-839d-4c2d-b5e3-68089ee4681d", "Employee", "EMPLOYEE" });
        }
    }
}
