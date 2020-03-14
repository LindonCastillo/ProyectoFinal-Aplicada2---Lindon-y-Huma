using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Compras
    {
        [Key]
        [Required(ErrorMessage ="El campo Id debe ser un numero")]
        [Range(0,100000000,ErrorMessage ="El campo Id no puede ser menor que cero")]
        public int ComprasId { get; set; }
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage ="El campo fecha no puede estar vacio")]
        public DateTime FechaCompra { get; set; }
        [Required(ErrorMessage ="El campo ProveedorId debe ser un numero")]
        [Range(1,1000000000,ErrorMessage ="El campo ProveedorId debe ser mayor que cero")]
        public int ProveedorId { get; set; }
        
        public decimal Itebis { get; set; }
        public decimal Total { get; set; }
        public decimal Balance { get; set; }

        public Compras()
        {
            ComprasId = 0;
            FechaCompra = DateTime.Now;
            ProveedorId = 0;
            Itebis = 0;
            Total = 0;
            Balance = 0;
        }
    }
}
