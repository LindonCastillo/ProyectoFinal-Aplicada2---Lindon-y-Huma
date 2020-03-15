using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class PagosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PagoId { get; set; }
        public int CompraId { get; set; }
        public string TipoPago { get; set; }
        public decimal Pago { get; set; }

        public PagosDetalle()
        {
            Id = 0;
            PagoId = 0;
            CompraId = 0;
            TipoPago = string.Empty;
            Pago = 0;
        }

    }
}
