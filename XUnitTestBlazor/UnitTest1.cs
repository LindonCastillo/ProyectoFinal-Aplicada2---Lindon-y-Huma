using System;
using Xunit;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;

namespace XUnitTestBlazor
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ProductosControllers productoscontrollers = new ProductosControllers();
            Productos productos = new Productos();
            productos.ProductoId = 0;
            productos.FechaEntrada = DateTime.Now;
            productos.Cantidad = 12;
            productos.Nombre = "Nombre";
            productos.PrecioCompra = 12;
            productos.PrecioVentas = 12;

            Assert.True(productoscontrollers.Guardar(productos));
        }
    }
}
