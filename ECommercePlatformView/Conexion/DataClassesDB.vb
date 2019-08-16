Imports CADsisVenta
Friend Class DataContext
    Inherits DataClassesDBDataContext
    Sub New()
        MyBase.Connection.ConnectionString = SimpleDataApp.Utility.GetConnectionString()
    End Sub

End Class
