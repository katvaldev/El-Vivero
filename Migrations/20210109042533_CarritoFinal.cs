using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Migrations
{
    public partial class CarritoFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Producto",
                table: "Orden",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Orden",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Producto",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Orden");
        }
    }
}
