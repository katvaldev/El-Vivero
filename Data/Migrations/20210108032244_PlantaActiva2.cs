using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Migrations
{
    public partial class PlantaActiva2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Planta");

            migrationBuilder.AddColumn<bool>(
                name: "Deshabilitado",
                table: "Planta",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deshabilitado",
                table: "Planta");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Planta",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}
