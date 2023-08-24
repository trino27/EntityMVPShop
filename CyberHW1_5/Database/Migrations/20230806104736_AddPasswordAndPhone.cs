using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberHW1_5.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordAndPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "00000000");

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "000000000000");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "users");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "users");
        }
    }
}
