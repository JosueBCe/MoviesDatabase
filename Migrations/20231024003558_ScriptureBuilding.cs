using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesDatabase.Migrations
{
    /// <inheritdoc />
    public partial class ScriptureBuilding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "Scripture");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Movie",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Movie",
                newName: "Book");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Scripture",
                table: "Movie",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Movie",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "Book",
                table: "Movie",
                newName: "Genre");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Movie",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }
    }
}
