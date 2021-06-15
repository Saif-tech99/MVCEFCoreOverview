using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCEFCoreOverview.Migrations
{
    public partial class ClassBookDetailAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Counter",
                table: "books",
                newName: "BookDetailId");

            migrationBuilder.AddColumn<string>(
                name: "AutherFirstName",
                table: "books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutherLastName",
                table: "books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "details",
                columns: table => new
                {
                    BookDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_details", x => x.BookDetailId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_BookDetailId",
                table: "books",
                column: "BookDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_books_details_BookDetailId",
                table: "books",
                column: "BookDetailId",
                principalTable: "details",
                principalColumn: "BookDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_details_BookDetailId",
                table: "books");

            migrationBuilder.DropTable(
                name: "details");

            migrationBuilder.DropIndex(
                name: "IX_books_BookDetailId",
                table: "books");

            migrationBuilder.DropColumn(
                name: "AutherFirstName",
                table: "books");

            migrationBuilder.DropColumn(
                name: "AutherLastName",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "BookDetailId",
                table: "books",
                newName: "Counter");
        }
    }
}
