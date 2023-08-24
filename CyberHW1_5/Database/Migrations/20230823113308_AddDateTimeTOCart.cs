using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyberHW1_5.Migrations
{
    /// <inheritdoc />
    public partial class AddDateTimeTOCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "carts",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2023, 8, 23, 14, 33, 8, 764, DateTimeKind.Local).AddTicks(629));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "carts");
        }
    }
}
