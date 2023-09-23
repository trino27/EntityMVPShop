using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMVP.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAlterKeyfromUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_users_number",
                table: "users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_users_number",
                table: "users",
                column: "number");
        }
    }
}
