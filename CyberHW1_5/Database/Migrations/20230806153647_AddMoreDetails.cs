using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberHW1_5.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "users",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "users",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "000000000000",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "000000000000");

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_users_login",
                table: "users",
                column: "login",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_number",
                table: "users",
                column: "number",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_users_login",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_number",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "000000000000",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldDefaultValue: "000000000000");

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
