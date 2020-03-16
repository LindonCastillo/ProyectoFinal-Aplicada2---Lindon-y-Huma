using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Pagos
    {
        [Key]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        [Range(0, 100000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        public int PagoId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío")]
        public DateTime PagoFecha { get; set; } 
        public decimal PagoTotal { get; set; }

        [ForeignKey("PagoId")]
        public virtual List<PagosDetalle> PagosDetalles { get; set; }

        public Pagos()
        {
            PagoId = 0;
            PagoFecha = DateTime.Now;
            PagoTotal = 0;

            PagosDetalles = new List<PagosDetalle>();
        }
    }
}
