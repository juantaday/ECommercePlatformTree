using CADsisVenta.DataSetClientesTableAdapters;
namespace CADsisVenta
{
    public class ClsClientes
    {
        private static ClienteNameTableAdapter Clientes_TableAdapter = new ClienteNameTableAdapter();
        private static ClientesTableAdapter Admin_TableAdapter = new ClientesTableAdapter();

        public static bool isAurotizeCredit(int idCliente)
        {
            return (bool)Clientes_TableAdapter.ScalarIsAutorizeCredit(idCliente);
        }
        public static int isClinteBypersonAdmin(int idPerson)
        {
            int isClient = (int)Admin_TableAdapter.ScalarIsClienteByPerson(idPerson);
            if (isClient != 0)
            {
                return (int)Admin_TableAdapter.ScalarReturnIdClienteByIdPersona(idPerson);
            }
            else
            {
                Admin_TableAdapter.InsertCliente(idPerson);
                return (int)Admin_TableAdapter.ScalarReturnIdClienteByIdPersona(idPerson);
            }
        }
    }
}
