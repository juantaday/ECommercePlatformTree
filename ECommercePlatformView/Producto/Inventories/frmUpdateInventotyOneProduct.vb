Imports CADsisVenta
Imports CADsisVenta.DataSetSystemTableAdapters
Public Class frmUpdateInventotyOneProduct
    Private idProducto As Integer
    Private pvpUND As Double
    Private AffectMoney As Double
    Private Stock As Double
    Private isClosing As Boolean
    Sub New(ByVal idProducto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idProducto = idProducto
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            isClosing = False
            Dim response As Boolean = False
            Dim autorization As String = String.Empty
            Using newform As New LoginForm(stateReturn._response, "Administrador de inventarios")
                With newform
                    .Text = "Validando para guardar."
                    .ShowDialog()
                    If (.DialogResult = DialogResult.OK) Then
                        autorization = .UsernameTextBox.Text
                        response = True
                    Else
                        isClosing = True
                    End If
                End With
            End Using
            If response Then
                If Update_Stock(Me.idProducto, ListBodegaComboBox.SelectedValue, autorization) Then
                    MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
                    Me.DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.DialogResult = DialogResult.No
            isClosing = True
        End Try
    End Sub

    Private Function Update_Stock(idProducto As Integer, idBodega As Integer, ByVal autorization As String) As Boolean
        Try
            Dim db As New DataContext
            Dim transaction As System.Data.Common.DbTransaction
            db.Connection.Open()
            transaction = db.Connection.BeginTransaction()
            Try
                db.Transaction = transaction
                'tomo la fecha del servidor
                Dim getdate = db.getDateServer().ToList()(0)
                'tomo la informacion del estock actual,,,
                Dim ordQuery =
                        From ps In db.ProductosStock
                        Where ps.idProducto = idProducto And ps.idBodega = idBodega
                        Select ps
                'leo y actulizo un solo inforamcion
                For Each ps As ProductosStock In ordQuery
                    Me.AffectMoney = (NewStockTextBox.Value - ps.stock) * ps.pvpUND
                    'agrego al atabla de invenatarios
                    Dim invet As New Inventory With {
                        .IdBodega = idBodega,
                        .Observation = ObservationRichTextBox.Text,
                        .DateTimeEnd = getdate.Column1,
                        .CodUserStar = UsuarioActivo.codUser,
                        .Authorizes = autorization,
                        .State = 0,
                        .AffectsInMoney = Me.AffectMoney
                        }
                    db.Inventory.InsertOnSubmit(invet)
                    db.SubmitChanges()
                    'set de detals
                    Dim inventDetail As New InventoryDetail With {
                    .AffectsInMoney = AffectMoney,
                       .BeforeStock = ps.stock,
                       .IdInventory = invet.IdInventory,
                       .idProducto = idProducto,
                       .NewStock = NewStockTextBox.Value
                       }
                    db.InventoryDetail.InsertOnSubmit(inventDetail)
                    ps.stock = NewStockTextBox.Value
                    db.SubmitChanges()
                Next
            Catch ex2 As Exception
                transaction.Rollback()
                MsgBox(ex2.Message, MsgBoxStyle.Critical, "Error")
            End Try
            transaction.Commit()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmUpdateInventotyOneProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_AloneProdcut()
        Carga_bodega()
    End Sub

    Private Sub Load_AloneProdcut()
        Try
            Using db As New DataContext
                Dim listSave = (From p In db.Productos
                                Where p.idProducto = Me.idProducto
                                Select p.idProducto, p.Nom_Comercial).ToList()(0)

                nom_ComercialTextBox.Text = listSave.Nom_Comercial
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Carga_bodega()
        Try
            Dim dat As New BodegaSystemTableAdapter
            Dim dt As New DataTable
            dt = dat.GetData()
            If dt.Rows.Count > 0 Then
                ListBodegaComboBox.DataSource = dt
                ListBodegaComboBox.DisplayMember = "Nom_Bodega"
                ListBodegaComboBox.ValueMember = "idBodega"
                ListBodegaComboBox.SelectedIndex = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ListBodegaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBodegaComboBox.SelectedIndexChanged
        Try
            NewStockTextBox.ReadOnly = True

            NewStockTextBox.Enabled = False
            ObservationRichTextBox.Enabled = False
            ObservationRichTextBox.ReadOnly = True
            If Not TypeOf ListBodegaComboBox.SelectedValue Is DataRowView Then
                ' Referenciando el objeto DataRowView correspondiente
                ' al elemento seleccionado en el control ComboBox.
                Dim row As DataRowView = DirectCast(ListBodegaComboBox.SelectedItem, DataRowView)
                If IsNothing(row) Then
                    Return
                End If
                sql = row.Item("Des_Bodega").ToString & vbCrLf
                sql = sql & "Dirección: " & row.Item("Direc_Bodega").ToString & vbCrLf
                sql = sql & "Teléfono: " & row.Item("Telef1_Bodega").ToString
                DescriptionBodegaLabel.Text = sql

                Load_BodegaInformation(Me.idProducto, row.Item("idBodega").ToString)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Load_BodegaInformation(idProducto As Integer, IdBodega As Integer)
        Try
            Using db As New DataContext
                Dim listSave = (From s In db.ProductosStock
                                Where s.idBodega = IdBodega And s.idProducto = idProducto
                                Select s.Und, s.pvpUND, s.stock).ToList()(0)

                If IsNothing(listSave) Then
                    Return
                End If

                Me.pvpUND = listSave.pvpUND
                Stock = listSave.stock
                AffectMoney = 0

                MedidaStockTextBox.Text = listSave.Und
                StockTextBox.Text = Stock.ToString("N3")
                NewStockTextBox.Text = 0
                AffectTextBox.Text = AffectMoney.ToString("C2")
                Me.pvpTextBox.Text = pvpUND.ToString("C2")


                NewStockTextBox.ReadOnly = False

                NewStockTextBox.Enabled = True
                ObservationRichTextBox.ReadOnly = False
                ObservationRichTextBox.Enabled = True
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub NewStockTextBox_ValueChanged(sender As Object, e As EventArgs) Handles NewStockTextBox.ValueChanged, ObservationRichTextBox.TextChanged
        Try
            Me.AffectMoney = (Me.NewStockTextBox.Value - Me.Stock) * Me.pvpUND
            Me.AffectTextBox.Text = Me.AffectMoney.ToString("C2")
            If NewStockTextBox.Value >= 0 And ObservationRichTextBox.TextLength > 0 And NewStockTextBox.Value <> Me.Stock Then
                Me.OK_Button.Enabled = True
            Else
                Me.OK_Button.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub NewStockTextBox_VisibleChanged(sender As Object, e As EventArgs) Handles NewStockTextBox.VisibleChanged
        sql = NewStockTextBox.Value
    End Sub

    Private Sub frmUpdateInventotyOneProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = Me.isClosing
    End Sub
End Class
