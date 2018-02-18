Imports CADsisVenta

Public Class frmChildEmployeeAccount
    Private IdPersonAccount As Integer
    Private MyParent As frmExitMoney
    Private dtable As DataTable
    Public Sub New(ByVal myParent As Form)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MyParent = myParent
        Load_DataListAccount()
        SettinCombobox()

    End Sub


    Private Sub SettinCombobox()
        ColumnComboBox1.Data = dtable
        'Set which row will be displayed in the text box
        'If you set this to a column that isn't displayed then the suggesting functionality won't work.
        ColumnComboBox1.ViewColumn = 5
        'Set a few columns to Not be shown
        ColumnComboBox1.Columns(0).Display = False
        ColumnComboBox1.Columns(1).Display = False
        ColumnComboBox1.Columns(2).Display = False
        ColumnComboBox1.Columns(3).Display = False
        ColumnComboBox1.Columns(4).Display = False
        ColumnComboBox1.Columns(5).Display = True
        ColumnComboBox1.SelectedIndex = -1
    End Sub
    Private Sub Load_DataListAccount()
        Try
            InitializeTable()

            Using db As New DataContext
                Dim myAccount = From ac In db.Account
                                Where ac.Cuenta.StartsWith("1365")

                If myAccount.Count > 0 Then
                    For Each item In myAccount
                        Dim drow As DataRow = dtable.NewRow()
                        drow("idAccount") = item.idAccount
                        drow("Cuenta") = item.Cuenta
                        drow("Descripcion") = item.Descripcion
                        drow("Nivel") = item.Nivel
                        drow("Naturaleza") = item.Naturaleza
                        drow("DescripAndAccuent") = item.Cuenta & " " & item.Descripcion
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
                    .ColumnName = "idAccount",
                    .DataType = System.Type.GetType("System.Int32"),
                    .Caption = "ID"
                 })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "Cuenta",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "Cuenta"
             })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "Descripcion",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "Descrición"
             })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "Nivel",
                .DataType = System.Type.GetType("System.Int16"),
                .Caption = "Nivel"
             })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "Naturaleza",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "Naturaleza"
             })

        dtable.Columns.Add(New DataColumn With
           {
               .ColumnName = "DescripAndAccuent",
               .DataType = System.Type.GetType("System.String"),
               .Caption = "Descripcion y cuenta"
            })
    End Sub

    Private Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        Try
            Using ListClient As New frmListEmployeeView(stateLoad.Dialogo)
                With ListClient
                    .StartPosition = FormStartPosition.CenterScreen
                    .CancelButton = .closeButton
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.IdPersonAccount = ._ItemPerson.IdPersona
                        Me.AccuentPersonTextBox.Text = ._ItemPerson.Ruc_Ci & "  - " & ._ItemPerson.FullName
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If ValidaData() Then
            Dim cuenta As String = ColumnComboBox1("Cuenta").ToString()
            If Not cuenta.ToString.Length = 6 Then
                MsgBox("La cuenta selecionada no es correcta", MsgBoxStyle.Exclamation, "Importante")
                ColumnComboBox1.Focus()
                Return
            End If

            Dim destino As String
            Dim userAurization As String = String.Empty
            Using newform As New LoginForm(stateReturn._response, "Administrador de cajas")
                With newform
                    .ShowDialog()
                    If Not .DialogResult = DialogResult.OK Then
                        Return
                    End If
                    userAurization = .UsernameTextBox.Text
                    destino = "Pago al empleado: " & Me.AccuentPersonTextBox.Text & "/"
                    destino = destino & "Cuenta: " & ColumnComboBox1("Cuenta").ToString()
                End With
            End Using

            If SaveAccountEmployee(userAurization, destino) Then
                MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
                MyParent.DialogResult = DialogResult.OK
                Me.MyParent.Close()
            End If
        End If
    End Sub

    Private Function SaveAccountEmployee(userAurization As String, destino As String) As Boolean
        Try

            Using db As New DataContext
                Dim _Saldo As Double = 0

                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction

                Try
                    Dim _Balance = From p In db.Personas Where p.idPersona = Me.IdPersonAccount

                    For Each item In _Balance
                        _Saldo = item.Balance
                    Next

                    'cuanta de acreditacion al emplaedo
                    Dim NewSaldo As Double = _Saldo + MyParent.MontoDivisa
                    Dim _Employee As New EmpleadoDeuda With
                    {
                        .idPersona = Integer.Parse(Me.IdPersonAccount),
                        .Cuenta = ColumnComboBox1("Cuenta").ToString,
                        .IdTypoTransaction = 4,'Anticipos
                        .Tipo = "D",
                        .Valor = MyParent.MontoDivisa,
                        .Saldo = NewSaldo,
                        .IsWaxed = 0
                    }
                    db.EmpleadoDeuda.InsertOnSubmit(_Employee)
                    db.SubmitChanges()

                    'cuanta de acreditacion de retiro
                    Dim _EmployeeDebit As New EmpleadoDeuda With
                    {
                        .idPersona = Integer.Parse(Me.IdPersonAccount),
                        .Cuenta = "000000",
                        .IdTypoTransaction = 1,'Retiro en efactivo
                        .Tipo = "D",
                        .Valor = MyParent.MontoDivisa,
                        .Saldo = NewSaldo,
                        .IsWaxed = 1
                    }
                    db.EmpleadoDeuda.InsertOnSubmit(_EmployeeDebit)
                    db.SubmitChanges()


                    Dim _SaldoCaja As Double = 0
                    Dim _CajaStado = From cs In db.CajaStado
                                     Where cs.idCajaStado = MyParent.IdCajaStado

                    For Each item In _CajaStado
                        _SaldoCaja = item.Saldo
                    Next

                    Dim NewSaldoCaja As Double = _SaldoCaja - MyParent.MontoDivisa
                    Dim _Cajas As New Cajas With {
                        .idCajaStado = Me.MyParent.IdCajaStado,
                        .codUserMovi = userAurization,
                        .Descripcion = destino,
                        .idFormaPago = MyParent.IdFormaPago,
                        .debe = 0,
                        .haber = MyParent.MontoDivisa,
                        .saldo = NewSaldoCaja,
                        .onControl = "IsAdmin",
                        .TypoMovi = 1
                    }
                    db.Cajas.InsertOnSubmit(_Cajas)
                    db.SubmitChanges()

                    transaction.Commit()
                    MyParent.IdCaja = _Cajas.idCaja
                    Return True

                Catch ex2 As Exception
                    transaction.Rollback()
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    Return False
                End Try
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function ValidaData() As Boolean
        Try
            If ColumnComboBox1.SelectedIndex = -1 Then
                MsgBox("Seleccione la cuenta a cargar..", MsgBoxStyle.Exclamation, "Importante")
                ColumnComboBox1.DroppedDown = True
                ColumnComboBox1.Focus()
                Return False
            End If
            If String.IsNullOrEmpty(AccuentPersonTextBox.Text) OrElse Me.IdPersonAccount = 0 Then
                MsgBox("Seleccione a la persona a cargar la cuenta", MsgBoxStyle.Exclamation, "Importante")
                findButton.PerformClick()
                Return False
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class