Imports System.Windows.Forms
Imports CADsisVenta

Public Class frmAddVirtualBox
    Private Operation As stateOperation
    Protected Friend _VirtualBox As VirtualBox
    Private IsClosable As Boolean
    Public Sub New(ByVal _operation As stateOperation,
                   ByVal _VirtualBox As VirtualBox)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Operation = _operation
        Me._VirtualBox = _VirtualBox
    End Sub
    Private Sub frmAddVirtualBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_TypeVirtualBox()
        Select Case Operation
            Case stateOperation.Insert
            Case stateOperation.Update
                Me.NameVirtualBoxTextBox.Text = _VirtualBox.NameVirtualBox
                Me.ComboBox1.SelectedValue = _VirtualBox.TypeVirtualBox
                NotaTextBox.Text = _VirtualBox.remark
                DateResgisteTextBox.Text = _VirtualBox.dateRegister.ToShortDateString()
                SaldoTextBox.Text = _VirtualBox.Saldo.ToString("C2")
        End Select
    End Sub

    Private Sub Load_TypeVirtualBox()
        Try
            Using db As New DataContext
                Dim _type = From t In db.CajaTypo
                            Select t.IDCajaTypo, Name = t.NomTypocaja & " - " & t.Nota
                If _type.Count > 0 Then
                    ComboBox1.DataSource = _type.ToList()
                    ComboBox1.DisplayMember = "Name"
                    ComboBox1.ValueMember = "IDCajaTypo"
                    ComboBox1.SelectedIndex = -1
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        IsClosable = True
        If Dalidated_Data() Then
            If SaveData() Then
                Me.IsClosable = False
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function SaveData() As Boolean
        Try
            Using db As New DataContext
                Select Case Operation
                    Case stateOperation.Insert
                        Dim _VirtualBox As New VirtualBox With
                            {
                                .idBodega = Me._VirtualBox.idBodega,
                                .NameVirtualBox = Me.NameVirtualBoxTextBox.Text,
                                .remark = NotaTextBox.Text,
                                .TypeVirtualBox = ComboBox1.SelectedValue,
                                .Saldo = 0
                           }
                        db.VirtualBox.InsertOnSubmit(_VirtualBox)
                    Case stateOperation.Update
                        Dim VBox = From vb In db.VirtualBox
                                   Where vb.idVirtualBox = _VirtualBox.idVirtualBox

                        For Each item In VBox
                            item.NameVirtualBox = Me.NameVirtualBoxTextBox.Text
                            item.remark = NotaTextBox.Text
                            item.TypeVirtualBox = ComboBox1.SelectedValue
                        Next
                End Select
                db.SubmitChanges()
            End Using
            Return True
        Catch ex As Exception
            If ex.Message.Contains("UQ_VirtualBox_NameVirtualBox") Then
                MsgBox("Ya existe una caja con este nombre", MsgBoxStyle.Critical, "Error")
                Me.NameVirtualBoxTextBox.Focus()
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
            Return False
        End Try
    End Function

    Private Function Dalidated_Data() As Boolean
        Try
            NameVirtualBoxTextBox.Text = Trim(NameVirtualBoxTextBox.Text)
            If String.IsNullOrEmpty(NameVirtualBoxTextBox.Text) Then
                MsgBox("Ingrese el nombre de caja..", MsgBoxStyle.Critical, "Error")
                NameVirtualBoxTextBox.Focus()
                Return False
            End If

            NotaTextBox.Text = Trim(NotaTextBox.Text)

            If ComboBox1.SelectedIndex < 0 Then
                MsgBox("Seleccione el tipo de caja..", MsgBoxStyle.Critical, "Error")
                ComboBox1.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        IsClosable = False
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAddVirtualBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = IsClosable
    End Sub

    Friend Function MontoDivisa() As Double
        Throw New NotImplementedException()
    End Function
End Class
