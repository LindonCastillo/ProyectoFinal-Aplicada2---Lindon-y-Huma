using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using System;
using ProyectoFinal_Aplicada2.Models;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class ProductosControllersTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Productos productos = new Productos();
            productos.ProductoId = 0;
            productos.Nombre = "Ezequiel";
            productos.FechaEntrada = DateTime.Now;
            productos.Cantidad = 0;
            productos.PrecioCompra = 12;
            productos.PrecioVentas = 12;
            productos.PorcentajeGanancias = 12;
            ProductosControllers productosControllers = new ProductosControllers();
            Assert.IsTrue(productosControllers.Guardar(productos));
        }

        [TestMethod()]
        public void GuardarTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}