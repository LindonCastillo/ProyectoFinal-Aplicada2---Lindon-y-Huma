using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Clientes
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío")]
        [Range(0, 10000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int ClienteId { get; set; }
        [Required(ErrorMessage ="El campo Nombres no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El nombre debe tener por lo menos 2 caracteres")]
        [MaxLength(50, ErrorMessage = "Nombre muy largo")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El campo Apellidos no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El apellido debe tener por lo menos 2 caracteres")]
        [MaxLength(50, ErrorMessage = "Apellido muy largo")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El campo Número no puede estar vacío")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Por favor ingrese un No. de teléfono válido")]
        [MaxLength(10, ErrorMessage = "El campo Numero no tiene más de diez dígitos")]
        public string Numero { get; set; }
       
        [Required(ErrorMessage ="El campo dirección no puede estar vacío")]
        [MinLength(3,ErrorMessage =  "Dirección muy corta")]
        [MaxLength(100,ErrorMessage = "Dirección muy larga")]
        public string Direccion { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Numero = string.Empty;
            Direccion = string.Empty;
        }
    }
}
