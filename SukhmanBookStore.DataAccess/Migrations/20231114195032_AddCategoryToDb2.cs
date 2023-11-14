using Microsoft.EntityFrameworkCore.Migrations;

namespace SukhmanBookStore.DataAccess.Migrations
{
    public partial class AddCategoryToDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nmae",
                table: "Categories",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Name");
        }
    }
}
