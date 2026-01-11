using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleNotesApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIsFavourite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "Notes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "Notes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
