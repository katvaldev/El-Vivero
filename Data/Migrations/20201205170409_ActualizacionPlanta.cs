using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Vivero.Data.Migrations
{
    public partial class ActualizacionPlanta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planta_TipoPlanta_IdTipo",
                table: "Planta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPlanta",
                table: "TipoPlanta");

            migrationBuilder.DropIndex(
                name: "IX_Planta_IdTipo",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "TipoPlanta");

            migrationBuilder.DropColumn(
                name: "IdTipo",
                table: "Planta");

            migrationBuilder.RenameTable(
                name: "TipoPlanta",
                newName: "Tipoplanta");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Planta",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Planta",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "Nombre_planta",
                table: "Planta",
                newName: "nombre_planta");

            migrationBuilder.RenameColumn(
                name: "Imagen_planta",
                table: "Planta",
                newName: "imagen_planta");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Planta",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "IDTipoplanta",
                table: "Tipoplanta",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<decimal>(
                name: "precio",
                table: "Planta",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "nombre_planta",
                table: "Planta",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "imagen_planta",
                table: "Planta",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IDTipoplanta",
                table: "Planta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TemperaturaA_planta",
                table: "Planta",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TemperaturaB_planta",
                table: "Planta",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Riego_planta",
                table: "Planta",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tips_planta",
                table: "Planta",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipoplanta",
                table: "Tipoplanta",
                column: "IDTipoplanta");

            migrationBuilder.CreateIndex(
                name: "IX_Planta_IDTipoplanta",
                table: "Planta",
                column: "IDTipoplanta");

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_Tipoplanta_IDTipoplanta",
                table: "Planta",
                column: "IDTipoplanta",
                principalTable: "Tipoplanta",
                principalColumn: "IDTipoplanta",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planta_Tipoplanta_IDTipoplanta",
                table: "Planta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipoplanta",
                table: "Tipoplanta");

            migrationBuilder.DropIndex(
                name: "IX_Planta_IDTipoplanta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "IDTipoplanta",
                table: "Tipoplanta");

            migrationBuilder.DropColumn(
                name: "IDTipoplanta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "TemperaturaA_planta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "TemperaturaB_planta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Riego_planta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Tips_planta",
                table: "Planta");

            migrationBuilder.RenameTable(
                name: "Tipoplanta",
                newName: "TipoPlanta");

            migrationBuilder.RenameColumn(
                name: "stock",
                table: "Planta",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Planta",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "imagen_planta",
                table: "Planta",
                newName: "Imagen_planta");

            migrationBuilder.RenameColumn(
                name: "nombre_planta",
                table: "Planta",
                newName: "Nombre_planta");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Planta",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "TipoPlanta",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "Planta",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Imagen_planta",
                table: "Planta",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Nombre_planta",
                table: "Planta",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "IdTipo",
                table: "Planta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPlanta",
                table: "TipoPlanta",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Planta_IdTipo",
                table: "Planta",
                column: "IdTipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Planta_TipoPlanta_IdTipo",
                table: "Planta",
                column: "IdTipo",
                principalTable: "TipoPlanta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
