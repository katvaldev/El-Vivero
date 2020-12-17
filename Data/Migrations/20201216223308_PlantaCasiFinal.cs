using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vivero.Data.Migrations
{
    public partial class PlantaCasiFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Temperatura Inicial",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Temperatura Final",
                table: "Planta");

            migrationBuilder.AddColumn<string>(
                name: "ImagenURL",
                table: "Planta",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Temperatura Ideal",
                table: "Planta",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenURL",
                table: "Planta");

            migrationBuilder.DropColumn(
                name: "Temperatura Ideal",
                table: "Planta");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Planta",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[] {  });

            migrationBuilder.AddColumn<double>(
                name: "Temperatura Inicial",
                table: "Planta",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Temperatura Final",
                table: "Planta",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
