using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class data_seeding_V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics");

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.InsertData(
                table: "ItemStatistics",
                columns: new[] { "Id", "BoughtOnSale", "BoughtTime", "BuyersCountry", "GenericItemId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2022, 2, 8, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4684), "PL", 1 },
                    { 2, false, new DateTime(2022, 2, 9, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4739), "PL", 1 },
                    { 4, false, new DateTime(2022, 2, 7, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4746), "PL", 2 },
                    { 6, false, new DateTime(2022, 2, 8, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4752), "PL", 3 },
                    { 7, false, new DateTime(2022, 2, 9, 14, 11, 23, 322, DateTimeKind.Local).AddTicks(4756), "PL", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics",
                column: "GenericItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics");

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 0, 15, 287, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 8, 14, 0, 15, 287, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8,
                column: "BoughtTime",
                value: new DateTime(2022, 2, 10, 14, 0, 15, 287, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics",
                column: "GenericItemId",
                unique: true);
        }
    }
}
