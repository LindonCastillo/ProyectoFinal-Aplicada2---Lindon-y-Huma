using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Clientes
    {
        [Key]
        [Range(0, 1000000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        public int ClientesId { get; set; }
        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El nombre es muy corto")]
        [MaxLength(40, ErrorMessage = "Nombre muy largo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El apellido es muy corto")]
        [MaxLength(40, ErrorMessage = "Apellido muy largo")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo dirección no puede estar vacío")]
        [MinLength(4, ErrorMessage = "El campo dirección es muy corto")]
        [MaxLength(60, ErrorMessage = "El campo dirección es muy corto")]
        public string Dirreccion { get; set; }

        [Required(ErrorMessage = "El campo Número no puede estar vacío")]
        [MaxLength(10, ErrorMessage = "El campo Número no tiene mas de diez digitos")]
        [MinLength(10, ErrorMessage = "El campo Número no puede tener menos de diez digitos")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Por favor ingrese un Número de contacto valido")]
        public string Numero { get; set; }

        public Clientes()
        {
            ClientesId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty; 
            Numero = string.Empty;
            Dirreccion = string.Empty;
        }
    }
}
