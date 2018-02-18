Public Class frmOferta

    Private Modificando As Boolean = False
    Protected Friend precioNormal As Double
    Private nomMedida As String
    Sub New(nomMedida As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.nomMedida = nomMedida
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If EliminarBase() Then
                If Me.DataGridView1.Rows.Count > 0 Then
                    If AgregaBase() Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message + " en el OK_Button_Click del " + Me.Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function EliminarBase() As Boolean
        sql = "Delete from Ofertas where idPresent = " & Me.txtIdPresent.Text & ""
        Dim cmd As New ClassCargadorProducto

        Try
            cmd.ExecuteComand(sql)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try

    End Function
    Private Function AgregaBase() As Boolean

        Dim Respon As Boolean


        Dim Cadu As Integer = 0
        Dim percentageDescuent As Double = 0

        Dim idprest As Integer = Me.txtIdPresent.Text
        Dim Cant As Integer = 0
        Dim dateCaduca As Date = Date.Now

        Try
            Using cnn As New SqlClient.SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                cnn.Open()

                sql = "Insert INTO Ofertas (idPresent,orden,CantOferta,valor_Oferta,Caducidad,fech_Caduce) "
                sql = sql & "Values (@idPresent,@orden,@CantOferta,@valor_Oferta,@Caducidad,@fech_Caduce) "

                Using cmd As New SqlClient.SqlCommand(sql, cnn)
                    cmd.CommandType = CommandType.Text

                    For i = 0 To Me.DataGridView1.Rows.Count - 1
                        If i = 0 Then
                            cmd.Parameters.Add("@idPresent", SqlDbType.Int)
                            cmd.Parameters.Add("@orden", SqlDbType.Int)
                            cmd.Parameters.Add("@CantOferta", SqlDbType.Int)
                            cmd.Parameters.Add("@valor_Oferta", SqlDbType.Decimal)
                            cmd.Parameters.Add("@Caducidad", SqlDbType.Bit)
                            cmd.Parameters.Add("@fech_Caduce", SqlDbType.Date)

                        End If
                        'date   caduca
                        dateCaduca = Date.Now
                        'apartirde
                        Cant = Me.DataGridView1.Rows(i).Cells(0).Value
                        'caduciada
                        Cadu = 0
                        If Boolean.Parse(DataGridView1.Rows(i).Cells(4).Value) = True Then
                            Cadu = 1
                        End If
                        'percentage
                        percentageDescuent = DecimalFromString(Me.DataGridView1.Rows(i).Cells(1).Value) / 100
                        'date caduca
                        If Cadu = 1 Then
                            dateCaduca = DataGridView1.Rows(i).Cells(5).Value
                        End If
                        'set values 
                        cmd.Parameters("@idPresent").Value = idprest
                        cmd.Parameters("@orden").Value = i
                        cmd.Parameters("@CantOferta").Value = Cant
                        cmd.Parameters("@valor_Oferta").Value = percentageDescuent
                        cmd.Parameters("@Caducidad").Value = Cadu
                        cmd.Parameters("@fech_Caduce").Value = dateCaduca

                        Respon = cmd.ExecuteNonQuery
                        If Not Respon Then
                            Return False
                        End If
                    Next
                End Using
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message + "en el AgregaBase del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmOferta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImpideOrdenamiento(DataGridView1)
        Me.txtflag.Text = "cargado"
        Carga_Datos()
        Me.precioNormalLabel.Text = "Precio normal: " & precioNormal.ToString("C5")
    End Sub
    Private Sub Carga_Datos()
        Try

            sql = "Select * from Ofertas where idPresent = " & Me.txtIdPresent.Text & " "
            Dim dtg As DataGridView = Me.DataGridView1
            Dim cmd As New ClassCargadorProducto
            Dim dt As DataTable = cmd.RetornaTabla(sql)
            Dim PercentDescuenta As Double = 0
            Dim Valunid As Double = 0
            Dim _totalDescuento As Double = 0
            If Not IsNothing(dt) Then
                For i = 0 To dt.Rows.Count - 1
                    dtg.Rows.Add()
                    'cantidad
                    Dim cantidad As Integer = dt(i)("CantOferta").ToString
                    dtg.Rows(dtg.Rows.Count - 1).Cells(0).Value = cantidad

                    'porcenage
                    PercentDescuenta = dt(i)("valor_Oferta")
                    dtg.Rows(dtg.Rows.Count - 1).Cells(1).Value = PercentDescuenta.ToString("P2")
                    Dim DescuentUni As Double = precioNormal * PercentDescuenta

                    'valor unidad
                    dtg.Rows(dtg.Rows.Count - 1).Cells(2).Value = DescuentUni.ToString("C3")

                    'total descuento
                    _totalDescuento = DescuentUni * cantidad
                    dtg.Rows(dtg.Rows.Count - 1).Cells(3).Value = _totalDescuento.ToString("C3")

                    dtg.Rows(dtg.Rows.Count - 1).Cells(4).Value = dt(i)("Caducidad").ToString  'Caducidad
                    If dtg.Rows(dtg.Rows.Count - 1).Cells(4).Value Then
                        dtg.Rows(dtg.Rows.Count - 1).Cells(5).Value = dt(i)("fech_Caduce")
                    Else
                        dtg.Rows(dtg.Rows.Count - 1).Cells(5).Value = DBNull.Value
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message + "en el Carga_Datos del " + Me.Name, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.DataGridView1.Rows.Add("sdf")

    End Sub

    Private Sub ChkEmpaque_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkExpira_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function Agregar_Item(apartirDe As Integer, porcentageDescuento As Decimal, isExpite As Boolean, dateExpire As Date) As Boolean
        Try
            Dim percentage As Double = porcentageDescuento / 100
            Dim _precioXunid As Double = precioNormal * percentage
            Dim _totalDescuent As Double = (precioNormal * apartirDe) - (apartirDe * (precioNormal - _precioXunid))
            Dim dt As DataGridView = DataGridView1
            dt.Rows.Add()
            dt.Rows(dt.Rows.Count - 1).Cells(0).Value = apartirDe    'apartir de 
            dt.Rows(dt.Rows.Count - 1).Cells(1).Value = percentage.ToString("P2")  'porcentage de cuecuento
            dt.Rows(dt.Rows.Count - 1).Cells(2).Value = _precioXunid.ToString("C3")  'decuento por unidad
            dt.Rows(dt.Rows.Count - 1).Cells(3).Value = _totalDescuent.ToString("C3")
            dt.Rows(dt.Rows.Count - 1).Cells(4).Value = isExpite
            If dt.Rows(dt.Rows.Count - 1).Cells(4).Value Then
                dt.Rows(dt.Rows.Count - 1).Cells(5).Value = FormatDateTime(dateExpire, DateFormat.ShortDate)
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Modificar_Item(_Index As Integer, _APartirDe As Integer, _porcentageDescuent As Decimal, isExpirit As Boolean, dateExpirit As Date) As Boolean
        Try
            Dim percent As Decimal = _porcentageDescuent / 100
            Dim _precioXunid As Double = precioNormal * percent
            Dim decuetoTotal As Double = (precioNormal * _APartirDe) - (_APartirDe * (precioNormal - _precioXunid))

            Dim dt As DataGridView = DataGridView1
            dt.Rows(_Index).Cells(0).Value = _APartirDe
            dt.Rows(_Index).Cells(1).Value = percent.ToString("P2")
            dt.Rows(_Index).Cells(2).Value = _precioXunid.ToString("C3")
            dt.Rows(_Index).Cells(3).Value = decuetoTotal.ToString("C3")
            dt.Rows(_Index).Cells(4).Value = isExpirit
            If dt.Rows(_Index).Cells(4).Value Then
                dt.Rows(_Index).Cells(5).Value = FormatDateTime(dateExpirit, DateFormat.ShortDate)
            Else
                dt.Rows(_Index).Cells(5).Value = DBNull.Value
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message + " en el Modificar_Fila del " + Me.Name, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function Eliminar(ByVal idRowas As DataGridViewRow) As Boolean
        Try
            If MsgBox("Está seguro de eliminar la fila", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
                Me.DataGridView1.Rows.Remove(idRowas)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim minCan, maxCant As Integer
            Dim minPercent, maxPercent As Double
            Dim valueCant As Integer = 3
            Dim valuePercen As Double = 5

            Dim _index As Integer = -1
            If DataGridView1.RowCount > 0 Then
                _index = DataGridView1.Rows(DataGridView1.RowCount - 1).Index
            End If

            If DataGridView1.RowCount = 0 Then
                minCan = 0
                maxCant = 1000
                minPercent = 0
                maxPercent = 100
            Else
                minCan = DataGridView1.Rows(_index).Cells(0).Value + 1
                maxCant = 1000
                minPercent = DecimalFromString(DataGridView1.Rows(_index).Cells(1).Value) + 0.01
                maxPercent = 100
                valueCant = minCan
                valuePercen = minPercent
            End If


            Using frmAdminOfertas As New frmAdminOfertas(minCan, maxCant, minPercent, maxPercent, Me.precioNormal)
                With frmAdminOfertas
                    .productoLabel.Text = Me.lblProducto.Text
                    .NomMedida = Me.nomMedida
                    .aPartirDeNumeric.Value = valueCant
                    .porCentageDescuentNumeric.Value = valuePercen
                    .productoLabel.Text = Me.lblProducto.Text + presentacionDescLabel.Text
                    .PrecioNormal = Me.precioNormal
                    .ChkExpira.CheckState = CheckState.Unchecked
                    .expireDate.Enabled = False
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Agregar_Item(.aPartirDeNumeric.Value,
                                     .porCentageDescuentNumeric.Value,
                                     .ChkExpira.Checked,
                                     .expireDate.Value)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try

            Dim _index As Integer = -1
            If Not DataGridView1.SelectedRows.Count = 1 Then
                MsgBox("Seleccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            'set index
            _index = DataGridView1.SelectedRows(0).Index

            Dim minCan, maxCant As Integer
            Dim minPercent, maxPercent As Double
            Dim valueCant As Integer = DataGridView1.SelectedRows(0).Cells(0).Value
            Dim valuePercen As Double = DecimalFromString(DataGridView1.SelectedRows(0).Cells(1).Value)

            If DataGridView1.RowCount = 1 Then
                minCan = 0
                maxCant = 1000
                minPercent = 0
                maxPercent = 100
            ElseIf DataGridView1.RowCount > 1 Then
                If _index = 1 And DataGridView1.RowCount = 2 Then
                    minCan = DataGridView1.SelectedRows(0).Cells(0).Value + 1
                    maxCant = 1000
                    minPercent = DecimalFromString(DataGridView1.SelectedRows(0).Cells(1).Value) + 0.01
                    maxPercent = 100
                    valueCant = minCan
                    valuePercen = minPercent
                ElseIf _index = 0 And DataGridView1.RowCount > 1 Then
                    minCan = 0
                    maxCant = DataGridView1.Rows(_index + 1).Cells(0).Value - 1
                    minPercent = 0
                    maxPercent = DecimalFromString(DataGridView1.Rows(_index + 1).Cells(1).Value) - 0.01
                    valueCant = maxCant
                    valuePercen = maxPercent
                ElseIf _index = (DataGridView1.RowCount - 1) Then  'significa que estoy modificando el ultimo
                    minCan = DataGridView1.Rows(_index - 1).Cells(0).Value + 1
                    maxCant = 1000
                    minPercent = DecimalFromString(DataGridView1.Rows(_index - 1).Cells(1).Value) + 0.01
                    maxPercent = 100
                    valueCant = minCan
                    valuePercen = minPercent

                ElseIf _index > 0 And DataGridView1.RowCount > 2 Then
                    minCan = DataGridView1.Rows(_index - 1).Cells(0).Value + 1
                    maxCant = DataGridView1.Rows(_index + 1).Cells(0).Value - 1
                    minPercent = DecimalFromString(DataGridView1.Rows(_index - 1).Cells(1).Value) + 0.01
                    maxPercent = DecimalFromString(DataGridView1.Rows(_index + 1).Cells(1).Value) - 0.01
                    valueCant = maxCant
                    valuePercen = maxPercent
                End If

            End If

            Using frmAdminOfertas As New frmAdminOfertas(minCan, maxCant, minPercent, maxPercent, Me.precioNormal)
                With frmAdminOfertas
                    .productoLabel.Text = Me.lblProducto.Text
                    .aPartirDeNumeric.Value = valueCant
                    .porCentageDescuentNumeric.Value = valuePercen
                    .ChkExpira.Checked = DataGridView1.SelectedRows(0).Cells(4).Value
                    If IsDate(DataGridView1.SelectedRows(0).Cells(5).Value) Then
                        .expireDate.Value = DataGridView1.SelectedRows(0).Cells(5).Value
                    End If
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Modificar_Item(_index, .aPartirDeNumeric.Value,
                                   .porCentageDescuentNumeric.Value,
                                   .ChkExpira.Checked,
                                   .expireDate.Value)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If Not DataGridView1.SelectedRows.Count = 1 Then
                MsgBox("Seleccione uno del listado", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            If (MsgBox("Esta seguro de eliminar..?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda")) = MsgBoxResult.Yes Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (DataGridView1.SelectedRows.Count = 1) Then
            EditButton.Enabled = True
            DeleteButton.Enabled = True
        Else
            EditButton.Enabled = False
            DeleteButton.Enabled = False
        End If
    End Sub
End Class
