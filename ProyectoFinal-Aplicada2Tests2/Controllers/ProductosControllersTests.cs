using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
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
            ProductosControllers controller = new ProductosControllers();
            Productos productos = new Productos();
            productos.ProductoId = 0;
            productos.Nombre = "Pala";
            productos.FechaEntrada = DateTime.Now;
            productos.Cantidad = 89;
            productos.CategoriaProducto = "Herramientas";
            productos.PrecioCompra = 200;
            productos.PorcentajeGanancias = 100;
            productos.PrecioVentas = 400;

            Assert.IsTrue(controller.Guardar(productos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            ProductosControllers controller = new ProductosControllers();
            Assert.IsTrue(controller.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            ProductosControllers controller = new ProductosControllers();
            Assert.IsNotNull(controller.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            ProductosControllers controller = new ProductosControllers();
            Assert.IsNotNull(controller.GetList(A => true));
        }
    }
}