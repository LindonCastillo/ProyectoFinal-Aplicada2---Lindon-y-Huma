using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal_Aplicada2.Controllers;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal_Aplicada2.Controllers.Tests
{
    [TestClass()]
    public class CategoriasControllersTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            CategoriasControllers controller = new CategoriasControllers();
            Categorias categorias = new Categorias();
            categorias.CategoriaId = 0;
            categorias.NombreCategoria = "Pesticidas";

            Assert.IsTrue(controller.Guardar(categorias));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            CategoriasControllers controller = new CategoriasControllers();
            Assert.IsTrue(controller.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            CategoriasControllers controller = new CategoriasControllers();
            Assert.IsNotNull(controller.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            CategoriasControllers controller = new CategoriasControllers();
            Assert.IsNotNull(controller.GetList(A => true));
        }
    }
}