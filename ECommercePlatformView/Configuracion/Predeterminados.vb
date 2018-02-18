Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Net
Imports CADsisVenta.DataSetSystemTableAdapters
Public Enum Alinea
    Derecha = 0
    Centro = 1
    Izquierda = 2

End Enum

Module Predeterminados
    Public Declare Function SetDefaultPrinter Lib "winspool.drv" Alias "SetDefaultPrinterA" (ByVal pszPrinter As String) As Boolean

    Public prtSettings As New PrinterSettings
    Public prtDoc As PrintDocument
    Public prtFont As System.Drawing.Font

    Public DominioPublic, ipMaquina As String
    Private nameClass As String = "Predeterminados"


    Public Function GuardaImpreTicket(ByVal idMaquina As Integer, ByVal name As String, Color As String, items As Integer) As Boolean
        'obtengo el ip de esta maquina---------------------------------------------------------------

        conecta_sql()
        Try
            sql = "Update Num_Factura set NameImpreTicket='" & name & "', ColorTicket='" & Color & "', itemsPrintTicket = " & items & " "
            sql = sql & "FROM Num_Factura "
            sql = sql & "WHERE (idNumera= " & idMaquina & ") "

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            End Using


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el GuardaImpreTicket del predeterminados")
            Return False
        End Try

    End Function


    Public Function GuardaFacturaTicket(ByVal idMaquina As Integer, ByVal name As String, Color As String, items As Integer) As Boolean
        'obtengo el ip de esta maquina---------------------------------------------------------------

        conecta_sql()
        Try
            sql = "Update [STM].[Terminal] set NameImpreFactura='" & name & "', ColorFactura='" & Color & "', itemsPrintFact = " & items & " "
            sql = sql & "WHERE (idNumera= " & idMaquina & ") "

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            End Using


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En el GuardaImpreTicket del predeterminados")
            Return False
        End Try

    End Function
    Public Function GuardaDominio(ByVal dominio As String, ip As String) As Boolean

        conecta_sql()
        Try
            sql = "insert into  [stm].[Terminal] (Dominio, ip) Values ('" & dominio & "','" & ip & "') "
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message + "en el GuardaDominio del " + nameClass, MsgBoxStyle.Critical, "Aviso")
            Return False
        End Try

    End Function

    Public Function ModificaDominio(ByVal idMaquina As Integer, ByVal dominio As String, ip As String) As Boolean

        conecta_sql()
        Try
            sql = "Update Num_Factura set Dominio='" & dominio & "', ip ='" & ip & "' "
            sql = sql & "FROM Num_Factura "
            sql = sql & "WHERE (idNumera= " & idMaquina & ") "

            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text

                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message + " en el ModificaDominio del " + nameClass, MsgBoxStyle.Critical, "Aviso")
            Return False
        End Try

    End Function

    Public Function SeleccionarImpresora() As Boolean
        Dim prtDialog As New PrintDialog
        If prtSettings Is Nothing Then
            prtSettings = New PrinterSettings
        End If

        With prtDialog
            .AllowPrintToFile = False
            .AllowSelection = False
            .AllowSomePages = False
            .PrintToFile = False
            .ShowHelp = False
            .ShowNetwork = True

            .PrinterSettings = prtSettings

            If .ShowDialog() = DialogResult.OK Then
                prtSettings = .PrinterSettings
            Else
                Return False
            End If

        End With

        Return True
    End Function

    Public Function TextoDiseñado(ByVal Texto As String, ByVal Alineacio As Alinea, ByVal Tamaño As Integer) As String
        Dim part1 As String = ""

        Texto = Trim(Texto)

        If Texto.Length = 0 Then Return ""
        Try
            If Texto.Length > Tamaño Then
                part1 = Left(Texto, Tamaño)
                Return part1
            Else
                For i = 0 To (Tamaño - Texto.Length) - 1
                    part1 += " "
                Next

                If Alineacio = Alinea.Derecha Then
                    part1 += Texto
                ElseIf Alineacio = Alinea.Izquierda Then
                    part1 = Texto + part1
                End If
                Return part1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "En le TextoDiseñado del Predeterminados ")
            Return ""
        End Try
    End Function



    Public Function Carga_EquiposRegistradas() As DataTable

        sql = "select *  "
        sql = sql & "From  [stm].Terminal as t "
        sql = sql & "Inner join [stm].TerminalConfi as tc on t.idTerminal  = tc.idTerminal "
        sql = sql & "where t.codTerminal='" & TerminalActivo.codTerminal & "'"
        conecta_sql()
        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
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

        Catch ex As Exception
            MsgBox(ex.Message + "en el Carga_MauinaRegistradas del " + nameClass, MsgBoxStyle.Critical, "Aviso")
            Return Nothing
        End Try
    End Function
    Public Function ModificaNumeroFactura(ByVal idMaquina As Integer, ByVal Nun1 As String,
                                           ByVal Nun2 As String,
                                            ByVal Nun3 As String,
                                             ByVal Nun4 As String) As Boolean

        sql = "Update [stm].[TerminalConfi] set NumFact01 = '" & Nun1 & "',NumFact02 = '" & Nun2 & "',NumFact03 = '" & Nun3 & "',NumFact04 = '" & Nun4 & "' "
        sql = sql + "where idTerminal =" & TerminalActivo.idTerminal & " "
        conecta_sql()

        Try
            Using cmd As New SqlCommand(sql, Cnn_sql)
                cmd.CommandType = CommandType.Text
                If cmd.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message + "en el ModificaNumeroFactura del " + nameClass, MsgBoxStyle.Critical, "Error")
            Return False
        End Try


    End Function
    Public Function LoadOptionsPrint(idTypeDocument As Integer, Optional warn As Boolean = True) As Boolean
        Try
            Using cmd As New TerminalConfiTableAdapter
                Dim dt As DataTable = cmd.GetDataByIdTerminalIdDocument(TerminalActivo.idTerminal, idTypeDocument)
                If dt.Rows.Count > 0 Then
                    With myOptnsPrint
                        .idPrint = dt.Rows(0)("idTerminalConfi")
                        .NamePrint = Convert.ToString(dt.Rows(0)("NameImpreTicket"))
                        .Color = Convert.ToString(dt.Rows(0)("ColorTicket"))
                        .items = Convert.ToString(dt.Rows(0)("itemsPrintTicket"))
                        .typePrint = Convert.ToString(dt.Rows(0)("typePrint"))
                        .isDefaultConfig = Boolean.Parse(dt.Rows(0)("isDefault"))
                    End With
                    Return PrinterNametInstol(myOptnsPrint.NamePrint, warn)
                End If
                Return False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Public Function LoadOptionsPrint(ByVal NameDocument As String) As Boolean
        Try
            Using cmd As New TerminalConfiTableAdapter
                Dim dt As DataTable = cmd.GetDataIdTerminalAndNomDocument(TerminalActivo.idTerminal, NameDocument)
                If dt.Rows.Count > 0 Then
                    With myOptnsPrint
                        .idPrint = dt.Rows(0)("idTerminalConfi")
                        .NamePrint = Convert.ToString(dt.Rows(0)("NameImpreTicket"))
                        .Color = Convert.ToString(dt.Rows(0)("ColorTicket"))
                        .items = Convert.ToString(dt.Rows(0)("itemsPrintTicket"))
                        .typePrint = Convert.ToString(dt.Rows(0)("typePrint"))
                        .isDefaultConfig = Boolean.Parse(dt.Rows(0)("isDefault"))
                    End With
                    Return PrinterNametInstol(myOptnsPrint.NamePrint)
                End If
                MsgBox(String.Format("Para el documento {0} no  se ha configurado.", NameDocument), MsgBoxStyle.Exclamation, "Aviso")
                Return False
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Public Function PrinterNametInstol(NamePrint As String, Optional warn As Boolean = True) As Boolean  'ES para saber si la impresora esta instalada
        Try
            For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
                If PrinterSettings.InstalledPrinters(i).ToString() = NamePrint Then
                    Return True
                End If
            Next
            If warn Then
                MsgBox(String.Format("La impresora {0} no está isntalada.", NamePrint), MsgBoxStyle.Exclamation, "Aviso")
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Aviso")
            Return False
        End Try
    End Function
End Module
