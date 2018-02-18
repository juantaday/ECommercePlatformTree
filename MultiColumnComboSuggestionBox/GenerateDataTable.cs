using System.Data;

namespace MultiColumnComboSuggestionBox
{
    internal class GenerateDataTable : DataTable
    {

        public GenerateDataTable(DataColumnCollection columns)
        {
            foreach (DataColumn item in columns)
            {
                this.Columns.Add(new DataColumn
                {
                    ColumnName = item.ColumnName,
                    DataType = item.DataType,
                    Caption = item.Caption,
                    Unique = item.Unique
                });
            }
       }
    }
}