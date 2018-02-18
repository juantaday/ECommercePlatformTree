using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CADsisVenta.DataSetSystemTableAdapters;
using CADsisVenta.DataSetMonedasTableAdapters;

namespace CADsisVenta
{
   public class ClsCajaBancos { 
        private static CajasTableAdapter Caja_Adapter = new CajasTableAdapter();
        private static SaldoCajaTableAdapter SaldoCaja_Adap = new SaldoCajaTableAdapter();

        public static CADsisVenta.DataSetMonedas.SaldoCajaDataTable SaldoCajaSuspen(string codTerminal)
        {
            object Scalar = (Caja_Adapter.idCajaStadoInhniviByCod(codTerminal));
            if (Scalar == null)
            {
                return new CADsisVenta.DataSetMonedas.SaldoCajaDataTable();
            }
            int idCajaStado = (int)(Scalar);
            if (idCajaStado != 0)
            {
                return SaldoCaja_Adap.GetData((int)idCajaStado);
            }
            return new CADsisVenta.DataSetMonedas.SaldoCajaDataTable();
        }
        public static CADsisVenta.DataSetMonedas.SaldoCajaDataTable SaldoCajaOpen(string codTerminal)
        {
            object Scalar = Caja_Adapter.idCajaStadoOpenByCod(codTerminal);
            if (Scalar  == null)
            {
                return new CADsisVenta.DataSetMonedas.SaldoCajaDataTable();
            }
            int idCajaStado = (int)(Scalar);
            if (idCajaStado != 0)
            {
                return SaldoCaja_Adap.GetData((int)idCajaStado);
            }
            return new CADsisVenta.DataSetMonedas.SaldoCajaDataTable();
        }

    }
}
