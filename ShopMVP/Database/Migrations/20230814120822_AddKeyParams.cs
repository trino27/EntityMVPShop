using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMVP.Migrations
{
    /// <inheritdoc />
    public partial class AddKeyParams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "keyParams",
                columns: table => new
                {
                    KeyParamsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KeyWordId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyParams", x => x.KeyParamsId);
                    table.ForeignKey(
                        name: "FK_keyParams_keyWords_KeyWordId",
                        column: x => x.KeyWordId,
                        principalTable: "keyWords",
                        principalColumn: "KeyWordId");
                    table.ForeignKey(
                        name: "FK_keyParams_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_keyParams_KeyWordId",
                table: "keyParams",
                column: "KeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_keyParams_ProductId",
                table: "keyParams",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "keyParams");
        }
    }
}
