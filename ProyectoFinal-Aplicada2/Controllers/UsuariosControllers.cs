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
    public class UsuariosControllers
    {
        public bool Guardar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Usuarios.Any(A => A.UsuarioId == usuarios.UsuarioId))
                {
                    paso = Modificar(usuarios);
                }
                else
                {
                    paso = Insertar(usuarios);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        private bool Insertar(Usuarios usuarios)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Usuarios.Add(usuarios);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        private bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(usuarios).State = EntityState.Modified;
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
                Usuarios usuarios = db.Usuarios.Find(id);
                if (usuarios != null)
                {
                    db.Entry(usuarios).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Usuarios Buscar(int id)
        {
            Usuarios usuarios;
            Contexto db = new Contexto();
            try
            {
                usuarios = db.Usuarios.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return usuarios;
        }

        public List<Usuarios> GetList(Expression<Func<Usuarios, bool>> expression)
        {
            Contexto db = new Contexto();
            List<Usuarios> lista = new List<Usuarios>();

            try
            {
                lista = db.Usuarios.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public bool VerificarExistenciaYClaveDelUsuario(string NombreUsuario, string clave)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(contexto.Usuarios.Any(A=>A.NombreUsuario == NombreUsuario && A.Clave == clave))
                {
                    paso = true;

                }

                if(NombreUsuario == "Admin" && clave == "12345")
                {
                    paso = true;
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
