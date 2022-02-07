using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class data_seeding_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShippingAddress",
                columns: new[] { "Id", "ApartmentNumber", "City", "Country", "PostalCode", "Region", "StreetAddress", "UserId" },
                values: new object[] { 1, "3", "Wrocław", "PL", "50-004", "Dolnośląskie", "Smocza 5", 1 });

            migrationBuilder.InsertData(
                table: "ShippingAddress",
                columns: new[] { "Id", "ApartmentNumber", "City", "Country", "PostalCode", "Region", "StreetAddress", "UserId" },
                values: new object[] { 2, "4", "Wrocław", "PL", "50-004", "Dolnośląskie", "Polna 1", 2 });

            migrationBuilder.InsertData(
                table: "ShippingAddress",
                columns: new[] { "Id", "ApartmentNumber", "City", "Country", "PostalCode", "Region", "StreetAddress", "UserId" },
                values: new object[] { 3, null, "Wrocław", "PL", "50-004", "Dolnośląskie", "Piękna 62", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShippingAddress",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ShippingAddress",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ShippingAddress",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
