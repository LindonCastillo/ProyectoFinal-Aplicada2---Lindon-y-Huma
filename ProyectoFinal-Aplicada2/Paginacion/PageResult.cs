using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Paginacion
{
    public class PageResult<T> : PagedResultBase where T: class
    {
        public IList<T> Results { get; set; }

        public PageResult()
        {
            Results = new List<T>();
        }
    }
}
