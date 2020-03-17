using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Helpers
{
    public static class HttpContexExtensions
    {
        public static async Task InsertarParametrosPaginacionRespuesta<T>(this HttpContext contex, IQueryable<T> queryble, 
            int CantidadResgistrosMostrar)
        {
            if(contex == null)
            {
                throw new ArgumentNullException(nameof(contex));
            }

            double conteo = await queryble.CountAsync();
            double totaldepagina = Math.Ceiling(conteo / CantidadResgistrosMostrar);
            contex.Response.Headers.Add("TotalPaginas", totaldepagina.ToString());
        }
    }
}