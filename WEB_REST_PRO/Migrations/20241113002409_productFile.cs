using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_REST_PRO.Migrations
{
    /// <inheritdoc />
    public partial class productFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFile_File_FileId",
                table: "ProductFile");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFile_Product_ProductId",
                table: "ProductFile");

            migrationBuilder.DropIndex(
                name: "IX_ProductFile_FileId",
                table: "ProductFile");

            migrationBuilder.DropIndex(
                name: "IX_ProductFile_ProductId",
                table: "ProductFile");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductFile_FileId",
                table: "ProductFile",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFile_ProductId",
                table: "ProductFile",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFile_File_FileId",
                table: "ProductFile",
                column: "FileId",
                principalTable: "File",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFile_Product_ProductId",
                table: "ProductFile",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
