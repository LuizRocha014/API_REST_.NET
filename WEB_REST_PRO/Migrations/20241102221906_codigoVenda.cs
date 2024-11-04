using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_REST_PRO.Migrations
{
    /// <inheritdoc />
    public partial class codigoVenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "codigoVenda",
                table: "Sale",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codigoVenda",
                table: "Sale");
        }
    }
}
