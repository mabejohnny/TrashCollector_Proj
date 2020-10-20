using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11043b17-f0c6-4558-b7a5-dc013e277c26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d9872f4-712b-4a7e-884d-0d37c935ca59");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a24ec949-049b-4acd-8116-be43cea0f5c0", "1c69ee6f-b213-4293-9266-c47846ff53f8", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "343b169b-fceb-494b-961b-752d02091558", "b28e5c63-8689-4092-89b2-e29cc80f566c", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "343b169b-fceb-494b-961b-752d02091558");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a24ec949-049b-4acd-8116-be43cea0f5c0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d9872f4-712b-4a7e-884d-0d37c935ca59", "a0d1cea9-9b1c-4893-9767-7bfadd835871", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11043b17-f0c6-4558-b7a5-dc013e277c26", "a89661e7-0c30-44b8-aa99-7d3d40c2505f", "Employee", "EMPLOYEE" });
        }
    }
}
