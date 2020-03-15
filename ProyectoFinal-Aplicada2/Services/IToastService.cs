using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Services
{
    public interface IToastService
    {
        event Action<ToastLevel, string, string> onShow;
        void shoInfo(string mensaje, string hearing="");

        void shoSuccess(string mensaje, string hearing = "");

        void shoWaring(string mensaje, string hearing = "");

        void showError(string mensaje, string hearing = "");
        void showToast(ToastLevel toastLevel,string mensaje, string hearing = "");
    }
}
