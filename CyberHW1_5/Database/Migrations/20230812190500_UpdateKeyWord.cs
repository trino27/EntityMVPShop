using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMVP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateKeyWord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_words_KeyWord",
                table: "words");

            migrationBuilder.DropColumn(
                name: "KeyWord",
                table: "words");

            migrationBuilder.RenameColumn(
                name: "WordId",
                table: "words",
                newName: "KeyWordId");

            migrationBuilder.AddColumn<string>(
                name: "Word",
                table: "words",
                type: "nvarchar(24)",
                maxLength: 24,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_words_Word",
                table: "words",
                column: "Word",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_words_Word",
                table: "words");

            migrationBuilder.DropColumn(
                name: "Word",
                table: "words");

            migrationBuilder.RenameColumn(
                name: "KeyWordId",
                table: "words",
                newName: "WordId");

            migrationBuilder.AddColumn<string>(
                name: "KeyWord",
                table: "words",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_words_KeyWord",
                table: "words",
                column: "KeyWord",
                unique: true);
        }
    }
}
