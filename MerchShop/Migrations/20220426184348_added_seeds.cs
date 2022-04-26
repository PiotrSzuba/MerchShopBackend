using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class added_seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GenericItem_ItemDetailsId",
                table: "GenericItem");

            migrationBuilder.InsertData(
                table: "ItemDetails",
                columns: new[] { "ItemDetailsId", "AdditionalInformation", "Category", "Designer", "Details", "Features", "Images", "MainDescription", "Sizes" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, "[\"XS\",\"S\",\"M\",\"L\",\"XL\"]" },
                    { 2, null, null, null, null, null, null, null, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\"]" },
                    { 3, null, null, null, null, null, null, null, "[\"XS\",\"S\",\"M\",\"L\",\"XL\",\"XXL\",\"XXXL\"]" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Email", "Name", "Password", "Role", "Surname", "UserName" },
                values: new object[,]
                {
                    { 1, "sakonir@gmail.com", "Piotr", "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5", "admin", "Szuba", "Admin" },
                    { 2, "sakonir2@gmail.com", "War", "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5", "regular", "Wick", "RegularUser1" },
                    { 3, "sakonir3@gmail.com", "Ur", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", "worker", "Got", "RegularWorker" }
                });

            migrationBuilder.InsertData(
                table: "GenericItem",
                columns: new[] { "GenericItemId", "DiscountValue", "IsInStock", "ItemDetailsId", "Name", "OnDiscount", "PreviewImage", "Price" },
                values: new object[,]
                {
                    { 1, 0, true, 1, "STD shirt", false, null, 79.99m },
                    { 2, 0, true, 2, "Better jeans", false, null, 150.99m },
                    { 3, 0, true, 2, "Basic hoodie", false, null, 240.99m }
                });

            migrationBuilder.InsertData(
                table: "ShippingAddress",
                columns: new[] { "ShippingAddressId", "ApartmentNumber", "City", "Country", "PostalCode", "Region", "StreetAddress", "UserId" },
                values: new object[,]
                {
                    { 1, "3", "Wrocław", "PL", "50-004", "Dolnośląskie", "Smocza 5", 1 },
                    { 2, "4", "Wrocław", "PL", "50-004", "Dolnośląskie", "Polna 1", 2 },
                    { 3, null, "Wrocław", "PL", "50-004", "Dolnośląskie", "Piękna 62", 3 }
                });

            migrationBuilder.InsertData(
                table: "ItemStatistics",
                columns: new[] { "ItemStatisticsId", "BoughtOnSale", "BoughtTime", "BuyersCountry", "GenericItemId" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2022, 4, 27, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(151), "PL", 1 },
                    { 2, false, new DateTime(2022, 4, 28, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(155), "PL", 1 },
                    { 3, true, new DateTime(2022, 4, 29, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(157), "PL", 1 },
                    { 4, false, new DateTime(2022, 4, 26, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(160), "PL", 2 },
                    { 5, false, new DateTime(2022, 4, 27, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(163), "PL", 2 },
                    { 6, false, new DateTime(2022, 4, 27, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(165), "PL", 3 },
                    { 7, false, new DateTime(2022, 4, 28, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(168), "PL", 3 },
                    { 8, true, new DateTime(2022, 4, 29, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(171), "PL", 3 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "OrderDateTime", "OrderStatus", "ShippingAddressId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 27, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(27), 4, 1, 1 },
                    { 2, new DateTime(2022, 4, 29, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(79), 3, 1, 1 },
                    { 3, new DateTime(2022, 4, 27, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(82), 4, 2, 2 },
                    { 4, new DateTime(2022, 4, 30, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(87), 2, 3, 3 },
                    { 5, new DateTime(2022, 4, 26, 20, 43, 47, 992, DateTimeKind.Local).AddTicks(90), 1, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderedItem",
                columns: new[] { "OrderedItemId", "GenericItemId", "OrderId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 1, 2 },
                    { 5, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenericItem_ItemDetailsId",
                table: "GenericItem",
                column: "ItemDetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GenericItem_ItemDetailsId",
                table: "GenericItem");

            migrationBuilder.DeleteData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ItemStatistics",
                keyColumn: "ItemStatisticsId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "OrderedItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "OrderedItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "OrderedItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "OrderedItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderedItem",
                keyColumn: "OrderedItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GenericItem",
                keyColumn: "GenericItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenericItem",
                keyColumn: "GenericItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenericItem",
                keyColumn: "GenericItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ShippingAddress",
                keyColumn: "ShippingAddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemDetails",
                keyColumn: "ItemDetailsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShippingAddress",
                keyColumn: "ShippingAddressId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShippingAddress",
                keyColumn: "ShippingAddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.CreateIndex(
                name: "IX_GenericItem_ItemDetailsId",
                table: "GenericItem",
                column: "ItemDetailsId",
                unique: true);
        }
    }
}
