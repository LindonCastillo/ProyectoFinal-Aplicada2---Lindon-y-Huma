using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal_Aplicada2.Migrations
{
    public partial class AgregandoClientesYTipoProductosPorSegundaVez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductoSeleccionado",
                table: "TipoProductos",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductoSeleccionado",
                table: "TipoProductos");
        }
    }
}
