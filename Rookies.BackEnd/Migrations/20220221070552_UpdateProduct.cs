using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookies.BackEnd.Migrations
{
    public partial class UpdateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name", "ProductId", "Type" },
                values: new object[,]
                {
                    { 1, "Test Category 1", null, 1 },
                    { 2, "Test Category 2", null, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2022, 2, 21, 14, 5, 52, 370, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2022, 2, 21, 14, 5, 52, 371, DateTimeKind.Local).AddTicks(4119) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2022, 2, 21, 13, 16, 10, 623, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 0, new DateTime(2022, 2, 21, 13, 16, 10, 624, DateTimeKind.Local).AddTicks(1365) });
        }
    }
}
