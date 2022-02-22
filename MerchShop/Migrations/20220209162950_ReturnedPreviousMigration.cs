using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class ReturnedPreviousMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "PreviewImage",
                table: "GenericItem",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 11, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 12, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 11, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 12, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 10, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 12, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 10, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 13, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 9, 17, 29, 49, 824, DateTimeKind.Local).AddTicks(6143));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PreviewImage",
                table: "GenericItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 11, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 12, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 11, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 12, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 10, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 12, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 10, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 13, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 9, 17, 26, 10, 585, DateTimeKind.Local).AddTicks(5959));
        }
    }
}
