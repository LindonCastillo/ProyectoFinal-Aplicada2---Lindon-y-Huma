using System;
using Xunit;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;

namespace XUnitTestProyectoFinall
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ProductosControllers productosControllers = new ProductosControllers();
            Productos productos = new Productos();
            productos.ProductoId = 0;
            productos.FechaEntrada = DateTime.Now;
            productos.Cantidad = 12;
            productos.Nombre = "Ezequiel";
            productos.PrecioCompra = 12;
            productos.PrecioVentas = 12;
            productos.PorcentajeGanancias = 12;
            Assert.True(productosControllers.Guardar(productos));

        }
    }
}
