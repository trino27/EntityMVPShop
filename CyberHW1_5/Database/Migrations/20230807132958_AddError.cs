using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberHW1_5.Migrations
{
    /// <inheritdoc />
    public partial class AddError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_users_number",
                table: "users",
                column: "number");

            migrationBuilder.CreateTable(
                name: "errors",
                columns: table => new
                {
                    ErrorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_errors", x => x.ErrorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "errors");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_users_number",
                table: "users");
        }
    }
}
