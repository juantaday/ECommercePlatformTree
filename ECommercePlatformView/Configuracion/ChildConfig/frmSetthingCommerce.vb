Imports CADsisVenta
Public Class frmSetthingCommerce
    Private _Mycommercerce As myCommerce
    Private dtableMonney As DataTable
    Private idRates As Integer
    Private CommerceId As Integer
    Private idSettingSales As Integer
    Private IsLoadted As Boolean
    Public Sub New(ByVal _CommerceId As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Load_MyCommerce()
        Load_DataListMoney()
        SettinCombobox()
        ViewPercent()
        IsLoadted = True
    End Sub

    Private Sub Load_MyCommerce()
        Try
            Using db As New DataContext
                Dim __MyCommerce = (From c In db.myCommerce).FirstOrDefault()
                If Not IsNothing(__MyCommerce) Then
                    Me._Mycommercerce = __MyCommerce
                    RequestSalesAutorizeCheckBox.Checked = __MyCommerce.RequestSalesAuthorization
                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmSetthingCommerce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewPercent()
    End Sub
    Private Sub SettinCombobox()
        moneyColumnComboBox.Data = dtableMonney
        'Set which row will be displayed in the text box
        'If you set this to a column that isn't displayed then the suggesting functionality won't work.
        moneyColumnComboBox.ViewColumn = 1
        'Set a few columns to Not be shown
        moneyColumnComboBox.Columns(1).Display = True
        moneyColumnComboBox.Columns(3).Display = True

        moneyColumnComboBox.Text = SeleccteedValue()
    End Sub

    Private Sub ViewPercent()
        Try
            If IsNothing(Me._Mycommercerce) Then
                Return
            End If

            Me.PercentDecimalIvaNumericUpDown.Value = Me._Mycommercerce.IvaPercent
            Me.PercentageIvaTextBox.Text = Me._Mycommercerce.IvaPercent.ToString("P2")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Function SeleccteedValue() As String
        Try
            Using db As New DataContext
                Dim mycommerce = (From c In db.myCommerce
                                  Join m In db.TypoMoneda On c.idMoneda Equals m.idMoneda
                                  Select c.idMoneda, m.Nom_Moneda)
                For Each item In mycommerce
                    Return item.Nom_Moneda.ToString()
                    Exit For
                Next
            End Using
            Return String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return String.Empty
        End Try
    End Function
    Private Sub Load_DataListMoney()
        Try
            Using db As New DataContext
                Dim myListmoney = From m In db.TypoMoneda
                                  Select m.idMoneda, m.Nom_Moneda, m.Pais_Origen, m.Simbolo, m.Cod_Iso

                dtableMonney = New DataTable
                Dim col As New DataColumn
                col.ColumnName = ""
                col.Caption = ""
                dtableMonney.Columns.Add(New DataColumn With
                        {
                            .ColumnName = "idMoneda",
                            .DataType = System.Type.GetType("System.Int32"),
                            .Caption = "ID"
                         })
                dtableMonney.Columns.Add(New DataColumn With
                    {
                        .ColumnName = "Nom_Moneda",
                        .DataType = System.Type.GetType("System.String"),
                        .Caption = "Moneda"
                     })
                dtableMonney.Columns.Add("Pais_Origen", System.Type.GetType("System.String"))
                dtableMonney.Columns.Add("Simbolo", System.Type.GetType("System.String"))
                dtableMonney.Columns.Add("Cod_Iso", System.Type.GetType("System.String"))

                For Each item In myListmoney.OrderBy(Function(x) x.Nom_Moneda).ThenBy(Function(x) x.Pais_Origen).ToList()
                    Dim drow As DataRow = dtableMonney.NewRow()
                    drow("idMoneda") = item.idMoneda
                    drow("Nom_Moneda") = item.Nom_Moneda
                    drow("Pais_Origen") = item.Pais_Origen
                    drow("Simbolo") = item.Simbolo
                    drow("Cod_Iso") = item.Cod_Iso
                    dtableMonney.Rows.Add(drow)
                Next
                Dim _mycommer = From c In db.myCommerce

                For Each item In _mycommer
                    Me.CommerceId = item.CommerceId
                    idSettingSales = If(IsNothing(item.idSettingSales), 0, item.idSettingSales)
                    Exit For
                Next

                Dim listSettingSales = New List(Of SettingSales)
                listSettingSales.Add(New SettingSales With {.idSettingSales = 0, .NameSettingSales = "Ninguno.."})
                listSettingSales.AddRange(From d In db.SettingSales)

                SettingSalesComboBox.DataSource = listSettingSales
                SettingSalesComboBox.ValueMember = "idSettingSales"
                SettingSalesComboBox.DisplayMember = "NameSettingSales"
                If idSettingSales > 0 Then
                    SettingSalesComboBox.SelectedValue = idSettingSales
                Else
                    SettingSalesComboBox.SelectedIndex = -1
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If Valida_Data() Then
            If SaveData() Then
                MsgBox("Informacion guardara exitosamente", MsgBoxStyle.Information, "Aviso")
            End If
        End If
    End Sub

    Private Function Valida_Data() As Boolean
        Try
            If moneyColumnComboBox.SelectedIndex = -1 Then
                MsgBox(msgSelect_list, MsgBoxStyle.Exclamation, "Error")
                moneyColumnComboBox.Focus()
                Return False
            End If
            If SettingSalesComboBox.SelectedIndex = -1 Then
                MsgBox(msgSelect_list, MsgBoxStyle.Exclamation, "Error")
                SettingSalesComboBox.Focus()
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SaveData() As Boolean
        Try
            Using db As New DataContext
                Dim mycommerce = (From c In db.myCommerce)
                For Each item In mycommerce
                    item.idMoneda = moneyColumnComboBox("IdMoneda").ToString()
                    item.idSettingSales = If(SettingSalesComboBox.SelectedValue = 0, Nothing, SettingSalesComboBox.SelectedValue)
                    item.IvaPercent = _Mycommercerce.IvaPercent
                    item.RequestSalesAuthorization = RequestSalesAutorizeCheckBox.Checked
                    item.EnableEditPurchase = EnableEditPurchaseCheckBox.Checked
                Next
                db.SubmitChanges()
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function SetItemInListView(item As Object) As ListViewItem
        Try
            Dim itemView As New ListViewItem
            With itemView
                .Text = item.idBanckCommerce
                .SubItems.Add(item.nom_Banco)
                .SubItems.Add(item.num_Cuenta)
                .SubItems.Add(item.tipo_cuenta)
            End With
            Return itemView
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
    Private Sub PercentDecimalIvaNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PercentDecimalIvaNumericUpDown.ValueChanged
        If IsLoadted Then
            SetValueIva()
        End If
    End Sub

    Private Sub SetValueIva()
        Try
            If IsNothing(Me._Mycommercerce) Then
                Return
            End If

            Me._Mycommercerce.IvaPercent = Me.PercentDecimalIvaNumericUpDown.Value
            ViewPercent()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub ExecuteIvaConfigBunifuThinButton_Click(sender As Object, e As EventArgs) Handles ExecuteIvaConfigBunifuThinButton.Click
        Try
            If IsNothing(_Mycommercerce) OrElse Not (_Mycommercerce.IvaPercent > 0) Then
                MsgBox("El porcentage de iva debe ser mayor a cero.!", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            sql = "Este proceso cambiara el porcentage de iva a todos los productos.." & vbCrLf
            sql = sql & "Desea continuar...?"
            If Not MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda..") = MsgBoxResult.Yes Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor
            If CambiaIvaTodos(_Mycommercerce.IvaPercent) Then
                MsgBox(msgExsito, MsgBoxStyle.Information, "Aviso")
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub SettingDefaultPrinter_Click(sender As Object, e As EventArgs) Handles SettingDefaultPrinter.Click
        Try
            Using forSetting As New frmDefaultDocuments()
                With forSetting
                    .ShowDialog()

                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class

