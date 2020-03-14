using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal_Aplicada2.Models;
using ProyectoFinal_Aplicada2.Data;

namespace ProyectoFinal_Aplicada2.Controllers
{
    public class ProveedoresControllers
    {


        public bool Guardar(Proveedores proveedores)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if(db.Proveedores.Any(A=>A.ProveedoresId == proveedores.ProveedoresId))
                {
                    paso = Modificar(proveedores);
                } else
                {
                    paso = Insertar(proveedores);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool Insertar(Proveedores proveedores)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Proveedores.Add(proveedores).State = EntityState.Added;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Modificar(Proveedores proveedores)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(proveedores).State = EntityState.Modified;
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
                Proveedores proveedores = db.Proveedores.Find(id);
                if(proveedores!=null)
                {
                    db.Entry(proveedores).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Proveedores Buscar(int id)
        {
            Proveedores proveedores = new Proveedores();
            Contexto db = new Contexto();
            try
            {
                proveedores = db.Proveedores.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Proveedores> GetList(Expression<Func<Proveedores,bool>> expression)
        {
            List<Proveedores> lista = new List<Proveedores>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Proveedores.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}
