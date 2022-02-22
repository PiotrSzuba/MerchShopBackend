using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class Byte_to_string : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2022, 2, 8, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 7, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 8, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 10, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 8, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 11, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 7, 14, 39, 7, 606, DateTimeKind.Local).AddTicks(454));
        }
    }
}
