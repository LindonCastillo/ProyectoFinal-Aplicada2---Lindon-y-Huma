using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class ProveedoresControllersTests
    {
        [TestMethod()] 
        public void GuardarTest()
        {
            ProveedoresControllers controller = new ProveedoresControllers();
            Proveedores proveedores = new Proveedores();
            proveedores.ProveedoresId = 0;
            proveedores.NombreProveedor = "Coopenor";
            proveedores.RNC = "111515511";
            proveedores.Direcciones = "No se";
            proveedores.Telefono = "8455059638";
            proveedores.TipoMoneda = "Peso";
            proveedores.TipoNegocio ="Ventas";

            Assert.IsTrue(controller.Guardar(proveedores));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            ProveedoresControllers controller = new ProveedoresControllers();
            Assert.IsTrue(controller.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            ProveedoresControllers controller = new ProveedoresControllers();
            Assert.IsNotNull(controller.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            ProveedoresControllers controller = new ProveedoresControllers();
            Assert.IsNotNull(controller.GetList(A => true));
        }
    }
}