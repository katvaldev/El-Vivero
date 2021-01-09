using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Migrations
{
    public partial class Carrito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Orden",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlantaID",
                table: "Orden",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnit",
                table: "Orden",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Orden",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "PlantaID",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "PrecioUnit",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Orden");
        }
    }
}
