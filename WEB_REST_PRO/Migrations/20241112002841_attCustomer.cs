using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_REST_PRO.Migrations
{
    /// <inheritdoc />
    public partial class attCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCustomer_Customer_CustomerId",
                table: "ShopCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopCustomer_Shop_ShopId",
                table: "ShopCustomer");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopProduct_Product_ProductId",
                table: "ShopProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopProduct_Shop_ShopId",
                table: "ShopProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopProduct_User_UserId",
                table: "ShopProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopUser_Shop_ShopId",
                table: "ShopUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopUser_User_UserId",
                table: "ShopUser");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_ShopUser_ShopId",
                table: "ShopUser");

            migrationBuilder.DropIndex(
                name: "IX_ShopUser_UserId",
                table: "ShopUser");

            migrationBuilder.DropIndex(
                name: "IX_ShopProduct_ProductId",
                table: "ShopProduct");

            migrationBuilder.DropIndex(
                name: "IX_ShopProduct_ShopId",
                table: "ShopProduct");

            migrationBuilder.DropIndex(
                name: "IX_ShopProduct_UserId",
                table: "ShopProduct");

            migrationBuilder.DropIndex(
                name: "IX_ShopCustomer_CustomerId",
                table: "ShopCustomer");

            migrationBuilder.DropIndex(
                name: "IX_ShopCustomer_ShopId",
                table: "ShopCustomer");

            migrationBuilder.AddColumn<string>(
                name: "Responsavel",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seguimento",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelefoneResponsavel",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Responsavel",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Seguimento",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "TelefoneResponsavel",
                table: "Customer");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopUser_ShopId",
                table: "ShopUser",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopUser_UserId",
                table: "ShopUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProduct_ProductId",
                table: "ShopProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProduct_ShopId",
                table: "ShopProduct",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopProduct_UserId",
                table: "ShopProduct",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCustomer_CustomerId",
                table: "ShopCustomer",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCustomer_ShopId",
                table: "ShopCustomer",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCustomer_Customer_CustomerId",
                table: "ShopCustomer",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCustomer_Shop_ShopId",
                table: "ShopCustomer",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProduct_Product_ProductId",
                table: "ShopProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProduct_Shop_ShopId",
                table: "ShopProduct",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProduct_User_UserId",
                table: "ShopProduct",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopUser_Shop_ShopId",
                table: "ShopUser",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopUser_User_UserId",
                table: "ShopUser",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
