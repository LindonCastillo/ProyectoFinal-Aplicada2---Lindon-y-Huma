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
            UsuariosControllers controllers = new UsuariosControllers();
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = 0;
            usuarios.NombrePersona = "Pepito";
            usuarios.EmailUsuario = "pepito02@hotmail.com";
            usuarios.Clave = "12345";
            usuarios.ConfirmarClave = "12345";
            usuarios.NivelUsuario = "Cajero";
            usuarios.FechaIngreso = DateTime.Now;
            
            Assert.IsTrue(controllers.Guardar(usuarios));
        }
    }
}