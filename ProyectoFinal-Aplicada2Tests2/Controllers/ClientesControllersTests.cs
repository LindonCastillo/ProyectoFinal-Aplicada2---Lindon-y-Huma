using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class ClientesControllersTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            ClientesControllers controller = new ClientesControllers();
            Clientes clientes = new Clientes();
            clientes.ClienteId = 0;
            clientes.Nombres = "Lindon Emil";
            clientes.Apellidos = "Castillo Burgos";
            clientes.Numero = "8495650482";
            clientes.Direccion = "No se";
            Assert.IsTrue(controller.Guardar(clientes));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            ClientesControllers controller = new ClientesControllers();
            Assert.IsTrue(controller.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            ClientesControllers controller = new ClientesControllers();
            Assert.IsNotNull(controller.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            ClientesControllers controller = new ClientesControllers();
            Assert.IsNotNull(controller.GetList(A => true));
        }
    }
}