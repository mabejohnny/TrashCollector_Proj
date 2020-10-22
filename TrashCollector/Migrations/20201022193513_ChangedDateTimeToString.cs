using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class ChangedDateTimeToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58c7fc5b-fae8-41c1-97bc-aabf92a0eebb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3a28206-cac2-46f9-a4f3-84cf4585c01e");

            migrationBuilder.AlterColumn<string>(
                name: "PickupDayChoice",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c7968b9-a795-481c-9e2d-17f8eb8d5bc8", "fb2d35a8-0e98-4020-91c1-318cdb53e008", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60e63fde-15bf-4022-b4f0-5f6f66ba66cb", "11a835e6-228d-4fa1-a5d9-9e52b6dd2f36", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c7968b9-a795-481c-9e2d-17f8eb8d5bc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60e63fde-15bf-4022-b4f0-5f6f66ba66cb");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PickupDayChoice",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58c7fc5b-fae8-41c1-97bc-aabf92a0eebb", "befcefe1-3f63-46d6-8641-88ec0cd7a843", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f3a28206-cac2-46f9-a4f3-84cf4585c01e", "72d863d0-4b3f-40d5-a5e7-1655c04a587c", "Employee", "EMPLOYEE" });
        }
    }
}
