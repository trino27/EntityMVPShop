using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopMVP.Migrations
{
    /// <inheritdoc />
    public partial class Empty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_users_UserId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_words_products_ProductId",
                table: "words");

            migrationBuilder.DropIndex(
                name: "IX_products_UserId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_words",
                table: "words");

            migrationBuilder.DropIndex(
                name: "IX_words_ProductId",
                table: "words");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "words");

            migrationBuilder.RenameTable(
                name: "words",
                newName: "keyWords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_keyWords",
                table: "keyWords",
                column: "KeyWordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_keyWords",
                table: "keyWords");

            migrationBuilder.RenameTable(
                name: "keyWords",
                newName: "words");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "words",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_words",
                table: "words",
                column: "KeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_products_UserId",
                table: "products",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_words_ProductId",
                table: "words",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_users_UserId",
                table: "products",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_words_products_ProductId",
                table: "words",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "ProductId");
        }
    }
}
