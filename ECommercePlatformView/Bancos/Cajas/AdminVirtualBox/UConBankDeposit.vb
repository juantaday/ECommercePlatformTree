Imports CADsisVenta

Public Class UConBankDeposit
    Private MyParent As frmExitMoneyVirtualBox
    Private dtable As DataTable
    Private IdEmployeeDepositor As Integer

    Sub New(ByVal _MyParent As frmExitMoneyVirtualBox)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MyParent = _MyParent
    End Sub
    Private Sub UConBankDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_DataListBanck()
        SettinCombobox()
    End Sub
    Private Sub Load_DataListBanck()
        Try
            InitializeTable()
            Using db As New DataContext
                Dim myListmoney = From wb In db.BanckWhereHouse
                                  Join bc In db.BancosCuentas On bc.idBancoCuenta Equals wb.idBancoCuenta
                                  Join b In db.Bancos On b.idBanco Equals bc.idBanco
                                  Join p In db.Personas On p.idPersona Equals bc.idPersona
                                  Where wb.idBodega = TerminalActivo.idBodega
                                  Select bc.idBancoCuenta, Owner = p.Apellidos & " " & p.Nombre, b.nom_Banco, bc.num_Cuenta, bc.tipo_cuenta
                If myListmoney.Count > 0 Then
                    For Each item In myListmoney
                        Dim drow As DataRow = dtable.NewRow()
                        drow("idBancoCuenta") = item.idBancoCuenta
                        drow("Owner") = item.Owner
                        drow("nom_Banco") = item.nom_Banco
                        drow("num_Cuenta") = item.num_Cuenta
                        drow("tipo_cuenta") = item.tipo_cuenta
                        dtable.Rows.Add(drow)
                    Next
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub InitializeTable()
        dtable = New DataTable
        dtable.Columns.Add(New DataColumn With
                {
                    .ColumnName = "idBancoCuenta",
                    .DataType = System.Type.GetType("System.Int32"),
                    .Caption = "ID"
                 })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "Owner",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "Owner"
             })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "nom_Banco",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "nom_Banco"
             })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "num_Cuenta",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "num_Cuenta"
             })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "tipo_cuenta",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "tipo_cuenta"
             })
    End Sub

    Private Sub SettinCombobox()
        ColumnComboBox1.Data = dtable
        'Set which row will be displayed in the text box
        'If you set this to a column that isn't displayed then the suggesting functionality won't work.
        ColumnComboBox1.ViewColumn = 1
        'Set a few columns to Not be shown
        ColumnComboBox1.Columns(1).Display = True
        ColumnComboBox1.Columns(3).Display = True

        ColumnComboBox1.SelectedIndex = -1
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        Try
            Using ListClient As New frmListEmployeeView(stateLoad.Dialogo)
                With ListClient
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.IdEmployeeDepositor = ._ItemPerson.IdEmployee
                        Me.ResponsableDepositorTextBox.Text = ._ItemPerson.Ruc_Ci & "  - " & ._ItemPerson.FullName
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            If ValidaDatos() Then
                Try
                    Dim idBancocuenta As Integer? = ColumnComboBox1("idBancoCuenta").ToString()
                    Dim destino As String
                    Dim userAurization As String = String.Empty
                    Using newform As New LoginForm(stateReturn._response, "Administrador de cajas")
                        With newform
                            .ShowDialog()
                            If Not .DialogResult = DialogResult.OK Then
                                Return
                            End If
                            userAurization = .UsernameTextBox.Text
                            destino = "Deposito bancario: idBancoCuenta: " & ColumnComboBox1("idBancoCuenta").ToString() & "/"
                            destino = destino & ColumnComboBox1("nom_Banco").ToString() & "/"
                            destino = destino & "Cuenta: " & ColumnComboBox1("num_Cuenta").ToString() & "/"
                            destino = destino & "LLevo al banco: " & Me.ResponsableDepositorTextBox.Text
                        End With
                    End Using

                    If SaveTranfer(idBancocuenta, userAurization, destino) Then
                        MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
                        MyParent.DialogResult = DialogResult.OK
                        MyParent.Close()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function ValidaDatos() As Boolean
        Try
            If Not Me.ColumnComboBox1.SelectedIndex > -1 Then
                MsgBox("Seleccione la cuenta a depositar..", MsgBoxStyle.Exclamation, "Importante")
                ColumnComboBox1.Focus()
                Return False
            End If

            If String.IsNullOrEmpty(Me.ResponsableDepositorTextBox.Text) Then
                MsgBox("Seleccione el resposable del deposito..", MsgBoxStyle.Exclamation, "Importante")
                ColumnComboBox1.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
            Return False
        End Try
    End Function

    Private Function SaveTranfer(idBancocuenta As Integer?, _userAurization As String, _destino As String) As Boolean
        Try
            Using db As New DataContext
                Dim _saldo As Double? = (From v In db.VirtualBox
                                         Where v.idVirtualBox = MyParent.IdVirtualBox).FirstOrDefault().Saldo

                Dim newSaldo As Double = _saldo - MyParent.MontoDivisa
                Dim _VirtualBoxDetails As New VirtualBoxDetails With
                {
                    .idVirtualBox = MyParent.IdVirtualBox,
                    .Descripcion = _destino & " Autorizado: " & _userAurization,
                    .debe = 0,
                    .haber = MyParent.MontoDivisa,
                    .saldo = newSaldo
                }
                db.VirtualBoxDetails.InsertOnSubmit(_VirtualBoxDetails)
                db.SubmitChanges()
                Return True
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
            Return False
        End Try
    End Function

End Class
