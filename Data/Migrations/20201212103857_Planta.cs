using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Data.Migrations
{
    public partial class Planta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nombre_planta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "imagen_planta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Riego_planta",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Tips_planta",
                table: "Planta");

            migrationBuilder.RenameColumn(
                name: "stock",
                table: "Planta",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Planta",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Planta",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TemperaturaB_planta",
                table: "Planta",
                newName: "Temperatura Final");

            migrationBuilder.RenameColumn(
                name: "TemperaturaA_planta",
                table: "Planta",
                newName: "Temperatura Inicial");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Planta",
                nullable: false,
                defaultValue: new byte[] {  });

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Planta",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Riego",
                table: "Planta",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tips",
                table: "Planta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Riego",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Tips",
                table: "Planta");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Planta",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Planta",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Planta",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Temperatura Final",
                table: "Planta",
                newName: "TemperaturaB_planta");

            migrationBuilder.RenameColumn(
                name: "Temperatura Inicial",
                table: "Planta",
                newName: "TemperaturaA_planta");

            migrationBuilder.AddColumn<string>(
                name: "nombre_planta",
                table: "Planta",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "imagen_planta",
                table: "Planta",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Riego_planta",
                table: "Planta",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tips_planta",
                table: "Planta",
                type: "text",
                nullable: true);
        }
    }
}
