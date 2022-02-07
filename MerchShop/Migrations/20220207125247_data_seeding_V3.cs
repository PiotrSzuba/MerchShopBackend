using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class data_seeding_V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "GenericItem",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.InsertData(
                table: "GenericItem",
                columns: new[] { "Id", "DiscountValue", "IsInStock", "Name", "OnDiscount", "PreviewImage", "Price" },
                values: new object[] { 1, 0, true, "STD shirt", false, null, 79.99m });

            migrationBuilder.InsertData(
                table: "GenericItem",
                columns: new[] { "Id", "DiscountValue", "IsInStock", "Name", "OnDiscount", "PreviewImage", "Price" },
                values: new object[] { 2, 0, true, "Better jeans", false, null, 150.99m });

            migrationBuilder.InsertData(
                table: "GenericItem",
                columns: new[] { "Id", "DiscountValue", "IsInStock", "Name", "OnDiscount", "PreviewImage", "Price" },
                values: new object[] { 3, 0, true, "Basic hoodie", false, null, 240.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenericItem",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenericItem",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenericItem",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "GenericItem",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
