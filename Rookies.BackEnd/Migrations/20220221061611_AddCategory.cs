using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookies.BackEnd.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 13, 16, 10, 623, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 13, 16, 10, 624, DateTimeKind.Local).AddTicks(1365));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 26, 28, 548, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 26, 28, 549, DateTimeKind.Local).AddTicks(1059));
        }
    }
}
