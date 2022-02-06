using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class Fixed_stats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemStatisticsId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenericItemId = table.Column<int>(type: "int", nullable: false),
                    BoughtTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuyersCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoughtOnSale = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemStatistics_GenericItem_GenericItemId",
                        column: x => x.GenericItemId,
                        principalTable: "GenericItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_ItemStatisticsId",
                table: "Order",
                column: "ItemStatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemStatistics_GenericItemId",
                table: "ItemStatistics",
                column: "GenericItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_ItemStatistics_ItemStatisticsId",
                table: "Order",
                column: "ItemStatisticsId",
                principalTable: "ItemStatistics",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_ItemStatistics_ItemStatisticsId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "ItemStatistics");

            migrationBuilder.DropIndex(
                name: "IX_Order_ItemStatisticsId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ItemStatisticsId",
                table: "Order");
        }
    }
}
