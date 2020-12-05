using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Data.Migrations
{
    public partial class ActualizacionPlantaFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planta_TipoPlanta_IDTipoplanta",
                table: "Planta");

            migrationBuilder.RenameColumn(
                name: "IDTipoplanta",
                table: "Planta",
                newName: "IDTipoPlanta");

            migrationBuilder.RenameIndex(
                name: "IX_Planta_IDTipoplanta",
                table: "Planta",
                newName: "IX_Planta_IDTipoPlanta");

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_TipoPlanta_IDTipoPlanta",
                table: "Planta",
                column: "IDTipoPlanta",
                principalTable: "TipoPlanta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planta_TipoPlanta_IDTipoPlanta",
                table: "Planta");

            migrationBuilder.RenameColumn(
                name: "IDTipoPlanta",
                table: "Planta",
                newName: "IDTipoplanta");

            migrationBuilder.RenameIndex(
                name: "IX_Planta_IDTipoPlanta",
                table: "Planta",
                newName: "IX_Planta_IDTipoplanta");

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_TipoPlanta_IDTipoplanta",
                table: "Planta",
                column: "IDTipoplanta",
                principalTable: "TipoPlanta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
