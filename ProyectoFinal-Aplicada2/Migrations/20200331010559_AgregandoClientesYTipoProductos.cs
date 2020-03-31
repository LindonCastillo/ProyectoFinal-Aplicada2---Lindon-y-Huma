using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal_Aplicada2.Migrations
{
    public partial class AgregandoClientesYTipoProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Telefono_O_Celular = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "TipoProductos",
                columns: table => new
                {
                    TipoProductoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Categoria = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProductos", x => x.TipoProductoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "TipoProductos");
        }
    }
}
