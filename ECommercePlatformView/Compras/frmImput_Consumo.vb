Imports CADsisVenta
Public Class frmImput_Consumo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Valida_Datos() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmImput_Consumo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Declaracion()
        Carga_Consumo()
    End Sub
    Sub Carga_Declaracion()
        Try
            DeclaracionComboBox.DataSource = ClsCompras.getTypeDeclara
            DeclaracionComboBox.DisplayMember = "nom_declaracion"
            DeclaracionComboBox.ValueMember = "idDeclaracion"
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_Declaracion", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub Carga_Consumo()
        Try
            ConsumoComboBox.DataSource = ClsCompras.getTypeConsumo
            ConsumoComboBox.DisplayMember = "nom_consumo"
            ConsumoComboBox.ValueMember = "idconsumo"
        Catch ex As Exception
            MsgBox(ex.Message + " en el Carga_Declaracion", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function Valida_Datos() As Boolean
        Try
            If ConsumoComboBox.SelectedIndex < 0 Then
                MsgBox("Seleccione uno del listado", MsgBoxStyle.Information, "importante")
                ConsumoComboBox.Focus()
                Return False
            End If
            If DeclaracionComboBox.SelectedIndex < 0 Then
                MsgBox("Seleccione uno del listado", MsgBoxStyle.Information, "importante")
                DeclaracionComboBox.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message + " en el Valida_Datos", MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function
End Class
