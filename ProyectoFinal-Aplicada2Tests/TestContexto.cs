using Microsoft.EntityFrameworkCore;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2Tests
{
    class TestContexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlite("Data Source = Test/TestDb"));
        }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
