using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class VentasControllersTests
    {
        [TestMethod()] 
        public void GuardarTest()
        {
            VentasControllers controller = new VentasControllers();
            Ventas ventas = new Ventas();
            ventas.VentaId = 0;
            ventas.ClientesVentas = "No se";
            ventas.FechaVenta = DateTime.Now;
            ventas.Total = 2000;

            ventas.VentasDetalles.Add(new VentasDetalle()
            {
                Id = 0,
                VentaId = 0,
                Cantidad = 5,
                Nombre = "No va",
                PrecioVenta = 300,
                ProductoId = 2,
                SubTotal = 200
            });

            Assert.IsTrue(controller.Guardar(ventas));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            VentasControllers controller = new VentasControllers();
            Assert.IsTrue(controller.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            VentasControllers controller = new VentasControllers();
            Assert.IsNotNull(controller.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            VentasControllers controller = new VentasControllers();
            Assert.IsNotNull(controller.GetList(A => true));
        }
    }
}