using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoFinal_Aplicada2.Models;
using ProyectoFinal_Aplicada2.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ProyectoFinal_Aplicada2.Controllers
{
    public class ClientesControllers
    {

        public bool Guardar(Clientes clientes)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if(contexto.Clientes.Any(A=>A.ClienteId == clientes.ClienteId))
                {
                    paso = Modificar(clientes);
                } else
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
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Clientes.Add(clientes);
                paso = contexto.SaveChanges() > 0;
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
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(clientes).State = EntityState.Modified;
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
                Clientes clientes = contexto.Clientes.Find(id);
                if(clientes!=null)
                {
                    contexto.Entry(contexto).State = EntityState.Deleted;
                    paso = contexto.SaveChanges() > 0;
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
            Clientes clientes = new Clientes();
            Contexto contexto = new Contexto();
            try
            {
                clientes = contexto.Clientes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return clientes;
        }

        public List<Clientes> GetList(Expression<Func<Clientes,bool>> expression)
        {
            List<Clientes> lista = new List<Clientes>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Clientes.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
