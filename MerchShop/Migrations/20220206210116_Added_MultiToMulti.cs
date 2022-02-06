using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class Added_MultiToMulti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenericItem_Order_OrderId",
                table: "GenericItem");

            migrationBuilder.DropIndex(
                name: "IX_GenericItem_OrderId",
                table: "GenericItem");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "GenericItem");

            migrationBuilder.CreateTable(
                name: "OrderedItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    GenericItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderedItem_GenericItem_GenericItemId",
                        column: x => x.GenericItemId,
                        principalTable: "GenericItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderedItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderedItem_GenericItemId",
                table: "OrderedItem",
                column: "GenericItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedItem_OrderId",
                table: "OrderedItem",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderedItem");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "GenericItem",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenericItem_OrderId",
                table: "GenericItem",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_GenericItem_Order_OrderId",
                table: "GenericItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }
    }
}
