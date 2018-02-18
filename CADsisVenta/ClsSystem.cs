using CADsisVenta.DataSetSystemTableAdapters;
using static CADsisVenta.DataSetSystem;

namespace CADsisVenta
{
    public class ClsSystem
    {
        private static LocationTableAdapter tadt_Location = new LocationTableAdapter();
        private static EquiposTableAdapter tadt_Equipos = new EquiposTableAdapter(); //LocationTableAdapter
        private static CajaStadoTableAdapter tadt_CajaStado = new CajaStadoTableAdapter();
        private static TerminalTableAdapter tadt_Terminal = new TerminalTableAdapter();
        private static TerminalDataTable data_Terminal = new TerminalDataTable();
        public static bool insertEquipoDeault(string domicio, string ip, string description)
      {
        //bloque en la valida la descripcion de equipos anónimos
        string des_location = "Equipos anónimos";
        CADsisVenta.DataSetSystem.LocationDataTable dt_Locatio = new DataSetSystem.LocationDataTable();
        dt_Locatio = tadt_Location.GetDataByDes_location(des_location);
        int idLocation =0;
        if (dt_Locatio.Rows.Count > 0)
        {
            idLocation = dt_Locatio[0].idLocation;
        }
        else
        {
            tadt_Location.Insert(des_location, "...");
            dt_Locatio = tadt_Location.GetDataByDes_location(des_location);
            if (dt_Locatio.Rows.Count > 0)
            {
                idLocation = dt_Locatio[0].idLocation;
            }
            else
            {
                return false;
            }
        }
            //fi de de este bloque
          // bloque que agrega datos

        if ((int)(tadt_Equipos.InsertEquipoDefault(domicio, ip, description, idLocation)) != 0)
        {
            return true;
        }
        else
        {
            return false;
        }

       }
        public static bool updateEquipos(int idOrigynal_Equipo, string dominio, string ip, string description)
        {
            if ((int)(tadt_Equipos.UpdateEquipo(dominio, ip, description,idOrigynal_Equipo)) != 0)
            { return true; }
            else
            { return false;}
        }
        //si estre registrado el equipo
        public static bool isRegisterEquipo(string dominio)
        {
            int? id  = (int)(tadt_Equipos._IsRegisterEquipo(dominio));
            if (id !=0)
            { return true; }
            else
            { return false; }
        }
        public static bool isRegisterInTerminal(string dominio)
        {
            var  id = (tadt_Terminal.isRegisterInTerminal(dominio));
            if (id != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static TerminalDataTable GetTerminalDataByDominio(string dominio)
        {
           return tadt_Terminal.GetDataByDominio(dominio);
        }
        public static int GetIdTerminal(string dominio)
        {
            int? id = (int)(tadt_Terminal.isRegisterInTerminal(dominio));
            if (id != 0)
            {
                return  (int)tadt_Terminal.ScalarGetIdTerminal(dominio);
            }
            else
            {
                return 0;
            }
        }
    }
}
