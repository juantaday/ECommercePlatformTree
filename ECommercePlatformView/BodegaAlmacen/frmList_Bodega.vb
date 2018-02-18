Public Class frmList_Bodega
    Private cargado As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If DataGridView1.SelectedRows.Count = 1 Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmList_Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Datos()
    End Sub
    Private Sub Carga_Datos()
        Try
            cargado = False
            sql = "select b.idBodega , b.Nom_Bodega,b.Des_Bodega, b.Direc_Bodega, b.Telef1_Bodega from Bodegas as b "
            Dim cmd As New ClassCargadorProducto()
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    DataGridView1.DataSource = dt
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    DataGridView1.Columns(0).Visible = False  'id
                    DataGridView1.Columns(3).Visible = False   'Direccion
                    DataGridView1.Columns(4).Visible = False    'telefono
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cargado = True
        End Try
    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If cargado Then
            sql = "Direccion: "
            sql = sql & DataGridView1.SelectedCells(3).Value & vbNewLine
            sql = sql & "Teléfono: " & DataGridView1.SelectedCells(4).Value
            DescLabel.Text = sql
        End If
    End Sub
End Class
