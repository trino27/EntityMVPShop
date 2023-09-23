using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMVP.Migrations
{
    /// <inheritdoc />
    public partial class TryRemoveUniqueWord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_words_Word",
                table: "words");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_words_Word",
                table: "words",
                column: "Word",
                unique: true);
        }
    }
}
