using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class data_seeding_OrderItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "OrderedItem",
                columns: new[] { "Id", "GenericItemId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 1, 2 },
                    { 5, 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 7, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 10, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 11, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDateTime",
                value: new DateTime(2022, 2, 7, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8218));
        }
    }
}
