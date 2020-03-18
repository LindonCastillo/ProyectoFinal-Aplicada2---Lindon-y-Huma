using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Proveedores
    {
        [Key]
        [Range(0, 1000000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        public int ProveedoresId { get; set; }
        [Required(ErrorMessage ="El nombre del proovedor no puede estar vacío")]
        [MaxLength(30,ErrorMessage ="Nombre muy largo")]
        public string NombreProveedor { get; set; }

        [Required(ErrorMessage = "El campo telefono no puede estar vacío")]
        [MaxLength(10,ErrorMessage ="El campo telefono no tiene mas de diez digitos")]
        [MinLength(10,ErrorMessage ="El campo telefono no puede tener menos de diez digitos")]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Por favor ingrese un No. de telefono valido")]

        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo RNC no puede estar vacío")]
        [MaxLength(9,ErrorMessage ="El RNC no puede pasar de 9 digitos")]
        [MinLength(9,ErrorMessage ="El RNC no puede ser menor que 9 digitos")]
        public string RNC { get; set; }

        [Required(ErrorMessage = "El campo Tipo de negocio no puede estar vacío")]
        public string TipoNegocio { get; set; }
        [Required(ErrorMessage = "El campo direcciones no puede estar vacío")]
        [MinLength(4,ErrorMessage ="EL campo direcciones es muy corto")]
        [MaxLength(80, ErrorMessage ="EL campo direcciones es muy corto")]
        public string Direcciones { get; set; }

        [Required(ErrorMessage = "El campo tipo moneda no puede estar vacío")]
        public string TipoMoneda { get; set; }

        public Proveedores()
        {
            ProveedoresId = 0;
            NombreProveedor = string.Empty;
            Telefono = string.Empty;
            RNC = string.Empty;
            Direcciones = string.Empty;
            TipoMoneda = string.Empty;
            TipoNegocio = string.Empty;

        }
    }
}
