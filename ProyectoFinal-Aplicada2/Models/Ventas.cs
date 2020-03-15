using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Ventas
    {
        [Key]
        [Required(ErrorMessage = "El VentaId debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int VentaId { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío")]
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("VentaId")]
        public virtual List<VentasDetalle> VentasDetalles { get; set; }

        public Ventas()
        {
            VentaId = 0;
            FechaVenta = DateTime.Now;
            Total = 0;
            VentasDetalles = new List<VentasDetalle>();
        }
    }
}
