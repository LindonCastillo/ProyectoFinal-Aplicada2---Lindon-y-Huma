using Microsoft.EntityFrameworkCore;
using ProyectoFinal_Aplicada2.Data;
using ProyectoFinal_Aplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Controllers
{
    public class PagosControllers
    {
        public bool Guardar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Pagos.Any(A => A.PagoId == pagos.PagoId))
                {
                    paso = Modificar(pagos);
                }
                else
                {
                    paso = Insertar(pagos);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Pagos.Add(pagos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Modificar(Pagos pagos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Pagos anterior = Buscar(pagos.PagoId);

                foreach (var item in pagos.PagosDetalles)
                {
                    if (item.Id == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                }

                foreach (var item in anterior.PagosDetalles)
                {
                    if (!pagos.PagosDetalles.Any(A => A.Id == A.Id))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                db.Entry(pagos).State = EntityState.Modified;
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
                Pagos pagos = db.Pagos.Find(id);
                if (pagos != null)
                {
                    db.Entry(pagos).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Pagos Buscar(int id)
        {
            Pagos pagos;
            Contexto db = new Contexto();
            try
            {
                pagos = db.Pagos.Where(C => C.PagoId == id).Include(D => D.PagosDetalles).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return pagos;
        }

        public List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> lista = new List<Pagos>();
            Contexto db = new Contexto();
            try
            {
                lista = db.Pagos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
