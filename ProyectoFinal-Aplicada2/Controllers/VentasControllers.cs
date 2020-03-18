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
    public class VentasControllers
    {
        public bool Guardar(Ventas ventas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Ventas.Any(A => A.VentaId == ventas.VentaId))
                {
                    paso = Modificar(ventas);
                }
                else
                {
                    paso = Insertar(ventas);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Ventas ventas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            ProductosControllers controllers = new ProductosControllers();
            try
            {

                foreach (var item in ventas.VentasDetalles)
                {
                    Productos temp = controllers.Buscar(item.ProductoId);
                    temp.Cantidad -= item.Cantidad;
                    controllers.Guardar(temp);
                }

                db.Ventas.Add(ventas);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Modificar(Ventas ventas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            ProductosControllers controllers = new ProductosControllers();

            try
            {
                Ventas anterior = Buscar(ventas.VentaId);

                foreach (var item in ventas.VentasDetalles)
                {
                    Productos temp = controllers.Buscar(item.ProductoId);
                    temp.Cantidad += item.Cantidad;
                    controllers.Guardar(temp);
                }

                foreach (var item in ventas.VentasDetalles)
                {
                    if (item.Id == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                }

                foreach (var item in anterior.VentasDetalles)
                {
                    if (!ventas.VentasDetalles.Any(A => A.Id == A.Id))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in ventas.VentasDetalles)
                {
                    Productos temp = controllers.Buscar(item.ProductoId);
                    temp.Cantidad -= item.Cantidad;
                    controllers.Guardar(temp);
                }

                db.Entry(ventas).State = EntityState.Modified;
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
            ProductosControllers controllers = new ProductosControllers();

            try
            {
                Ventas ventas = db.Ventas.Find(id);
                if (ventas != null)
                {

                    foreach (var item in ventas.VentasDetalles)
                    {
                        Productos temp = controllers.Buscar(item.ProductoId);
                        temp.Cantidad += item.Cantidad;
                        controllers.Guardar(temp);
                    }

                    db.Entry(ventas).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Ventas Buscar(int id)
        {
            Ventas ventas = new Ventas();
            Contexto db = new Contexto();
            try
            {
                ventas = db.Ventas.Where(C => C.VentaId == id).Include(D => D.VentasDetalles).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return ventas;
        }

        public List<Ventas> GetList(Expression<Func<Ventas, bool>> expression)
        {
            List<Ventas> lista = new List<Ventas>();
            Contexto db = new Contexto();
            try
            {
                lista = db.Ventas.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

    }
}
