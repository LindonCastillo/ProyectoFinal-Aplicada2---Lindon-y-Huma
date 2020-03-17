using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using ProyectoFinal_Aplicada2.Paginacion;

namespace ProyectoFinal_Aplicada2.Pages
{
    public class PaginacionBase : ComponentBase
    {
        [Parameter]
        public PagedResultBase Result { get; set; }

        [Parameter]
        public Action<int> PageChanged { get; set; }

        protected int StartIndex { get; private set; } = 0;
        protected int FinishIndex { get; private set; } = 0;

        protected override void OnParametersSet()
        {
            StartIndex = Math.Max(Result.CurrentPage - 5, 1);
            FinishIndex = Math.Min(Result.CurrentPage + 5, Result.PageCount);

            base.OnParametersSet();
        }

        protected void PagerButtonClicked(int page)
        {
            PageChanged?.Invoke(page);
        }
    }
}

