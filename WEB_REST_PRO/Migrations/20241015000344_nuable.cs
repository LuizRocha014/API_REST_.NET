using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_REST_PRO.Migrations
{
    /// <inheritdoc />
    public partial class nuable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ShopProduct",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ShopProduct_UserId",
                table: "ShopProduct",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProduct_User_UserId",
                table: "ShopProduct",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProduct_User_UserId",
                table: "ShopProduct");

            migrationBuilder.DropIndex(
                name: "IX_ShopProduct_UserId",
                table: "ShopProduct");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShopProduct");
        }
    }
}
