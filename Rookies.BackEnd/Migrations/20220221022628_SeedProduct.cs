using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookies.BackEnd.Migrations
{
    public partial class SeedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 2, 21, 9, 26, 28, 548, DateTimeKind.Local).AddTicks(3781), 10000 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Name", "Price", "UpdatedDate" },
                values: new object[] { 2, 0, new DateTime(2022, 2, 21, 9, 26, 28, 549, DateTimeKind.Local).AddTicks(1059), "2021 Product", "Test Product 2", 20000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2022, 2, 21, 9, 22, 47, 23, DateTimeKind.Local).AddTicks(6918), 0 });
        }
    }
}
