using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal_Aplicada2.Data;
using ProyectoFinal_Aplicada2.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal_Aplicada2.Controllers
{
    public class ProductosControllers
    {


        public bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.Productos.Any(A=>A.ProductoId == productos.ProductoId))
                {
                    Modificar(productos);
                } else
                {
                    Guardar(productos);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        private bool Insertar(Productos productos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Productos.Add(productos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        private bool Modificar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(productos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                Productos productos = db.Productos.Find(id);
                if(productos!=null)
                {
                    db.Entry(productos).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

    }
}
