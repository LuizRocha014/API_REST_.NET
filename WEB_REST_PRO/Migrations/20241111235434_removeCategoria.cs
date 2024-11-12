using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_REST_PRO.Migrations
{
    /// <inheritdoc />
    public partial class removeCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Company_CompanyId",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_CompanyId",
                table: "Shop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Shop_CompanyId",
                table: "Shop",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Company_CompanyId",
                table: "Shop",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
