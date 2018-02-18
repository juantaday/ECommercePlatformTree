Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmBarrCode
    Protected Friend idPresent As Integer
    Private isAutoGenerate As Boolean
    Private _lastNumberGenerate As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.Cursor = Cursors.WaitCursor
        If UpdateBarrCode() Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function UpdateBarrCode() As Boolean
        Try
            barCodeTextBox.Text = Trim(barCodeTextBox.Text)

            Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString)
                cnn.Open()
                Dim transaction As SqlTransaction = cnn.BeginTransaction()
                sql = "Update ProductoPresentacion set BarCode = @BarCode "
                sql = sql & "Where (idPresentacion = @idPresentacion)"
                Using cmd As New SqlCommand(sql, cnn, transaction)
                    cmd.Parameters.Add("@BarCode", SqlDbType.Char, 25)
                    cmd.Parameters.Add("@idPresentacion", SqlDbType.Int)
                    If Me.barCodeTextBox.Text.Length > 0 Then
                        cmd.Parameters("@BarCode").Value = Me.barCodeTextBox.Text
                    Else
                        cmd.Parameters("@BarCode").Value = System.DBNull.Value
                    End If
                    cmd.Parameters("@idPresentacion").Value = Me.idPresent
                    If Not (cmd.ExecuteNonQuery() > 0) Then
                        Return False
                    End If
                    'new sql for uodate altimate autogenerate
                    If isAutoGenerate Then
                        sql = "UPdate [stm].[AutoGenetationBarrCode] set Numaration = @Numetation 
                               WHERE EncodingType = @EncodingType"

                        cmd.Parameters.Clear()

                        cmd.CommandText = sql

                        cmd.Parameters.Add("@Numetation", SqlDbType.Int)
                        cmd.Parameters("@Numetation").Value = _lastNumberGenerate

                        cmd.Parameters.Add("@EncodingType", SqlDbType.VarChar, 30)
                        cmd.Parameters("@EncodingType").Value = EncodingTypeComboBox.Text
                        If Not (cmd.ExecuteNonQuery() > 0) Then
                            Return False
                        End If
                    End If
                    transaction.Commit()
                    Return True
                End Using
            End Using

        Catch ex As Exception
            If ex.Message.Contains("CK_ProductoPresentacion_Barcode") Then
                MsgBox("Hay otro producto con este código.", MsgBoxStyle.Exclamation, "Importante")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If

            Return False
        End Try
    End Function
    Private Function DibujaBarra() As Boolean
        Try
            Dim alto As Single = 50
            Dim bm As Bitmap = Nothing
            barCodeTextBox.Text = Trim(barCodeTextBox.Text)
            If barCodeTextBox.Text.Length > 0 Then
                bm = BarCodeClass.codigo128("A" & barCodeTextBox.Text & "B", True, alto)
                If Not IsNothing(bm) Then
                    PictureBox1.Image = bm
                End If
            Else
                PictureBox1.Image = Nothing
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub frmBarrCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.barCodeTextBox.Text.Length > 0 Then
            GenerateButton.PerformClick()
        End If
    End Sub
    Private Sub barCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles barCodeTextBox.TextChanged
        Me.OK_Button.Enabled = False
        barCodeTextBox.Text = Trim(barCodeTextBox.Text)
        If barCodeTextBox.Text.Length > 0 Then
            DibujaBarra()
        End If
        If barCodeTextBox.Text.Length > 7 Then
            Me.AcceptButton = GenerateButton
        End If
    End Sub
    Private Sub deleteBarCodeButton_Click(sender As Object, e As EventArgs) Handles deleteBarCodeButton.Click
        barCodeTextBox.Text = String.Empty
        OK_Button.PerformClick()
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        isAutoGenerate = False
        ErrorLabel.Visible = False
        ErrorProvider1.SetError(barCodeTextBox, String.Empty)
        isAutoGenerate = False
        Me.PictureBox1.Image = DrawBarCode.DrawBarCodeAndLabel(barCodeTextBox.Text.Trim(), ProductoLabel.Text, 0.00, PresentacionLabel.Text, 2, isPrintLabel:=False)
        If Me.PictureBox1.Image.Tag = 0 Then
            sql = "No se pudo graficar" & vbCrLf
            sql = sql & "Si la lectura se realizo con scaner," & vbCrLf & "es seguro guardarlo." & vbCrLf
            DrawError(sql, Me.PictureBox1.Image)
        End If
        Me.OK_Button.Enabled = True
        Me.AcceptButton = OK_Button
    End Sub

    Private Sub DrawError(barCodeToDraw As String, _Image As Image)
        Try
            Dim _FontLabel As New Font("Microsoft Sans Serif", 9)

            Dim bmT As Image
            Dim bitmaps As New Bitmap(Integer.Parse(_Image.Width), (Integer.Parse(PictureBox1.Height)))
            bmT = bitmaps
            Dim g As Graphics = Graphics.FromImage(bmT)
            g.FillRectangle(New SolidBrush(Color.White), 0, 0, 100, 100)

            'set the width for label product
            Dim stringZise As New SizeF
            stringZise = g.MeasureString(barCodeToDraw, _FontLabel)
            Dim altoLabel As Single = stringZise.Height

            g.Clear(Color.White)

            g.DrawImage(_Image, 2, 2)

            g.DrawString(barCodeToDraw, _FontLabel, Brushes.Black, 2, PictureBox1.Height - altoLabel)

            Me.PictureBox1.Image = bmT
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function ComprobarCode(codeText As String, Optional isGenerated As Boolean = False) As ResponseCodeBarr
        Try
            Dim codigoF As String = String.Empty
            Dim NumberInicio, NumberCount As Integer

            Dim tipoCodBarras As Byte

            Select Case Len(codeText)
                Case 0 To 6
                    msgAviso("Introduzca 8 o 13 caracteres numéricos.")
                    Return Nothing
                Case 7 To 11
                    tipoCodBarras = 7
                Case 12 To 20
                    tipoCodBarras = 12
            End Select

            If codeText.Length = tipoCodBarras Then
                codeText = String.Format("{0}0", codeText)
            End If

            codigoF = formarCodBarras(codeText.Remove(tipoCodBarras))
            If Not isGenerated Then
                Return New ResponseCodeBarr With {.Success = codigoF = codeText, .CodeBarrResult = codigoF}
            End If

            If Not Integer.TryParse(codeText, NumberInicio) Then
                Return New ResponseCodeBarr With {.Success = False}
            End If

            Dim codePrueba As String = codeText
            For i = 1 To 100
                If codigoF = codePrueba Then
                    Return New ResponseCodeBarr With {.Success = True, .CodeBarrResult = codigoF}
                End If
                NumberCount = NumberInicio + i
                codePrueba = StrDup((tipoCodBarras + 1) - NumberCount.ToString().Length(), "0") & NumberCount.ToString()
                If codePrueba.Length = tipoCodBarras Then
                    codePrueba = String.Format("{0}0", codePrueba)
                End If

                codigoF = formarCodBarras(codePrueba.Remove(tipoCodBarras))
            Next
            Return New ResponseCodeBarr With {.Success = False}
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return New ResponseCodeBarr With {.Success = False}
        End Try
    End Function
    Private Sub AutoGenerateButton_Click(sender As Object, e As EventArgs) Handles AutoGenerateButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.OK_Button.Enabled = False
            Me.AcceptButton = Nothing
            If AutoGenerated() Then
                Me.OK_Button.Enabled = True
                Me.AcceptButton = OK_Button
                OK_Button.Focus()
                isAutoGenerate = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Function AutoGenerated(Optional InitialCode As String = "") As Boolean
        Try
            If EncodingTypeComboBox.SelectedIndex < 0 Then
                MsgBox("Seleccione un tipo de codigo a agenerar")
                EncodingTypeComboBox.Focus()
                Return False
            End If
            If EncodingTypeComboBox.Text.Equals("EAN-13") Then
                sql = "Se recomienda generar en EAN-8" & vbCrLf
                sql = sql & "Está seguro en el tipo que esta generando.?"
                If Not MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                    Return False
                End If
            End If
            'leo la bade de datos
            Dim _LastValue As Integer = 0
            If InitialCode.Length = 0 Then
                Using db As New DataContext
                    Dim latsValue = (From a In db.AutoGenetationBarrCode
                                     Where a.EncodingType = EncodingTypeComboBox.Text).FirstOrDefault().Numaration
                    If IsNothing(latsValue) Then
                        MsgBox("No se puede autogenerar sugerimos que ingrese de forma manual.")
                        barCodeTextBox.Focus()
                        Return False
                    End If
                    _LastValue = latsValue + 1
                End Using
            Else
                If Not Integer.TryParse(InitialCode, _LastValue) Then
                    MsgBox("No se puede convertir debe ser solo valores numéricos.", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
            End If


            Dim CodeEnviar As String = String.Empty
            Select Case EncodingTypeComboBox.Text
                Case "EAN-8"
                    CodeEnviar = StrDup(8 - _LastValue.ToString.Length, "0") & _LastValue.ToString()
                Case "EAN-13"
                    CodeEnviar = StrDup(13 - _LastValue.ToString.Length, "0") & _LastValue.ToString()
            End Select
            Dim responsebarr As Boolean = DrawBarCode.IsValidCode(CodeEnviar)
            PictureBox1.Image = DrawBarCode.DrawBarCodeAndLabel(barCodeTextBox.Text.Trim(), ProductoLabel.Text, 0.00, PresentacionLabel.Text, 1, 20, isPrintLabel:=True)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub GenerateFromButton_Click(sender As Object, e As EventArgs) Handles GenerateFromButton.Click
        Me.Cursor = Cursors.WaitCursor
        isAutoGenerate = False
        Me.OK_Button.Enabled = False
        Me.AcceptButton = Nothing
        barCodeTextBox.Text = Trim(barCodeTextBox.Text)
        If barCodeTextBox.Text.Length = 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("Determine a partir de qué número desea generar.", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If

        If AutoGenerated(Me.barCodeTextBox.Text) Then
            Me.OK_Button.Enabled = True
            Me.AcceptButton = OK_Button
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class
