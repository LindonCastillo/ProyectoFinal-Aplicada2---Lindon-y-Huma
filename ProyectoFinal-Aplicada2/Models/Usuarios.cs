using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string NombrePersona { get; set; }
        public string EmailUsuario { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
        public string NivelUsuario { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            NombrePersona = string.Empty;
            EmailUsuario = string.Empty;
            Clave = string.Empty;
            ConfirmarClave = string.Empty;
            NivelUsuario = string.Empty;
            FechaIngreso = DateTime.Now;
        }
    }
}
