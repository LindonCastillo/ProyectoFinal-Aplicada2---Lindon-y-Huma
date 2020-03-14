using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ProyectoFinal_Aplicada2.Data;
using System.Threading.Tasks;
using System;

namespace ProyectoFinalTests
{
    [TestClass]
    public class ProductosTest
    {
        [TestMethod]
        public void Guardar()
        {
            Productos productos = new Productos();
            ProductosControllers productosControllers = new ProductosControllers();

            productos.ProductoId = 0;
            productos.FechaEntrada = DateTime.Now;
            productos.Nombre = "Alguien";
            productos.PorcentajeGanancias = 12;
            productos.PrecioVentas = 2000;
            productos.Cantidad = 102;

            productosControllers.Guardar(productos);

        }
    }
}
