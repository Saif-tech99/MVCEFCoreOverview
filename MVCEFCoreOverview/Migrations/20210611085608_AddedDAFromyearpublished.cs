using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCEFCoreOverview.Migrations
{
    public partial class AddedDAFromyearpublished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "YearPublished",
                table: "books",
                newName: "PublishingYear");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishingYear",
                table: "books",
                newName: "YearPublished");
        }
    }
}
