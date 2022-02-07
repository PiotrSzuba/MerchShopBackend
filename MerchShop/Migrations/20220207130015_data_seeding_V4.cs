using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class data_seeding_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ItemStatistics",
                columns: new[] { "Id", "BoughtOnSale", "BoughtTime", "BuyersCountry", "GenericItemId" },
                values: new object[] { 3, true, new DateTime(2022, 2, 10, 14, 0, 15, 287, DateTimeKind.Local).AddTicks(7863), "PL", 1 });

            migrationBuilder.InsertData(
                table: "ItemStatistics",
                columns: new[] { "Id", "BoughtOnSale", "BoughtTime", "BuyersCountry", "GenericItemId" },
                values: new object[] { 5, false, new DateTime(2022, 2, 8, 14, 0, 15, 287, DateTimeKind.Local).AddTicks(7869), "PL", 2 });

            migrationBuilder.InsertData(
                table: "ItemStatistics",
                columns: new[] { "Id", "BoughtOnSale", "BoughtTime", "BuyersCountry", "GenericItemId" },
                values: new object[] { 8, true, new DateTime(2022, 2, 10, 14, 0, 15, 287, DateTimeKind.Local).AddTicks(7878), "PL", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
