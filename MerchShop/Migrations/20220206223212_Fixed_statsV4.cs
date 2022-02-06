using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class Fixed_statsV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics",
                column: "GenericItemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics",
                column: "GenericItemId");
        }
    }
}
