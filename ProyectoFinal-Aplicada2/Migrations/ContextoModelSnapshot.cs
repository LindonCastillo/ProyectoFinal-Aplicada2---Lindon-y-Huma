﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal_Aplicada2.Data;

namespace ProyectoFinal_Aplicada2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.Compras", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<string>("DescripcionCompra")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Itbis")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("CompraId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.ComprasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioCompra")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.ToTable("ComprasDetalle");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.Pagos", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PagoFecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PagoTotal")
                        .HasColumnType("TEXT");

                    b.HasKey("PagoId");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.PagosDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompraId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Pago")
                        .HasColumnType("TEXT");

                    b.Property<int>("PagoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoPago")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PagoId");

                    b.ToTable("PagosDetalle");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaEntrada")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<decimal>("PorcentajeGanancias")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioCompra")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioVentas")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.Proveedores", b =>
                {
                    b.Property<int>("ProveedoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direcciones")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(80);

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("RNC")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(9);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("TipoMoneda")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoNegocio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProveedoresId");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("ConfirmarClave")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<string>("NivelUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.Ventas", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaVenta")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("VentaId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.VentasDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("TEXT");

                    b.Property<int>("VentaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("VentaId");

                    b.ToTable("VentasDetalle");
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.ComprasDetalle", b =>
                {
                    b.HasOne("ProyectoFinal_Aplicada2.Models.Compras", null)
                        .WithMany("ComprasDetalles")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.PagosDetalle", b =>
                {
                    b.HasOne("ProyectoFinal_Aplicada2.Models.Pagos", null)
                        .WithMany("PagosDetalles")
                        .HasForeignKey("PagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProyectoFinal_Aplicada2.Models.VentasDetalle", b =>
                {
                    b.HasOne("ProyectoFinal_Aplicada2.Models.Ventas", null)
                        .WithMany("VentasDetalles")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
