using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Services
{
    public class ToastService : IToastService
    {
        public ToastService() { }
       public event Action<ToastLevel, string, string> onShow;

        public void shoInfo(string mensaje, string hearing = "")
        {
            showToast(toastLevel.Error, mensaje, hearing);
        }

        public void shoSuccess(string mensaje, string hearing = "")
        {
            throw new NotImplementedException();
        }

        public void shoWaring(string mensaje, string hearing = "")
        {
            throw new NotImplementedException();
        }

        public void showError(string mensaje, string hearing = "")
        {
            throw new NotImplementedException();
        }

        public void showToast(ToastLevel toastLevel, string mensaje, string hearing = "")
        {
            throw new NotImplementedException();
        }
    }
}
