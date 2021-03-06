﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ProyectoFinal_Aplicada2.Data;
using ProyectoFinal_Aplicada2.Models;
using System.Threading.Tasks;
using ProyectoFinal_Aplicada2.Paginando;

namespace ProyectoFinal_Aplicada2.Controllers
{
    public class ComprasControllers
    {

        public bool Guardar(Compras compras)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if(db.Compras.Any(A=>A.CompraId == compras.CompraId))
                {
                    paso = Modificar(compras);
                } else
                {
                    paso = Insertar(compras);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        private bool Insertar(Compras compras)
        {
            bool paso = false;
            Contexto db = new Contexto();
            ProductosControllers controllers = new ProductosControllers();
            try
            {
                foreach (var item in compras.ComprasDetalles)
                {
                    Productos temp = controllers.Buscar(item.ProductoId);
                    temp.Cantidad += item.Cantidad;
                    controllers.Guardar(temp);
                }

                db.Compras.Add(compras);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        private bool Modificar(Compras compras)
        {
            bool paso = false;
            Contexto db = new Contexto();
            ProductosControllers controllers = new ProductosControllers();

            try
            {
                var anterior = Buscar(compras.CompraId);

                foreach (var item in anterior.ComprasDetalles)
                {
                    var temp = controllers.Buscar(item.ProductoId);
                    temp.Cantidad -= item.Cantidad;
                    controllers.Guardar(temp);
                }

                foreach (var item in compras.ComprasDetalles)
                {

                    if (item.Id == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                }

                foreach (var item in anterior.ComprasDetalles)
                {
                    if(!compras.ComprasDetalles.Any(A=>A.Id == item.Id))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                db.Entry(compras).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

                //Modificar los productos cuando se modifique la compra;
                foreach (var item in compras.ComprasDetalles)
                {
                    var temp = controllers.Buscar(item.ProductoId);
                    temp.Cantidad += item.Cantidad;
                    controllers.Guardar(temp);
                }
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
                var compras = Buscar(id);

                if(compras != null)
                {
                    foreach (var item in compras.ComprasDetalles)
                    {
                        var temp = controllers.Buscar(item.ProductoId);
                        temp.Cantidad -= item.Cantidad;
                        controllers.Guardar(temp);
                    }

                    db.Entry(compras).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Compras Buscar(int id)
        {
            Compras compras = new Compras();
            Contexto db = new Contexto();
            try
            {
                compras = db.Compras.Where(C => C.CompraId == id).Include(D => D.ComprasDetalles).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            return compras;
        }


        public List<Compras> GetList(Expression<Func<Compras,bool>> expression)
        {
            List<Compras> lista = new List<Compras>();
            Contexto db = new Contexto();
            try
            {
                lista = db.Compras.Where(expression).Include(A => A.ComprasDetalles).ToList();              
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    public Compras SoloCompra(int id)
        {
            Compras compras = new Compras();
            Contexto contexto = new Contexto();
            try
            {
                compras = contexto.Compras.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return compras;
        }

     

    }
}
