Imports System.Data.SqlClient

Public Class ClassCargadorProducto
    Public Sub New()
    End Sub
    Public Function ExecuteComand(ByVal sqlStri As String) As Boolean
        Try
            If conecta_sql() Then
                Using cmd As New SqlCommand(sqlStri, Cnn_sql)
                    cmd.CommandType = CommandType.Text
                    If cmd.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message + "en le ExecuteComand del ", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function RetornaTabla(ByVal sqlStri As String) As DataTable
        Try
            If conecta_sql() Then
                Using cmd As New SqlCommand(sqlStri, Cnn_sql)
                    cmd.CommandType = CommandType.Text
                    Dim dat As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    dat.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Return dt
                    Else
                        Return Nothing
                    End If
                End Using
            End If
            Return Nothing
        Catch ex As Exception
            MsgBox(ex.Message + "en le RetornaTabla del ", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

End Class


Public Class ListViewColumnSort
    Implements IComparer
    '
    Public Enum TipoCompare
        Cadena
        Numero
        Fecha
    End Enum
    Public CompararPor As TipoCompare
    Public ColumnIndex As Integer = 0
    Public Sorting As SortOrder = SortOrder.Ascending
    '
    ' Constructores
    Sub New()
        ' no es necesario indicar nada,
        ' ya que implícitamente se llama a MyBase.New
    End Sub
    Sub New(ByVal columna As Integer)
        ColumnIndex = columna
    End Sub
    '
    Public Overridable Function Compare(ByVal a As Object, _
                                        ByVal b As Object) As Integer _
                                        Implements IComparer.Compare
        '
        ' Esta función devolverá:
        '   -1 si el primer elemento es menor que el segundo
        '    0 si los dos son iguales
        '    1 si el primero es mayor que el segundo
        '


        Dim menor As Integer = -1, mayor As Integer = 1
        Dim s1, s2 As String
        '
        If Sorting = SortOrder.Unspecified Then
            Return 0
        End If
        '
        ' Convertir el texto en el formato adecuado
        ' y tomar el texto de la columna en la que se ha pulsado
        s1 = DirectCast(a, ListViewItem).SubItems(ColumnIndex).Text
        s2 = DirectCast(b, ListViewItem).SubItems(ColumnIndex).Text
        '
        ' Asignar cuando es menor o mayor,
        ' dependiendo del orden de clasificación
        If Sorting = SortOrder.Descending Then
            menor = 1
            mayor = -1
        End If
        '
        Select Case CompararPor
            Case TipoCompare.Fecha
                ' Si da error, se comparan como cadenas
                Try
                    Dim f1 As Date = DateTime.Parse(s1)
                    Dim f2 As Date = DateTime.Parse(s2)
                    If f1 < f2 Then
                        Return menor
                    ElseIf f1 = f2 Then
                        Return 0
                    Else
                        Return mayor
                    End If
                Catch
                    'Return s1.CompareTo(s2) * mayor
                    Return System.String.Compare(s1, s2, True) * mayor
                End Try
            Case TipoCompare.Numero
                ' Si da error, se comparan como cadenas
                Try
                    Dim n1 As Decimal = Decimal.Parse(s1)
                    Dim n2 As Decimal = Decimal.Parse(s2)
                    If n1 < n2 Then
                        Return menor
                    ElseIf n1 = n2 Then
                        Return 0
                    Else
                        Return mayor
                    End If
                Catch
                    Return System.String.Compare(s1, s2, True) * mayor
                End Try
            Case Else
                'Case TipoCompare.Cadena
                Return System.String.Compare(s1, s2, True) * mayor
        End Select
    End Function
End Class
