using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Migrations
{
    public partial class TipoActivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deshabilitado",
                table: "TipoPlanta",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deshabilitado",
                table: "TipoPlanta");
        }
    }
}
