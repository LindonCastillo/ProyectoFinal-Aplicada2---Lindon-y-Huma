using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class PagosControllersTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            PagosControllers controller = new PagosControllers();
            Pagos pagos = new Pagos();
            pagos.PagoId = 0;
            pagos.PagoFecha = DateTime.Now;
            pagos.PagoTotal = 20000;

            pagos.PagosDetalles.Add(new PagosDetalle()
            {
                Id = 0,
                CompraId = 0,
                PagoId = 5,
                Pago = 300,
                TipoPago = "No se",
            });

            Assert.IsTrue(controller.Guardar(pagos));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            PagosControllers controller = new PagosControllers();
            Assert.IsTrue(controller.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            PagosControllers controller = new PagosControllers();
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