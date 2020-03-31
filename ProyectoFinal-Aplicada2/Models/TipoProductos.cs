using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_Aplicada2.Models
{
    public class TipoProductos
    {
        [Key]
        [Required(ErrorMessage ="El campo Id no puede estar vacío")]
        [Range(0,4000000000,ErrorMessage ="El campo Id no puede ser menor que cero")]
        public int TipoProductoId { get; set; }
        [Required(ErrorMessage ="El campo Categoría no puede estar vacío")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El Producto Seleccionado no puede estar vacío")]
        public string ProductoSeleccionado { get; set; }

        public TipoProductos()
        {
            TipoProductoId = 0;
            ProductoSeleccionado = string.Empty;
            Categoria = string.Empty;
        }
    }
}
