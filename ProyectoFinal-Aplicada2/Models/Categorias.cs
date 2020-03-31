using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Models
{
    public class Categorias
    {
        [Key]
        [Range(0, 1000000000, ErrorMessage = "El campo Id no puede ser menor que cero")]
        [Required(ErrorMessage = "El campo Id debe ser un numero")]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "El nombre de categoría no puede estar vacío")]
        [MinLength(2, ErrorMessage = "El nombre de categoría muy corto")]
        [MaxLength(30, ErrorMessage = "Nombre de categoría muy largo")]
        public string NombreCategoria { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            NombreCategoria = string.Empty;
        }
    }
}
