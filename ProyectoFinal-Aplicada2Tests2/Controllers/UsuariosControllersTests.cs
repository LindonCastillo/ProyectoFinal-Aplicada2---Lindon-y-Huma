using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class UsuariosControllersTests
    {
            [TestMethod()]
            public void GuardarTest()
            {
                UsuariosControllers controller = new UsuariosControllers();
                Usuarios usuarios = new Usuarios();
                usuarios.UsuarioId = 0;
                usuarios.NombrePersona = "Paco";
                usuarios.NombreUsuario = "Pakko";
                usuarios.NivelUsuario = "Administrador";
                usuarios.FechaIngreso = DateTime.Now;
                usuarios.Clave = "1";
                usuarios.ConfirmarClave = "1";
                usuarios.EmailUsuario = "no se";
                Assert.IsTrue(controller.Guardar(usuarios));
            }

            [TestMethod()]
            public void EliminarTest()
            {
                UsuariosControllers controller = new UsuariosControllers();
                Assert.IsTrue(controller.Eliminar(2));
            }

            [TestMethod()]
            public void BuscarTest()
            {
                UsuariosControllers controller = new UsuariosControllers();
                Assert.IsNotNull(controller.Buscar(2));
            }

            [TestMethod()]
            public void GetListTest()
            {
                UsuariosControllers controller = new UsuariosControllers();
                Assert.IsNotNull(controller.GetList(A => true));
            }
       
    }
}