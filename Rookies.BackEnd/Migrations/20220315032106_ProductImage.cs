using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookies.BackEnd.Migrations
{
    public partial class ProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 515, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 15, 10, 21, 6, 516, DateTimeKind.Local).AddTicks(3715));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 462, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 14, 9, 34, 34, 463, DateTimeKind.Local).AddTicks(2914));
        }
    }
}
