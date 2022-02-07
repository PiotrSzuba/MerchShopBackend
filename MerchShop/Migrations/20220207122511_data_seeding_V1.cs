using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MerchShop.Migrations
{
    public partial class data_seeding_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(32)",
                oldMaxLength: 32);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Role", "Surname", "UserName" },
                values: new object[] { 1, "sakonir@gmail.com", "Piotr", "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5", "admin", "Szuba", "Admin" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Role", "Surname", "UserName" },
                values: new object[] { 2, "sakonir2@gmail.com", "War", "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5", "regular", "Wick", "RegularUser1" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Password", "Role", "Surname", "UserName" },
                values: new object[] { 3, "sakonir3@gmail.com", "Ur", "03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4", "worker", "Got", "RegularWorker" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(32)",
                maxLength: 32,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);
        }
    }
}
