Imports CADsisVenta

Public Class frmchilVirtualBox
    Private MyParent As frmExitMoney
    Private Idbodega As Integer
    Public Sub New(ByVal myParent As frmExitMoney, ByVal idbodega As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Idbodega = idbodega
        Me.MyParent = myParent
        Load_Data()
    End Sub
    Private Sub frmchilVirtualBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If Me.ListVirtualComboBox.SelectedIndex = -1 Then
            MsgBox("Seleccione la caja virtual", MsgBoxStyle.Exclamation, "Importante")
            ListVirtualComboBox.Focus()
            Return
        End If
        Dim userAurization As String
        Dim destino As String
        Using newform As New LoginForm(stateReturn._response, "Administrador de cajas")
            With newform
                .ShowDialog()
                If Not .DialogResult = DialogResult.OK Then
                    Return
                End If
                userAurization = .UsernameTextBox.Text
                destino = "Deposito caja virtual:" & Me.ListVirtualComboBox.SelectedValue & "/"
                destino = destino & ListVirtualComboBox.Text
            End With
        End Using

        If SaveTransfer(Me.ListVirtualComboBox.SelectedValue, userAurization, destino) Then
            MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
            MyParent.DialogResult = DialogResult.OK
            MyParent.Close()
        End If
    End Sub

    Private Function SaveTransfer(_idVirtualBox As Integer, _userAurization As String, _destino As String) As Boolean
        Try
            Using db As New DataContext
                Dim transaction As System.Data.Common.DbTransaction
                db.Connection.Open()
                transaction = db.Connection.BeginTransaction()
                db.Transaction = transaction
                Try
                    Dim LastSaldo As Double = 0

                    Dim _saldo = From s In db.VirtualBox
                                 Where s.idVirtualBox = _idVirtualBox

                    For Each item In _saldo
                        LastSaldo = item.Saldo
                    Next

                    Dim newSaldoVirtual As Double = LastSaldo + MyParent.MontoDivisa
                    Dim _VirtualBoxDetails As New VirtualBoxDetails With
                            {
                                .idVirtualBox = _idVirtualBox,
                                .debe = MyParent.MontoDivisa,
                                .Descripcion = "Deposito: /IdCajaStado: " & MyParent.IdCajaStado & "/ Autorizado por: " & _userAurization,
                                .haber = 0,
                                .saldo = newSaldoVirtual
                            }
                    db.VirtualBoxDetails.InsertOnSubmit(_VirtualBoxDetails)
                    db.SubmitChanges()

                    'set the terminal 
                    LastSaldo = 0
                    Dim _CajaStado = From s In db.CajaStado
                                     Where s.idCajaStado = MyParent.IdCajaStado

                    For Each item In _CajaStado
                        LastSaldo = item.Saldo
                    Next


                    Dim newSaldo As Double = LastSaldo - MyParent.MontoDivisa
                    Dim _Cajas As New Cajas With
                            {
                                    .idCajaStado = MyParent.IdCajaStado,
                                    .codUserMovi = _userAurization,
                                    .debe = 0,
                                    .haber = MyParent.MontoDivisa,
                                    .Descripcion = _destino,
                                    .saldo = newSaldo,
                                    .idFormaPago = MyParent.IdFormaPago,
                                    .onControl = "isAdmin",
                                    .TypoMovi = 1
                            }
                    db.Cajas.InsertOnSubmit(_Cajas)
                    db.SubmitChanges()
                    transaction.Commit()
                    MyParent.IdCaja = _Cajas.idCaja
                    Return True
                Catch ex2 As Exception
                    MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
                    transaction.Rollback()
                    Return False
                End Try
            End Using


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error ")
            Return False
        End Try
    End Function

    Private Sub Load_Data()
        Using db As New DataContext
            Dim milist = From c In db.CajaTypo
                         Join v In db.VirtualBox On c.IDCajaTypo Equals v.TypeVirtualBox
                         Join b In db.Bodegas On b.idBodega Equals v.idBodega
                         Where v.idBodega = Me.Idbodega
                         Select NameVirtual = b.Nom_Bodega + " " + v.NameVirtualBox, v.idVirtualBox
            If milist.Count > 0 Then
                ListVirtualComboBox.DataSource = milist.ToList()
                ListVirtualComboBox.DisplayMember = "NameVirtual"
                ListVirtualComboBox.ValueMember = "idVirtualBox"
                ListVirtualComboBox.SelectedIndex = -1
            End If

        End Using
    End Sub
End Class