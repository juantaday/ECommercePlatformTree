Imports System.Data.SqlClient
Imports CADsisVenta
Imports CADsisVenta.ClsSystem
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters

Module PFunciones
    Public Function DecimalFromString(numnerTostring As String) As Double
        Try
            Dim texNumber As String = String.Empty
            For Each Text_ In numnerTostring
                If InStr("0123456789.", Text_) > 0 Then
                    texNumber += Text_
                End If
            Next
            Return Decimal.Parse(texNumber)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function
    Public Function Redondear(valorARedondear As Double, PosicionRedondeo As Integer, Optional roundOut As Boolean = True) As Double
        If roundOut Then
            Return Math.Round(valorARedondear, PosicionRedondeo, mode:=MidpointRounding.AwayFromZero)
        Else
            Return Math.Round(valorARedondear, PosicionRedondeo, mode:=MidpointRounding.ToEven)
        End If
    End Function
    Public Function isTerminalHabil(codUser As String, codTerminal As String) As ResponseTerminal
        Try
            Using atap As New CajaStadoTableAdapter
                Dim dt As New DataTable
                dt = atap.GetDataByHabilUserWithIdTerminal(codUser, TerminalActivo.idTerminal)
                If Not (dt.Rows.Count = 0) Then
                    Return New ResponseTerminal With {.Success = True,
                        .DataDb = dt,
                        .IdStadoCaja = dt.Rows(0)("idCajaStado"),
                        .IDterminal = dt.Rows(0)("idTerminal")}
                End If
                dt = atap.GetDataByHabilAllUserOnIdTerminal(TerminalActivo.idTerminal)
                If Not (dt.Rows.Count = 0) Then
                    Return New ResponseTerminal With {.Success = True,
                        .DataDb = dt,
                        .IdStadoCaja = dt.Rows(0)("idCajaStado"),
                        .IDterminal = dt.Rows(0)("idTerminal")}
                End If
                dt = Nothing
                sql = "Este terminal no tiene estado de operación activa." & vbNewLine
                sql = sql & "Solicítelo al administrador de terminales."
                MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                Return New ResponseTerminal With {.Success = False, .DataDb = Nothing}
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return New ResponseTerminal With {.Success = False, .DataDb = Nothing}
        End Try
    End Function
    Public Function Borra_SelectRowDataGrip(ByVal DataGrip As DataGridView) As Boolean
        Try
            For Each Grip In DataGrip.SelectedRows
                DataGrip.Rows(Grip.index).Selected = False
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro en ele Modulo: Funciones Funcion:Borra_SelectRowDataGrip")
            Return False
        End Try

    End Function

    Public Function ImpideOrdenamiento(ByVal dataGrid As DataGridView) As Boolean
        Try
            For i = 0 To dataGrid.Columns.Count - 1
                dataGrid.Columns.Item(i).SortMode = DataGridViewColumnSortMode.Programmatic
            Next i
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
    Public Function GenerateSpliter(myFindText As String, Optional isPreparatedStatement As Boolean = False) As ResponseSpliter
        Try
            Dim _responseSpliter As New ResponseSpliter
            'si no ha dada
            myFindText = Trim(myFindText)
            If myFindText.Length = 0 Or String.IsNullOrWhiteSpace(myFindText) Then
                _responseSpliter = New ResponseSpliter
            End If
            'preparamos el texto
            Dim isSpace As Boolean = False
            sql = ""
            For Each stri In myFindText
                If Not isSpace Then
                    sql += stri
                    isSpace = False
                End If
                If String.IsNullOrWhiteSpace(stri) Then
                    isSpace = True
                Else
                    If isSpace Then
                        sql += stri
                    End If
                    isSpace = False
                End If
            Next
            myFindText = sql

            'rebisamos si no es codigo munerico entonces es barra de codigo
            Dim isnumric As Boolean = True
            For Each texto In myFindText
                If InStr("0123456789", texto) = False Then
                    isnumric = False
                    Exit For
                End If
            Next
            If isnumric Then
                _responseSpliter = New ResponseSpliter With
                {
                .IsSucces = True,
                .IsNumeric = isnumric,
                .Spliter = myFindText.Split(" ")
                }
                GoTo Salida
            End If

            'para codigo de producto
            Dim isText As Boolean = False
            isnumric = False
            For Each texto In myFindText
                If String.IsNullOrWhiteSpace(texto) Then
                    isText = False
                    isnumric = False
                    Exit For
                ElseIf InStr("0123456789", texto) = False Then
                    If Not isText Then
                        isText = True
                    End If
                Else
                    If Not isnumric Then
                        isnumric = True
                    End If
                End If
            Next
            '// si es codigo
            If (isText) And (isnumric) Then
                _responseSpliter = New ResponseSpliter With
                {
                .IsSucces = True,
                .IsCode = True,
                .Spliter = myFindText.Split(" ")
                }
                GoTo Salida
            Else
                'si es nombre de producto covierto en una matriz
                _responseSpliter = New ResponseSpliter With
                    {
                    .IsSucces = True,
                    .Spliter = myFindText.Split(" ")
                    }
            End If
Salida:
            If isPreparatedStatement Then
                If preparatedStatement(_responseSpliter) Then
                    Return _responseSpliter
                End If
            End If
            Return _responseSpliter
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return New ResponseSpliter
        End Try
    End Function
    Public Function preparatedStatement(ByVal _Spliter As ResponseSpliter) As Boolean
        Try
            Dim param1 As String = String.Empty, param2 As String = String.Empty,
                param3 As String = String.Empty, isField As Int16

            If _Spliter.IsNumeric Then
                param1 = _Spliter.Spliter(0)
                isField = 0
            End If

            If _Spliter.IsCode Then
                param1 = _Spliter.Spliter(0)
                isField = 1
            End If

            If Not _Spliter.IsNumeric And Not _Spliter.IsCode Then
                isField = 2
                Select Case _Spliter.Spliter.Count
                    Case 1
                        param1 = _Spliter.Spliter(0)
                    Case 2
                        param1 = _Spliter.Spliter(0) : param2 = _Spliter.Spliter(1)
                    Case 3
                        param1 = _Spliter.Spliter(0) : param2 = _Spliter.Spliter(1) : param3 = _Spliter.Spliter(2)
                End Select

            End If


            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand("[dbo].[prdSelectMyProduc]", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@parameter1", SqlDbType.VarChar)
                    cmd.Parameters.Add("@parameter2", SqlDbType.VarChar)
                    cmd.Parameters.Add("@parameter3", SqlDbType.VarChar)
                    cmd.Parameters.Add("@isField", SqlDbType.TinyInt)
                    cmd.Parameters.Add("@codUser", SqlDbType.Char, 8)
                    cmd.Parameters.Add("@codTerminal", SqlDbType.Char, 8)
                    'set values
                    cmd.Parameters("@parameter1").Value = param1
                    cmd.Parameters("@parameter2").Value = param2
                    cmd.Parameters("@parameter3").Value = param3
                    cmd.Parameters("@isField").Value = isField
                    cmd.Parameters("@codUser").Value = UsuarioActivo.codUser
                    cmd.Parameters("@codTerminal").Value = TerminalActivo.codTerminal
                    ' prepara solo prodcutos seleccionados
                    If cmd.ExecuteNonQuery() Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function Carga_idCajaStado(dt As DataTable) As ResponseTerminal
        Try
            If Not (dt.Rows.Count = 1) Then
                sql = "Hay varias operaciones abierta" & vbNewLine
                sql = sql & "Habilite solo una..."
                MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                Return New ResponseTerminal With {.Success = False, .DataDb = dt, .IDterminal = 0}
            End If

            If Not IsDBNull(dt.Rows(0)("own_User")) Then
                If Not UsuarioActivo.codUser.Equals(dt.Rows(0)("own_User")) Then
                    sql = "La operacion abierta pertenece a: " & dt.Rows(0)("own_User") & vbNewLine
                    sql = sql & "Habilite una para este usuario... [" & UsuarioActivo.codUser & "]"
                    MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
                    Return New ResponseTerminal With {.Success = False, .DataDb = dt, .IDterminal = 0}
                End If
            End If
            TerminalActivo.idCajaStado = dt.Rows(0)("idCajaStado")
            TerminalActivo.Onwer = If(String.IsNullOrEmpty(dt.Rows(0)("own_User").ToString), "Todos..", dt.Rows(0)("own_User").ToString)
            Return New ResponseTerminal With {.Success = True, .DataDb = dt, .IDterminal = dt.Rows(0)("idCajaStado"), .IdStadoCaja = dt.Rows(0)("idCajaStado")}
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return New ResponseTerminal With {.Success = False, .DataDb = Nothing, .IDterminal = 0}
        End Try
    End Function

    Public Function DeleteBarCod(ByVal idPresent As Integer) As Boolean
        Try
            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()
                Using cmd As New SqlCommand("DeleteBarCod", cnn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.Add("@idPresent", SqlDbType.Int)
                    cmd.Parameters("@idPresent").Value = idPresent
                    If cmd.ExecuteNonQuery() > 0 Then
                        Return True
                    End If
                End Using
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Module

