using CADsisVenta.DataSetEmployeeTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CADsisVenta
{
    public class ClsEmployee
    {
        private static PersonasTableAdapter Person_TableAdapter = new PersonasTableAdapter();
        private static EmpleadosTableAdapter Employee_TableAdapter = new EmpleadosTableAdapter();
        private static EmpleadosTableAdapter EmployeeList_tap = new EmpleadosTableAdapter();

        public static int DeleteEmployeeAll(int idEmployee_Original)
        {

            DataSetEmployee.EmpleadosDataTable mytable = new DataSetEmployee.EmpleadosDataTable();
            EmployeeList_tap.FillBy(mytable, idEmployee_Original);
            int _idperson = 0;
            if (mytable.Rows.Count != 0)
            {
                _idperson = mytable[0].idPersona;
            }
            try
            {
                if (_idperson > 0)
                {
                    return -1;
                }
               
               Employee_TableAdapter.DeleteEmployee(idEmployee_Original);
               Person_TableAdapter.DeletePeople(_idperson);
                return 1;
            }
            finally
            {
                mytable.Clear();
            }
        }
        public static int DeleteEmployeeId(int idEmployee_Original)
        {
            DataSetEmployee.EmpleadosDataTable mytable = new DataSetEmployee.EmpleadosDataTable();
            EmployeeList_tap.FillBy(mytable, idEmployee_Original);
            int _idperson = 0;
            if (mytable.Rows.Count != 0)
            {
                _idperson = mytable[0].idPersona;
            }
            try
            {
                if (_idperson > 0)
                {
                    return -1;
                }
                Employee_TableAdapter.DeleteEmployee(idEmployee_Original);
                return 1;
            }
            finally
            {
                mytable.Clear();
            }
        }

    }
}
