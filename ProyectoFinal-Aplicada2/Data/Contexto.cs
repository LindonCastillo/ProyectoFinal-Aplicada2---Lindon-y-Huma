using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_Aplicada2.Models;

namespace ProyectoFinal_Aplicada2.Data
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = CooperativaDb; Trusted_Connection = True; ");
            optionsBuilder.UseSqlServer(@"Server=tcp:cooasar-projectdbserver.database.windows.net,1433;Initial Catalog=COOASAR-PROJECT_db;Persist Security Info=False;User ID=Administrador-Rico;Password=Asdfghjkl05;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
    }
}
