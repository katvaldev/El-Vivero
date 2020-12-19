using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Migrations
{
    public partial class PlantaStr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planta_TipoPlanta_IDTipoPlanta",
                table: "Planta");

            migrationBuilder.DropIndex(
                name: "IX_Planta_IDTipoPlanta",
                table: "Planta");

            migrationBuilder.AddColumn<string>(
                name: "TipoPlanta",
                table: "Planta",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoPlantaID",
                table: "Planta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Planta_TipoPlantaID",
                table: "Planta",
                column: "TipoPlantaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_TipoPlanta_TipoPlantaID",
                table: "Planta",
                column: "TipoPlantaID",
                principalTable: "TipoPlanta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planta_TipoPlanta_TipoPlantaID",
                table: "Planta");

            migrationBuilder.DropIndex(
                name: "IX_Planta_TipoPlantaID",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "TipoPlanta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "TipoPlantaID",
                table: "Planta");

            migrationBuilder.CreateIndex(
                name: "IX_Planta_IDTipoPlanta",
                table: "Planta",
                column: "IDTipoPlanta");

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_TipoPlanta_IDTipoPlanta",
                table: "Planta",
                column: "IDTipoPlanta",
                principalTable: "TipoPlanta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
