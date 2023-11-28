using Microsoft.EntityFrameworkCore.Migrations;

namespace SukhmanBookStore.DataAccess.Migrations
{
    public partial class addProductToDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products",
                column: "CoverTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_CoverTypeId",
                table: "Products");
        }
    }
}
