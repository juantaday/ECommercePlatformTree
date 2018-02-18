using CADsisVenta.DataSetComprasTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CADsisVenta
{
    public class ClsCompras
    {
        private static DeclaracionTableAdapter Declara_TableAdapter = new DeclaracionTableAdapter();
        private static ConsumoTableAdapter Consu_TableAdapter = new ConsumoTableAdapter();
        private static ProductoProveedorTableAdapter ProductoProveedor_TableAdapter = new ProductoProveedorTableAdapter();
        public static CADsisVenta.DataSetCompras.DeclaracionDataTable getTypeDeclara()
        {
            return Declara_TableAdapter.GetData();
        }
        public static CADsisVenta.DataSetCompras.ConsumoDataTable getTypeConsumo()
        {
            return Consu_TableAdapter.GetData();
        }
        public static int Scalar_idProdcutByProvider(int idPresentacion, int idProvider)
        {
            return (int)ProductoProveedor_TableAdapter.Scalar_IdProductoByProviderRegister(idPresentacion, idProvider);
        }

    }
}
