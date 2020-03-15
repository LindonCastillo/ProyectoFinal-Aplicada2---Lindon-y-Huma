using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal_Aplicada2.Config
{
    public class ToastSetting
    {

        public string Heading { get; set; }
        public string Message { get; set; }
        public string  BaseClass { get; set; }

        public string AditionalClass { get; set; }
        public string IconClass { get; set; }

        public ToastSetting(string heading, string message, string baseclass, string aditionalclass,string iconclass)
        {
            Heading = heading;
            Message = message;
            BaseClass = baseclass;
            AditionalClass = aditionalclass;
            IconClass = iconclass;
        }

    }
}
