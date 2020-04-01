using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class ComprasControllersTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            ComprasControllers controller = new ComprasControllers();
            Compras compras = new Compras();
            compras.CompraId = 0;
            compras.DescripcionCompra = "No se";
            compras.FechaCompra = DateTime.Now;
            compras.Itbis = 5;
            compras.NombreProveedor = "COOPERNOR";
            compras.Balance = 2000;
            compras.Total = 2000;

            compras.ComprasDetalles.Add(new ComprasDetalle()
            {
                Id = 0,
                CompraId = 0,
                Cantidad = 5,
                Nombre = "No va",
                PrecioCompra = 300,
                ProductoId =2,
                SubTotal =200
            });

            Assert.IsTrue(controller.Guardar(compras));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            ComprasControllers controller = new ComprasControllers();
            Assert.IsTrue(controller.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            ComprasControllers controller = new ComprasControllers();
            Assert.IsNotNull(controller.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            ComprasControllers controller = new ComprasControllers();
            Assert.IsNotNull(controller.GetList(A => true));
        }
    }
}