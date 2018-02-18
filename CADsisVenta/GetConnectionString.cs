using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADsisVenta
{
    public static class GetConnectionStringCadSysytem
    {
      public static string DefaultStringSCadSysytem()
        {
            return  global::CADsisVenta.Properties.Settings.Default.JsofConneccionString;
        }
        
    }
}
