using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal_Aplicada2.Migrations
{
    public partial class pakko : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagosDetalle_Pagos_PagosId",
                table: "PagosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_PagosDetalle_PagosId",
                table: "PagosDetalle");

            migrationBuilder.DropColumn(
                name: "PagosId",
                table: "PagosDetalle");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDetalle_PagoId",
                table: "PagosDetalle",
                column: "PagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PagosDetalle_Pagos_PagoId",
                table: "PagosDetalle",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "PagoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PagosDetalle_Pagos_PagoId",
                table: "PagosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_PagosDetalle_PagoId",
                table: "PagosDetalle");

            migrationBuilder.AddColumn<int>(
                name: "PagosId",
                table: "PagosDetalle",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PagosDetalle_PagosId",
                table: "PagosDetalle",
                column: "PagosId");

            migrationBuilder.AddForeignKey(
                name: "FK_PagosDetalle_Pagos_PagosId",
                table: "PagosDetalle",
                column: "PagosId",
                principalTable: "Pagos",
                principalColumn: "PagoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
