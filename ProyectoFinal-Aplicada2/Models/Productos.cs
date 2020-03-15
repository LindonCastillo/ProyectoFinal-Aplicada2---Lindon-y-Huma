using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Productos
    {
        [Key]
        [Range(0,1000000000,ErrorMessage ="El campo Id no puede ser menor que cero")]
        [Required(ErrorMessage ="El campo Id debe ser un numero")]
        public int ProductoId { get; set; }
        [DataType(DataType.Date,ErrorMessage ="El campo debe ser una fecha")]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío")]
        public DateTime FechaEntrada { get; set; }
        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        [MinLength(2, ErrorMessage ="El Nombre muy corto")]
        [MaxLength(50,ErrorMessage ="Nombre muy largo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="La cantidad debe ser un numero")]
        [Range(0,100000000,ErrorMessage ="El La cantidad de productos no puede menor que cero")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage ="El precio debe ser un numero")]
        [Range(1, 10000000000000000000,ErrorMessage ="El precio debe ser mayor que cero")]
        public decimal PrecioCompra { get; set; }
        [Required(ErrorMessage ="Porcentaje ganancias debe ser un numero ")]
        [Range(1, 10000000000000000000,ErrorMessage ="El porcentaje de gananacias debe ser un numero")]
        public decimal PorcentajeGanancias { get; set; }
       
        public decimal PrecioVentas { get; set; }

        public Productos()
        {
            ProductoId = 0;
            FechaEntrada = DateTime.Now;
            Nombre = string.Empty;
            Cantidad = 0;
            PrecioCompra = 0;
            PorcentajeGanancias = 0;
            PrecioVentas = 0;
        }

    }
}
