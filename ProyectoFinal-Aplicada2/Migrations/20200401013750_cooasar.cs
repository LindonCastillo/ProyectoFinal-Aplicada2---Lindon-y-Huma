using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal_Aplicada2.Migrations
{
    public partial class cooasar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: true),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    CompraId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCompra = table.Column<DateTime>(nullable: false),
                    NombreProveedor = table.Column<string>(nullable: false),
                    Itbis = table.Column<decimal>(nullable: false),
                    DescripcionCompra = table.Column<string>(maxLength: 30, nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    Balance = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagoFecha = table.Column<DateTime>(nullable: false),
                    PagoTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEntrada = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioCompra = table.Column<decimal>(nullable: false),
                    PorcentajeGanancias = table.Column<decimal>(nullable: false),
                    PrecioVentas = table.Column<decimal>(nullable: false),
                    CategoriaProducto = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    ProveedoresId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProveedor = table.Column<string>(maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(maxLength: 10, nullable: false),
                    RNC = table.Column<string>(maxLength: 9, nullable: false),
                    TipoNegocio = table.Column<string>(nullable: false),
                    Direcciones = table.Column<string>(maxLength: 80, nullable: false),
                    TipoMoneda = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.ProveedoresId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(maxLength: 50, nullable: false),
                    EmailUsuario = table.Column<string>(nullable: false),
                    NombreUsuario = table.Column<string>(maxLength: 30, nullable: false),
                    Clave = table.Column<string>(maxLength: 60, nullable: false),
                    ConfirmarClave = table.Column<string>(maxLength: 60, nullable: false),
                    NivelUsuario = table.Column<string>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    ClientesVentas = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "ComprasDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompraId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioCompra = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComprasDetalle_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "CompraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagosDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagoId = table.Column<int>(nullable: false),
                    CompraId = table.Column<int>(nullable: false),
                    TipoPago = table.Column<string>(nullable: true),
                    Pago = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagosDetalle_Pagos_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pagos",
                        principalColumn: "PagoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VentasDetalle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentaId = table.Column<int>(nullable: false),
                    ProductoId = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioVenta = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentasDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentasDetalle_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "VentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComprasDetalle_CompraId",
                table: "ComprasDetalle",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDetalle_PagoId",
                table: "PagosDetalle",
                column: "PagoId");

            migrationBuilder.CreateIndex(
                name: "IX_VentasDetalle_VentaId",
                table: "VentasDetalle",
                column: "VentaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "ComprasDetalle");

            migrationBuilder.DropTable(
                name: "PagosDetalle");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "VentasDetalle");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
