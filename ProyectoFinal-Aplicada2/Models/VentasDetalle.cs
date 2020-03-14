using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class VentasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta  { get; set; }
        public decimal SubTotal { get; set; }

        public VentasDetalle()
        {
            Id = 0;
            VentaId = 0;
            ProductoId = 0;
            Nombre = string.Empty;
            Cantidad = 0;
            PrecioVenta = 0;
            SubTotal = 0;
        }
    }
}
