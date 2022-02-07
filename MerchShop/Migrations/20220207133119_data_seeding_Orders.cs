using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class data_seeding_Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order");

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

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "OrderDateTime", "OrderStatus", "ShippingAddressId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8042), 4, 1, 1 },
                    { 2, new DateTime(2022, 2, 10, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8205), 3, 1, 1 },
                    { 3, new DateTime(2022, 2, 8, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8212), 4, 2, 2 },
                    { 4, new DateTime(2022, 2, 11, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8215), 2, 3, 3 },
                    { 5, new DateTime(2022, 2, 7, 14, 31, 18, 583, DateTimeKind.Local).AddTicks(8218), 1, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order");

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 7, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 9, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShippingAddressId",
                table: "Order",
                column: "ShippingAddressId",
                unique: true);
        }
    }
}
