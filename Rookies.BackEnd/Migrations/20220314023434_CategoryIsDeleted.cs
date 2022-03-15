using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookies.BackEnd.Migrations
{
    public partial class CategoryIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8868));
        }
    }
}
