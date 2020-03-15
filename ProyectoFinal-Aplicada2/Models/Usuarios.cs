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
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "El Nombre Persona no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El Nombre Persona muy corto")]
        [MaxLength(50, ErrorMessage = "Nombre Persona muy largo")]
        public string NombrePersona { get; set; }
        [Required(ErrorMessage = "El Email Usuario no puede estar vacío")]
        public string EmailUsuario { get; set; }
        [Required(ErrorMessage = "El Clave no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El Clave muy corto")]
        [MaxLength(60, ErrorMessage = "Clave muy largo")]
        public string Clave { get; set; }
        [Required(ErrorMessage = "El ConfirmarClave no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El ConfirmarClave muy corto")]
        [MaxLength(60, ErrorMessage = "ConfirmarClave muy largo")]
        public string ConfirmarClave { get; set; }
        [Required(ErrorMessage = "El Nivel Usuario no puede estar vacío")]
        public string NivelUsuario { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío")]
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
