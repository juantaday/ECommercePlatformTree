Imports CADsisVenta.DataSetUsersTableAdapters
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System
Imports System.Collections.ObjectModel

Public Class frmNewOperationCaja
    Protected Friend Stado As _state
    Protected Friend Operation As _operation
    Protected Friend idTerminal As Integer
    Private montoInicial As Double
    Private Err_code As Integer
    Private listMoney = New Collection(Of MoneyList)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Valida_Datos() Then
            Dim respont As Boolean
            Select Case Operation
                Case _operation.Insert
                    respont = OpenTransacction()
            End Select
            If respont Then ' si se dio la operacion lo cerramos
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function OpenTransacction() As Boolean
        Try
            Using connection As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                connection.Open()

                Dim command As SqlCommand = connection.CreateCommand()
                Dim transaction As SqlTransaction

                ' Start a local transaction
                transaction = connection.BeginTransaction("SampleTransaction")

                ' Must assign both transaction object and connection
                ' to Command object for a pending local transaction.
                command.Connection = connection
                command.Transaction = transaction
                command.CommandType = CommandType.Text
                If IsNothing(listMoney) Then
                    listMoney = New Collection()
                End If
                Try
                    'Lleno la cabecera
                    Dim idCajaStado As Integer = insertCajaStado(connection, transaction)
                    If idCajaStado > 0 Then
                        If insertCajas(connection, idCajaStado, transaction) Then
                            If Me.listMoney.Count > 0 Then
                                If Me.CajaDetailMoney(connection, idCajaStado, transaction) Then
                                    transaction.Commit()
                                    Return True
                                End If
                            Else
                                transaction.Commit()
                                Return True
                            End If
                        End If
                    End If
                    transaction.Rollback()
                    Return False
                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            Return False
        End Try
    End Function

    Private Function CajaDetailMoney(cn As SqlConnection, idCajaStado As Integer, transacction As SqlTransaction) As Boolean
        Try
            cn.FireInfoMessageEventOnUserErrors = True
            AddHandler cn.InfoMessage, New SqlInfoMessageEventHandler(AddressOf OnInfoMessage)
            Dim cmd As New SqlCommand()
            cmd.Connection = cn
            cmd.Transaction = transacction
            cmd.CommandType = CommandType.Text

            sql = "insert into CajaDetailMoney(idCajaStado, idMonedaDetail, Quantity, onState) "
            sql = sql & "Values(@idCajaStado,@idMonedaDetail,@Quantity,@onState)"

            cmd.CommandText = sql

            Dim star As Boolean = False
            For Each money As MoneyList In Me.listMoney
                If Not star Then
                    cmd.Parameters.Add("@idCajaStado", SqlDbType.Int) '
                    cmd.Parameters.Add("@idMonedaDetail", SqlDbType.Int)
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int)
                    cmd.Parameters.Add("@onState", SqlDbType.Bit)
                End If

                cmd.Parameters("@idCajaStado").Value = idCajaStado
                cmd.Parameters("@idMonedaDetail").Value = money.IdMonedaDetail
                cmd.Parameters("@Quantity").Value = money.Quantity
                cmd.Parameters("@onState").Value = 0
                star = True
                Err_code = 0
                If Not cmd.ExecuteNonQuery() >= 0 Then
                    Return False
                End If
                If Err_code > 0 Then
                    Return False
                End If
            Next
            Return star
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Erro")
            Return False
        End Try
    End Function

    Private Function insertCajas(cn As SqlConnection, idCajaStado As Integer, transaction As SqlTransaction) As Boolean
        Try
            If montoInicial = 0 Then
                Return True
            End If

            cn.FireInfoMessageEventOnUserErrors = True
            AddHandler cn.InfoMessage, New SqlInfoMessageEventHandler(AddressOf OnInfoMessage)
            Dim cmd As New SqlCommand()
            cmd.Connection = cn
            cmd.Transaction = transaction
            cmd.CommandType = CommandType.Text
            sql = "insert into Cajas(idCajaStado,codUserMovi,Descripcion,idFormaPago,debe,saldo,onControl,TypoMovi) "
            sql = sql & "Values(@idCajaStado,@codUserMovi,@Descripcion,@idFormaPago,@debe,@saldo,@onControl,@TypoMovi)"

            cmd.CommandText = sql

            cmd.Parameters.Add("@idCajaStado", SqlDbType.Int) '
            cmd.Parameters("@idCajaStado").Value = idCajaStado

            cmd.Parameters.Add("@codUserMovi", SqlDbType.VarChar)
            cmd.Parameters("@codUserMovi").Value = UsuarioActivo.codUser

            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar, 255)
            cmd.Parameters("@Descripcion").Value = "Apertura de Caja:"

            cmd.Parameters.Add("@idFormaPago", SqlDbType.Int)
            cmd.Parameters("@idFormaPago").Value = 1

            cmd.Parameters.Add("@debe", SqlDbType.Decimal)
            cmd.Parameters("@debe").Value = montoInicial

            cmd.Parameters.Add("@saldo", SqlDbType.Decimal)
            cmd.Parameters("@saldo").Value = montoInicial

            cmd.Parameters.Add("@onControl", SqlDbType.VarChar)
            cmd.Parameters("@onControl").Value = "isSystem"

            cmd.Parameters.Add("@TypoMovi", SqlDbType.TinyInt)
            cmd.Parameters("@TypoMovi").Value = 0

            Err_code = 0
            If cmd.ExecuteNonQuery() >= 0 Then
                If Err_code > 0 Then
                    Return False
                Else
                    Return True
                End If
            Else
                Return False
            End If
        Catch SqlEx As SqlException
            MsgBox(SqlEx.Number & " - " & SqlEx.Message, MsgBoxStyle.Exclamation, "Error")
            Return False
        End Try
    End Function


    Private Function insertCajaStado(cn As SqlConnection, transaction As SqlTransaction) As Integer
        Try

            cn.FireInfoMessageEventOnUserErrors = True
            AddHandler cn.InfoMessage, New SqlInfoMessageEventHandler(AddressOf OnInfoMessage)
            Dim cmd As New SqlCommand("insertCajaStado")
            cmd.Connection = cn
            cmd.Transaction = transaction
            cmd.CommandType = CommandType.StoredProcedure
            ' id terminal
            cmd.Parameters.Add("@idTerminal", SqlDbType.Int) '
            cmd.Parameters("@idTerminal").Value = Me.idTerminal
            ' Stado se apertura
            cmd.Parameters.Add("@Stado", SqlDbType.SmallInt)
            cmd.Parameters("@Stado").Value = 1 ' open
            ' es para todos los usuario
            cmd.Parameters.Add("@isAllUser", SqlDbType.Bit)
            Dim isAllUser As Integer = 1
            Dim own_User As String = String.Empty
            If Not isAllUserCheckBox.Checked Then
                isAllUser = 0
                own_User = ListUserComboBox.Items(ListUserComboBox.SelectedIndex)("Login").ToString()
            End If
            cmd.Parameters("@isAllUser").Value = isAllUser

            ' usuario de aperura
            cmd.Parameters.Add("@codUserOpen", SqlDbType.VarChar, 8)
            cmd.Parameters("@codUserOpen").Value = UsuarioActivo.codUser
            '  banco con la que paga8
            cmd.Parameters.Add("@QuantityOpen", SqlDbType.Decimal)
            cmd.Parameters("@QuantityOpen").Value = montoInicial
            '  fecha desde
            cmd.Parameters.Add("@own_User", SqlDbType.VarChar, 8)
            cmd.Parameters("@own_User").Value = own_User

            cmd.Parameters.Add("@idCajaStado", SqlDbType.Int)
            cmd.Parameters("@idCajaStado").Direction = ParameterDirection.Output

            Err_code = 0
            If cmd.ExecuteNonQuery() >= 0 Then
                If Err_code > 0 Then
                    Return 0
                End If
                If IsDBNull(cmd.Parameters("@idCajaStado").Value) Then
                    MsgBox("El procedimiento [dbo].[prcProforma] no retorno ningun valor..", MsgBoxStyle.Exclamation, "Error")
                    Return 0
                Else
                    Return Integer.Parse(cmd.Parameters("@idCajaStado").Value)
                End If
            Else
                Return 0
            End If
        Catch SqlEx As SqlException
            MsgBox(SqlEx.Number & " - " & SqlEx.Message, MsgBoxStyle.Exclamation, "Error")
            Return 0
        End Try
    End Function

    Private Sub OnInfoMessage(sender As Object, args As SqlInfoMessageEventArgs)
        Err_code = args.Errors.Item(0).Number
        Dim err As SqlError
        For Each err In args.Errors
            MsgBox(err.Message, MsgBoxStyle.Exclamation, "Error")
        Next
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub isAllUserCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles isAllUserCheckBox.CheckedChanged
        Try

            ListUserComboBox.Enabled = Not isAllUserCheckBox.Checked
            findUser_Button.Enabled = Not isAllUserCheckBox.Checked
        Catch ex As Exception
            MsgBox(ex.Message + " en el isAllUserCheckBox_CheckedChanged del " + Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmNewOperationCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Operation
            Case _operation.Insert
                'inicio
                DateStar.Value = Date.Now
                TimeStar.Value = Date.Now
                'cierre
                DateEnd.Visible = False
                TimeEnd.Visible = False
        End Select
        carga_Users()
    End Sub

    Private Sub carga_Users()
        Try
            Dim dt As DataTable
            Dim tap As New UserNameTableAdapter
            dt = tap.GetData
            Dim clm As New DataColumn
            clm.ColumnName = "Display"
            dt.Columns.Add(clm)

            For Each row As DataRow In dt.Rows
                row("Display") = row("Nombres") + " - " + row("Login")
            Next



            'Dim data = dt.Rows.Cast(Of DataRow) _
            '    .Select(Function(r) New With {.Key = r("idPersona"), _
            '                                  .Value = String.Format("{0} - {1}", r("Login"), r("Nombres")), _
            '                                  .CodUser = r("Login")}) _
            '    .ToList()
            With ListUserComboBox
                .DisplayMember = "Display"
                .ValueMember = "Login"
                .DataSource = dt
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub findUser_Button_Click(sender As Object, e As EventArgs) Handles findUser_Button.Click
        Try
            Using frmList_Users
                With frmList_Users
                    .WindowState = FormWindowState.Maximized
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = system.Windows.Forms.DialogResult.OK Then
                        sql = .dtg.SelectedRows(0).Cells(.dtg.Columns("Login").Index).Value
                        sql = sql & " - " & .dtg.SelectedRows(0).Cells(.dtg.Columns("Nombres").Index).Value
                        ListUserComboBox.SelectedText = sql
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ImputInicio_Button_Click(sender As Object, e As EventArgs) Handles ImputInicio_Button.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Using newsdata As New frmAdminMoney
                With newsdata
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        montoInicial = .TotalMoney
                        listMoney = .listMoneyRead
                        MontoInicio_TextBox.Text = montoInicial.ToString("C2")
                        OK_Button.Focus()
                    End If
                End With
            End Using
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message.ToString & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function Valida_Datos() As Boolean
        Try
            If Not isAllUserCheckBox.Checked Then
                If Not (ListUserComboBox.SelectedIndex >= 0) Then
                    MsgBox(msgSelect_list, MsgBoxStyle.Exclamation, "Importante")
                    ListUserComboBox.Focus()
                    Return False
                End If
            End If

            Dim valor As Double
            If IsNumeric(MontoInicio_TextBox.Text) Then
                valor = MontoInicio_TextBox.Text
                If Not (valor > 0) Then
                    If MsgBox("Está seguro que inicia sin saldo..?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Responda") = MsgBoxResult.No Then
                        Return False
                    End If
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub gotoSaldo_Button_Click(sender As Object, e As EventArgs) Handles gotoSaldo_Button.Click
        OK_Button.Focus()
    End Sub
End Class
