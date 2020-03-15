using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Config
{
    public interface ToastInstance
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int MyProperty { get; set; }
        public ToastSetting ToastSetting { get; set; }
    }
}
