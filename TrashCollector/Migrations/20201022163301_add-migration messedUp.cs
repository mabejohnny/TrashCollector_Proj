using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class addmigrationmessedUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "58c7fc5b-fae8-41c1-97bc-aabf92a0eebb", "befcefe1-3f63-46d6-8641-88ec0cd7a843", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3a28206-cac2-46f9-a4f3-84cf4585c01e", "72d863d0-4b3f-40d5-a5e7-1655c04a587c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58c7fc5b-fae8-41c1-97bc-aabf92a0eebb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3a28206-cac2-46f9-a4f3-84cf4585c01e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "90689338-3aac-4cc8-8f41-25cdb283caa7", "f799aff6-acaf-488d-b6b6-b0e35fa15307", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed6c4759-900c-4764-8967-e6eaa73d3594", "10a6d143-9008-4b1d-9dbf-39e9209c1890", "Employee", "EMPLOYEE" });
        }
    }
}
