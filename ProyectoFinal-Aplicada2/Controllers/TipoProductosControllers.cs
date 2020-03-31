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
    public class TipoProductosControllers
    {
        public bool Guardar(TipoProductos tipo)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (contexto.TipoProductos.Any(A => A.TipoProductoId == tipo.TipoProductoId))
                {
                    paso = Modificar(tipo);
                }
                else
                {
                    paso = Insertar(tipo);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        private bool Insertar(TipoProductos tipo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.TipoProductos.Add(tipo);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Modificar(TipoProductos tipo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(tipo).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
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
            Contexto contexto = new Contexto();
            try
            {
                TipoProductos tipo = contexto.TipoProductos.Find(id);
                if(tipo!=null)
                {
                    contexto.Entry(tipo).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
                }
              
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public TipoProductos Buscar(int id)
        {
            TipoProductos tipo = new TipoProductos();
            Contexto contexto = new Contexto();
            try
            {
                tipo = contexto.TipoProductos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return tipo;
        }

        public List<TipoProductos> GetList(Expression<Func<TipoProductos, bool>> expression)
        {
            List<TipoProductos> lista = new List<TipoProductos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.TipoProductos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }


    }
}
