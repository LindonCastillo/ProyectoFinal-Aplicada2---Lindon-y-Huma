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
    public class ClientesControllers
    {
        public bool Guardar(Clientes clientes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Clientes.Any(A => A.ClientesId == clientes.ClientesId))
                {
                    paso = Modificar(clientes);
                }
                else
                {
                    paso = Insertar(clientes);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        private bool Insertar(Clientes clientes)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Clientes.Add(clientes);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        private bool Modificar(Clientes clientes)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(clientes).State = EntityState.Modified;
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
                Clientes clientes = db.Clientes.Find(id);
                if (clientes != null)
                {
                    db.Entry(clientes).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Clientes Buscar(int id)
        {
            Clientes cliente;
            Contexto db = new Contexto();
            try
            {
                cliente = db.Clientes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return cliente;
        }

        public List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            Contexto db = new Contexto();
            List<Clientes> lista = new List<Clientes>();
            try
            {
                double conteo = lista.Count();
                lista = db.Clientes.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}
