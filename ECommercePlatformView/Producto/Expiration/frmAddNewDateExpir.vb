Imports System.Windows.Forms
Imports CADsisVenta
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters


Public Class frmAddNewDateExpir
    Private isclosable As Boolean
    Private IDProducto As Integer
    Private NomComercial As String
    Sub New(idProducto As Integer, _nomComercia As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.IDProducto = idProducto
        NomComercial = _nomComercia
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        isclosable = False
        If Validate_Data() Then
            If SaveExpiration() Then
                isclosable = True
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function SaveExpiration() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Using db As New DataContext
                Dim expir As New ProductExpiration With
                {
                     .idBodega = Integer.Parse(ListBodegaComboBox.SelectedValue),
                    .idProducto = Me.IDProducto,
                    .idFacturaCompra =
                    If(String.IsNullOrWhiteSpace(Me.OrdenCompraTextBox.Text), 0,
                    Me.OrdenCompraTextBox.Text),
                    .DateExpirate = Me.DateTimePicker1.Value
                }

                db.ProductExpiration.InsertOnSubmit(expir)
                db.SubmitChanges()
                Return True
            End Using
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Function

    Private Function Validate_Data() As Boolean
        OrdenCompraTextBox.Text = Trim(OrdenCompraTextBox.Text)
        If RadioButton1si.Checked Then
            If String.IsNullOrWhiteSpace(OrdenCompraTextBox.Text) Then
                ErrorProvider1.SetError(OrdenCompraTextBox, "Determine la orden de compra")
                Return False
            Else
                ErrorProvider1.SetError(OrdenCompraTextBox, String.Empty)
            End If
        Else
            ErrorProvider1.SetError(OrdenCompraTextBox, String.Empty)
        End If
        If ListBodegaComboBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ListBodegaComboBox, "Seleccione la bodega en la que esta el producto")
            Return False
        Else
            ErrorProvider1.SetError(ListBodegaComboBox, String.Empty)
        End If

        If Me.IDProducto = 0 Then
            ErrorProvider1.SetError(Me.nomComercialLabel, "No se pudo determinar cual es la producto")
            Return False
        End If

        Dim numerodias As Integer = (DateTimePicker1.Value.Date - Date.Now.Date).Days
        If numerodias <= 0 Then
            ErrorProvider1.SetError(Me.DateTimePicker1, String.Empty)
            ErrorProvider1.SetError(Me.DateTimePicker1, "La fecha debe ser mayor a la de hoy día.")
            Return False
        End If

        Return True
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        isclosable = True
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmAddNewDateExpir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = Date.Now
        Carga_bodega()
        Me.nomComercialLabel.Text = String.Format("Producto: {0}", NomComercial)
    End Sub
    Private Sub Carga_bodega()
        Try
            Using dat As New BodegaSystemTableAdapter
                Using dt As New BodegaSystemDataTable
                    dat.Fill(dt)
                    ListBodegaComboBox.DataSource = dt.ToList()
                    ListBodegaComboBox.DisplayMember = "Nom_Bodega"
                    ListBodegaComboBox.ValueMember = "idBodega"
                    ListBodegaComboBox.SelectedValue = TerminalActivo.idBodega
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, vbCritical, "Error")
        End Try
    End Sub

    Private Sub RadioButton2no_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2no.CheckedChanged
        Me.OrdenCompraTextBox.Enabled = Not RadioButton2no.Checked
        If True Then
            OrdenCompraTextBox.Text = String.Empty
        End If
    End Sub

    Private Sub frmAddNewDateExpir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Not isclosable
    End Sub
End Class
