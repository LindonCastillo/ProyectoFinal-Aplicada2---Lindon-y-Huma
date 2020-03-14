﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ProyectoFinal_Aplicada2.Data;
using ProyectoFinal_Aplicada2.Models;
using System.Threading.Tasks;

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
                if(db.Compras.Any(A=>A.ComprasId == compras.ComprasId))
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
            try
            {
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
            try
            {
                Compras anterior = Buscar(compras.ComprasId);

                foreach (var item in compras.ComprasDetalles)
                {
                    if(item.Id == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                }

                foreach (var item in anterior.ComprasDetalles)
                {
                    if(!compras.ComprasDetalles.Any(A=>A.Id == A.Id))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }



                db.Entry(compras).State = EntityState.Modified;
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
                Compras compras = db.Compras.Find(id);
                if(compras!=null)
                {
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
                compras = db.Compras.Where(C => C.ComprasId == id).Include(D => D.ComprasDetalles).FirstOrDefault();
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
                lista = db.Compras.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

    }
}