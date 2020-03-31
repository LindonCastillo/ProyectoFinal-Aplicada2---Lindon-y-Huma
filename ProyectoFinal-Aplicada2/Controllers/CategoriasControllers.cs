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
    public class CategoriasControllers
    {
        public bool Guardar(Categorias categorias)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Categorias.Any(A => A.CategoriaId == categorias.CategoriaId))
                {
                    paso = Modificar(categorias);
                }
                else
                {
                    paso = Insertar(categorias);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        private bool Insertar(Categorias categorias)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Categorias.Add(categorias);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        private bool Modificar(Categorias categorias)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(categorias).State = EntityState.Modified;
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
                Categorias categorias = db.Categorias.Find(id);
                if (categorias != null)
                {
                    db.Entry(categorias).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Categorias Buscar(int id)
        {
            Categorias categorias;
            Contexto db = new Contexto();
            try
            {
                categorias = db.Categorias.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return categorias;
        }

        public List<Categorias> GetList(Expression<Func<Categorias, bool>> expression)
        {
            Contexto db = new Contexto();
            List<Categorias> lista = new List<Categorias>();
            try
            {

                double conteo = lista.Count();
                lista = db.Categorias.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}
