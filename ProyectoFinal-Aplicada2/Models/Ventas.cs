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
        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }

        [ForeignKey("VentaId")]
        public virtual List<VentasDetalle> VentasDetalles { get; set; }

        public Ventas()
        {
            VentaId = 0;
            FechaVenta = DateTime.Now;
            Total = 0;
        }
    }
}
