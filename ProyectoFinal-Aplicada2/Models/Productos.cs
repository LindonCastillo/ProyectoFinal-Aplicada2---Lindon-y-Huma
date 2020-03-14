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
        public int ProductoId { get; set; }
        [DataType(DataType.Date,ErrorMessage ="El campo debe ser una fecha")]
        [Required(ErrorMessage ="El campo fecha no puede estar vacio")]
        public DateTime FechaEntrada { get; set; }
        [Required(ErrorMessage ="El nombre no puede estar vacio")]
        [MinLength(2, ErrorMessage ="El Nombre muy corto")]
        [MaxLength(50,ErrorMessage ="Nombre muy largo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="La cantidad debe ser un numero")]
        [Range(0,100000000,ErrorMessage ="El La cantidad de productos no puede menor que cero")]
        public int CantidadProductos { get; set; }
        [Required(ErrorMessage ="El precio debe ser un numero")]
        [Range(1, 10000000000000000000,ErrorMessage ="El precio debe ser mayor que cero")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage ="Porcentaje ganancias debe ser un numero ")]
        [Range(1, 10000000000000000000,ErrorMessage ="El porcentaje de gananacias debe ser un numero")]
        public decimal PorcentajeGanancias { get; set; }
        [Required(ErrorMessage ="Precio ventas debe ser un numero")]
        [Range(1, 10000000000000000000,ErrorMessage ="El precio de venta no puede ser mayor que cero")]
        public decimal PrecioVentas { get; set; }

        public Productos()
        {
            ProductoId = 0;
            FechaEntrada = DateTime.Now;
            Nombre = string.Empty;
            CantidadProductos = 0;
            Precio = 0;
            PorcentajeGanancias = 0;
            PrecioVentas = 0;
        }

    }
}
