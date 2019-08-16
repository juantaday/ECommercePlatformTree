using CADsisVenta.DataSetPersonTableAdapters;
using System.Data;
using System.Data.SqlClient;

namespace CADsisVenta
{
    public class ClsPerson
    {
        private static PersonasTableAdapter Person_TableAdapter = new PersonasTableAdapter();
        private static PersonaSectorTableAdapter PersonSector_TableAdapter = new PersonaSectorTableAdapter();
        private static PersonaBySectorTableAdapter personaBySector_TableAdapter = new PersonaBySectorTableAdapter();
        public static int  InsertPerson(string apellidos, string nombre, string Ruc_Ci, string Direccion,
            string telefono, string mail, global::System.Nullable<global::System.DateTime> fech_Naci, 
            bool genero, string nota, byte[] foto,
           string telef_casa, string telef_ofic, byte TypePerson)
        {
            using (SqlConnection cnn = new SqlConnection(Properties.Settings.Default.JsofConneccionString) ) {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand ("InsertPerson", cnn)) {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Ruc_Ci", Ruc_Ci);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@mail", mail);


                    if (fech_Naci.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@fech_Naci", fech_Naci);

                    }
                    else {
                        cmd.Parameters.AddWithValue("@fech_Naci", global::System.DBNull.Value);
                    }

                    cmd.Parameters.Add("@foto",sqlDbType:SqlDbType.Image);

                    if (foto ==null)
                    {
                        cmd.Parameters["@foto"].Value = global::System.DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters["@foto"].Value = ((byte[])(foto)); 
                    }


                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@nota", nota);
                    cmd.Parameters.AddWithValue("@telef_casa", telef_casa);
                    cmd.Parameters.AddWithValue("@telef_ofic", telef_ofic);
                    cmd.Parameters.AddWithValue("@TypePerson", TypePerson);

                    cmd.Parameters.Add("@idPersona",SqlDbType.Int);
                    cmd.Parameters["@idPersona"].Direction = ParameterDirection.Output;

                    object returnValue;
                    int? idPersona;
                    try
                    {
                        returnValue = cmd.ExecuteScalar();
                    }
                    finally
                    {
                        if ((cmd.Connection.State == global::System.Data.ConnectionState.Open))
                        {
                           cmd.Connection.Close();
                        }
                    }
                    if (((cmd.Parameters["@idPersona"].Value == null)
                                || (cmd.Parameters["@idPersona"].Value.GetType() == typeof(global::System.DBNull))))
                    {
                        idPersona = new global::System.Nullable<int>();
                    }
                    else
                    {
                        idPersona = new global::System.Nullable<int>(((int)(cmd.Parameters["@idPersona"].Value)));
                    }
                    return (int)idPersona;
                }

            }
               
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
