using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Guardar()
        {
            UsuariosControllers controllers = new UsuariosControllers();
            Usuarios usuarios = new Usuarios();

            usuarios.UsuarioId = 0;
            usuarios.NombrePersona = "Mario";
            usuarios.EmailUsuario = "Mario09@hotmail.com";
            usuarios.Clave = "12345";
            usuarios.ConfirmarClave = "12345";
            usuarios.NivelUsuario = "Cajero";
            usuarios.FechaIngreso = DateTime.Now;

            Assert.True(controllers.Guardar(usuarios));
        }
    }
}
