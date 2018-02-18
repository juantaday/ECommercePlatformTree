using CADsisVenta.DataSetPersonTableAdapters;
namespace CADsisVenta
{
    public class ClsPerson
    {
        private static PersonasTableAdapter Person_TableAdapter = new PersonasTableAdapter();
        private static PersonaSectorTableAdapter PersonSector_TableAdapter = new PersonaSectorTableAdapter();
        private static PersonaBySectorTableAdapter personaBySector_TableAdapter = new PersonaBySectorTableAdapter();
        public static int  InsertPerson(string apellidos, string nombre, string Ruc_Ci, string Direccion, string telefono, string mail,
            global::System.Nullable<global::System.DateTime> fech_Naci, bool genero, string nota, byte[] foto,
           string telef_casa, string telef_ofic, byte TypePerson)
        {
            return (int)Person_TableAdapter.InsertPerson(apellidos, nombre, Ruc_Ci, Direccion, telefono, mail, fech_Naci,
                genero, nota, foto, telef_casa, telef_ofic, TypePerson);
            
        }
        public static bool UpdatePerson(int idPerson_Original, string apellidos, string nombre, string Ruc_Ci, string Direccion, string telefono, 
            string mail, global::System.Nullable<global::System.DateTime> fech_Naci, bool genero,
            string nota, byte[] foto, string telef_casa, string telef_ofic, byte TypePerson)
        {
            var _respone =Person_TableAdapter.UpdatePerson(apellidos, nombre, Ruc_Ci, Direccion, telefono, mail,
                fech_Naci, genero, nota, foto, telef_casa, telef_ofic, idPerson_Original, TypePerson);
            if (_respone==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int DeletePerson(int idPerson_Original)
        {
            return Person_TableAdapter.DeletePerson(idPerson_Original);
        }
        public static int UpdatePersonZona(int idPerson, int idSector)
        {
            int? idSec = (int)personaBySector_TableAdapter.ScalarIdSectorByIdPersona(idPerson);
            if (idSec > 0)
            {
                return PersonSector_TableAdapter.UpdatePersonSector(idSector, idPerson);
            }
            else
            {
                return PersonSector_TableAdapter.InsertPersonSector(idPerson, idSector);
            }
        }
        public static int getPersonIdSector(int idPerson)
        {
            int? idSec = (int)personaBySector_TableAdapter.ScalarIdSectorByIdPersona(idPerson);
            if (idSec > 0)
            {
                return (int)idSec;
            }
            else
            {
                return 0;
            }
        }
        public static CADsisVenta.DataSetPerson.PersonasDataTable getDataLikePerson(string Param1, string Param2, string Param3)
        {
            return Person_TableAdapter.GetDataLikePerson(Param1, Param2, Param3);
        }
        public static bool IsPersonRegister(string textConsult)
        {
            int? idSec = (int)Person_TableAdapter.ScalarIsPersonRegister(textConsult);
            if (idSec == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
