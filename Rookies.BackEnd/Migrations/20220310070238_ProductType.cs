using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rookies.BackEnd.Migrations
{
    public partial class ProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(3232), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8841), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8856), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8858), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8859), 1 });

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
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8862), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8863), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8864), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8866), 1 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Type" },
                values: new object[] { new DateTime(2022, 3, 10, 14, 2, 38, 189, DateTimeKind.Local).AddTicks(8868), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Product");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 630, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 16, 1, 11, 631, DateTimeKind.Local).AddTicks(451));
        }
    }
}
