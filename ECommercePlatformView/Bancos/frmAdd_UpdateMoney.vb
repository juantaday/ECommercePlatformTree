Imports CADsisVenta.DataSetMonedasTableAdapters

Public Class frmAdd_UpdateMoney
    Protected Friend isFraccion As Boolean
    Protected Friend Operation As _operation
    Protected Friend idMoneda As Integer
    Protected Friend idMonedaDetail As Integer
    Private Money As MoneyList
    Sub New(Id As Integer, money As MoneyList)
        InitializeComponent()
        Me.Money = money
        idMoneda = Id
        idMonedaDetail = money.IdMonedaDetail
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Not Valida_datos() Then
            Return
        End If
        Dim resul As Boolean = False
        Me.Cursor = Cursors.WaitCursor
        Select Case Operation
            Case _operation.Insert
                resul = insert_Money()
            Case _operation.Update
                resul = update_Money()
        End Select
        If resul Then
            Me.Cursor = Cursors.Default
            MsgBox("Operación exitosa.", MsgBoxStyle.Information, "Error")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Function Valida_datos() As Boolean
        If String.IsNullOrWhiteSpace(MonedaTextBox.Text) Then
            MsgBox(msgFalta, MsgBoxStyle.Exclamation, "Importante")
            MonedaTextBox.Focus()
            Return False
        End If
        If ValorNumericUpDown.Value = 0 Then
            MsgBox("Debe contener un valor", MsgBoxStyle.Exclamation, "Importante")
            ValorNumericUpDown.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub frmAdd_UpdateMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(Operation) Then
            MsgBox("No se ha determinado la operación", MsgBoxStyle.Exclamation, "Importante")
            Close()
            Return
        End If
        Select Case Operation
            Case _operation.Delete
                If idMonedaDetail = 0 Then
                    MsgBox("No se ha determinado la idMonedaDetail", MsgBoxStyle.Exclamation, "Importante")
                    Close()
                    Return
                End If
            Case _operation.Insert
                If idMoneda = 0 Then
                    MsgBox("No se ha determinado la idMoneda", MsgBoxStyle.Exclamation, "Importante")
                    Close()
                    Return
                End If
            Case _operation.Update
                If idMonedaDetail = 0 Then
                    MsgBox("No se ha determinado la idMonedaDetail", MsgBoxStyle.Exclamation, "Importante")
                    Close()
                    Return
                End If
                If idMoneda = 0 Then
                    MsgBox("No se ha determinado la idMoneda", MsgBoxStyle.Exclamation, "Importante")
                    Close()
                    Return
                End If
                Carga_Datos()
        End Select
    End Sub

    Private Sub AddImagenLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AddImagenLinkLabel.LinkClicked
        Try
            Dim dlg = New OpenFileDialog
            Dim imglocation As String = ""

            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|GIF All (*.*)|*.*"
            dlg.Title = "Seelccione el empleado"
            If dlg.ShowDialog = DialogResult.OK Then
                imglocation = dlg.FileName.ToString()
                MonedaPictureBox.ImageLocation = imglocation
                MonedaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function insert_Money() As Boolean
        Try
            Dim foto() As Byte = Nothing
            Dim ms As New IO.MemoryStream()

            If Not IsNothing(MonedaPictureBox.Image) Then
                MonedaPictureBox.Image.Save(ms, MonedaPictureBox.Image.RawFormat)
                foto = ms.GetBuffer()
            End If
            Dim dat As New MonedaDetailTableAdapter
            If dat.InsertMonedaDetail(idMoneda, MonedaTextBox.Text,
                               ValorNumericUpDown.Value,
                            foto, isFraccion) > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function update_Money() As Boolean
        Try
            Dim foto() As Byte = Nothing
            Dim ms As New IO.MemoryStream()

            If Not IsNothing(MonedaPictureBox.Image) Then
                MonedaPictureBox.Image.Save(ms, MonedaPictureBox.Image.RawFormat)
                foto = ms.GetBuffer()
            End If
            Dim dat As New MonedaDetailTableAdapter
            If dat.UpdateMonedaDetail(MonedaTextBox.Text,
                          ValorNumericUpDown.Value,
                          foto, isFraccion, idMonedaDetail) > 0 Then
                Return True
            Else
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub Carga_Datos()
        Try
            MonedaTextBox.Text = Money.Description
            ValorNumericUpDown.Value = Money.Value_Moneda
            Dim img() As Byte = ImageToByte(Money.ImageMoneda)

            If Not IsNothing(img) Then
                If img.Length > 0 Then
                    Dim ms As New IO.MemoryStream(img)
                    MonedaPictureBox.Image = Image.FromStream(ms)
                    MonedaPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
