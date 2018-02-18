Public Class frmEditaValor
    Dim Modifica As String = ""
    Protected Friend txtflag As String
    Private isLoad As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtprecioVenta_ValueChanged(sender As Object, e As EventArgs) Handles txtprecioVenta.ValueChanged
        If Me.txtflag = "0" Then Exit Sub
        If Modifica = "" Then
            Modifica = "Precio"
        End If
        If Modifica = "Precio" Then
            Dim pocien As Double = 0
            If Me.txtprecioCompra.Value > 0 And Me.txtprecioVenta.Value > 0 Then
                Me.txtUtilidad.Value = Me.txtprecioVenta.Value - Me.txtprecioCompra.Value
                pocien = (Me.txtUtilidad.Value / Me.txtprecioCompra.Value) * 100
                Me.txtporciento.Value = Redondear(pocien, 2)
            Else
                Me.txtUtilidad.Value = 0
                Me.txtporciento.Value = 0
            End If
            Modifica = ""
        End If
    End Sub

    Private Sub frmEditaValor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.txtflag = "0" Then Exit Sub
        If Me.txtprecioCompra.Value <= 0 Then
            txtprecioCompra.Enabled = False
            Me.txtUtilidad.Enabled = False
            Me.txtporciento.Enabled = False
        End If
        Me.TableLayoutPanel2.TabIndex = 0

        If Me.txtflag = "Utilidad" Then
            Me.txtUtilidad.TabIndex = 0
        ElseIf txtflag = "Porcentaje" Then
            Me.txtporciento.TabIndex = 0
        Else
            Me.txtprecioVenta.TabIndex = 0
        End If
        isLoad = True
    End Sub

    Private Sub txtprecioVenta_Enter(sender As Object, e As EventArgs) Handles txtprecioVenta.Enter
        Try
            Dim valor As String = sender.Value
            Dim posicion As Integer = Strings.InStr(valor, ".")

            If posicion > 0 Then
                sql = Strings.Left(valor, posicion - 1)
                sender.Select(0, Len(sql) + 1 + sender.DecimalPlaces)
            Else
                sender.Select(0, Len(valor) + 1 + sender.DecimalPlaces)
            End If

        Catch ex As Exception
            MsgBox(ex.Message + "en le txtprecioVenta_Enter del " + Me.Name, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub txtUtilidad_Enter(sender As Object, e As EventArgs) Handles txtUtilidad.Enter
        Try
            Dim valor As String = sender.Value
            Dim posicion As Integer = Strings.InStr(valor, ".")

            If posicion > 0 Then
                sql = Strings.Left(valor, posicion - 1)
                sender.Select(0, Len(sql) + 1 + sender.DecimalPlaces)
            Else
                sender.Select(0, Len(valor) + 1 + sender.DecimalPlaces)
            End If

        Catch ex As Exception
            MsgBox(ex.Message + "en le txtUtilidad_Enter del " + Me.Name, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub txtporciento_Enter(sender As Object, e As EventArgs) Handles txtporciento.Enter
        Try
            Dim valor As String = Me.txtporciento.Value
            Dim posicion As Integer = Strings.InStr(valor, ".")

            If posicion > 0 Then
                sql = Strings.Left(valor, posicion - 1)
                sender.Select(0, Len(sql) + 1 + txtporciento.DecimalPlaces)
            Else
                sender.Select(0, Len(valor) + 1 + txtporciento.DecimalPlaces)
            End If

        Catch ex As Exception
            MsgBox(ex.Message + "en le txtUtilidad_Enter del " + Me.Name, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub txtUtilidad_ValueChanged(sender As Object, e As EventArgs) Handles txtUtilidad.ValueChanged
        Try
            If IsNothing(txtflag) Then Exit Sub
            If Me.txtflag = "0" Then Exit Sub

            If Modifica = "" Then
                Modifica = "Utilidad"
            End If
            If Modifica = "Utilidad" Then
                Try
                    Me.txtprecioVenta.Value = Me.txtprecioCompra.Value + Me.txtUtilidad.Value
                    Me.txtporciento.Value = Redondear((Me.txtUtilidad.Value / Me.txtprecioCompra.Value) * 100, 2)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
                Modifica = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub txtporciento_ValueChanged(sender As Object, e As EventArgs) Handles txtporciento.ValueChanged
        Try
            If Not isLoad Then Exit Sub
            If Me.txtflag.Equals("Porcentaje") Then Modifica = Me.txtflag
            If Modifica = "Porcentaje" Then
                Try
                    Me.txtUtilidad.Value = Me.txtprecioCompra.Value * (Me.txtporciento.Value / 100)
                    Me.txtprecioVenta.Value = Me.txtprecioCompra.Value + Me.txtUtilidad.Value
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
                Modifica = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message, ex.Message, "Error")
        End Try
    End Sub
End Class
