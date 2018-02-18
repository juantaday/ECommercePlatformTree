Imports System.Windows.Forms
Imports CADsisVenta
Imports LibPrintTicket.PrintTicket
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class frmSettingDocuments
    Private _IDBodega As Integer
    Private AdminControlsCheck As Boolean
    Private _stateClient As stateClient
    Private dataTable As List(Of GetListDocumentResult)
    Private ListOptiosChecken As List(Of SettingDocument)
    Sub New(ByVal stateClient As stateClient, ByVal idBodega As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ListOptiosChecken = New List(Of SettingDocument)
        _IDBodega = idBodega
        _stateClient = stateClient
        If Not stateClient = stateClient.Admin Then
            sql = "Le recordamos que los cambios realizados en esta opción se realizaran a nivel de:" & vbCrLf
            sql = sql & TerminalActivo.Nom_Bodega
            MsgBox(sql, MsgBoxStyle.Exclamation, "Importante")
        End If
    End Sub

    Private Sub frmSettingDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TerminalActivo.idTerminal = 0 Then
            MsgBox("Necesita registrarse en un terminal para esta operción.", MsgBoxStyle.Exclamation, "Importante")
            Me.Close()
        End If
        dataTable = New List(Of GetListDocumentResult)
        RefreshListDocumentButton.PerformClick()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Try
            If IsNothing(dataTable) Then
                Return
            End If
            Dim listControl As Object = Nothing
            Dim listFont As Object = Nothing

            Select Case e.Page.Tag.ToString.ToUpper
                Case "VENTAS"
                    listFont = VentaComboBox
                    listControl = ListDocumentVentas
                Case "COMPRAS"
                    listControl = ListBox1
                Case "ETIQUETAS"
                    listControl = ListDocumentEtiquetas
                Case "VARIOS"
                    listControl = ListDocumentVarrios
            End Select
            If Not (listControl Is Nothing) Then
                listControl.DataSource = dataTable.Where(Function(x) x.NameDocumentCatg.ToUpper.Contains(e.Page.Tag.ToString.ToUpper)).ToList
                listControl.DisplayMember = "Nom_Docu"
                listControl.ValueMember = "idTypoDocu"
                DocumentListBox_SelectedIndexChanged(listControl, New EventArgs)
            End If
            Select Case e.Page.Tag.ToString.ToUpper
                Case "VENTAS"
                    DocumentListBox_SelectedIndexChanged(listControl, New EventArgs)
                Case "COMPRAS"

                Case "ETIQUETAS"

                Case "VARIOS"

            End Select
            If Not (listFont Is Nothing) Then
                Loated_FontZise(listFont)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#Region "Check in list Document"
    Private Sub DocumentListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDocumentVentas.SelectedIndexChanged
        If ListDocumentVentas.ValueMember.ToString.Length > 0 Then
            If ListDocumentVentas.DisplayMember.ToString.Length > 0 Then
                CargaDatosVentas(ListDocumentVentas.SelectedValue)
            End If
        End If
    End Sub
    Private Sub ListDocumentEtiquetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDocumentEtiquetas.SelectedIndexChanged
        If ListDocumentEtiquetas.ValueMember.ToString.Length > 0 Then
            If ListDocumentEtiquetas.DisplayMember.ToString.Length > 0 Then
                CargaDatosEtiquetas(ListDocumentVentas.SelectedValue)
            End If
        End If
    End Sub
#End Region
#Region "Load Detail dcouments"
    Private Sub CargaDatosVentas(idDocument As Integer)
        Me.txtNameTicketVentas.Text = ""
        VentaListView.Items.Clear()
        ListOptiosChecken.Clear()
        'get detail in ventas
        If LoadOptionsPrint(ListDocumentVentas.SelectedValue, warn:=False) Then
            txtNameTicketVentas.Text = myOptnsPrint.NamePrint
            Using db As New DataContext
                Dim listOpcion = (db.PrintingTape).OrderBy(Function(x) x.IDPrintingTape).ToList()
                Dim i As Integer = 0
                For Each item In listOpcion
                    VentaListView.Items.Add(item.IDPrintingTape.ToString())
                    VentaListView.Items(i).SubItems.Add(item.NameSetting)
                    i += 1
                Next

                ListOptiosChecken = (db.SettingDocument).Where(Function(x) x.idBodega = _IDBodega _
                                        And x.idDocument = idDocument).ToList()

                For Each itemCheck In ListOptiosChecken
                    For Each itemVentOption As ListViewItem In VentaListView.Items
                        If itemCheck.IDPrintingTape = Integer.Parse(itemVentOption.Text) Then
                            itemVentOption.Checked = True
                        End If
                    Next
                Next


            End Using
        End If
    End Sub
    Private Sub CargaDatosCompra(idDocument As Integer)
        Me.txtNameTicketVentas.Text = ""
        'get detail in ventas
        If LoadOptionsPrint(ListDocumentVentas.SelectedValue, warn:=False) Then
            Dim selectItem As Integer = 0
            If (myOptnsPrint.isDefaultConfig) Then
            Else
            End If

            Me.txtNameTicketVentas.Text = myOptnsPrint.NamePrint
            If myOptnsPrint.Color = "Rojo" Then
            ElseIf myOptnsPrint.Color = "Negro" Then
            End If
        Else
        End If
    End Sub
    Private Sub CargaDatosEtiquetas(idDocument As Integer)

        'get detail in ventas
        If LoadOptionsPrint(ListDocumentEtiquetas.SelectedValue, warn:=False) Then
        Else
        End If
    End Sub

    Private Sub CargaDatosVarios(idDocument As Integer)
        'get detail in ventas
        If LoadOptionsPrint(ListDocumentVarrios.SelectedValue, warn:=False) Then
            Dim selectItem As Integer = 0
            If (myOptnsPrint.isDefaultConfig) Then
            Else
            End If

        Else
        End If
    End Sub

#End Region
#Region "Eveents"

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.ValueMember.ToString.Length > 0 Then
            If ListBox1.DisplayMember.ToString.Length > 0 Then
                CargaDatosVentas(ListBox1.SelectedValue)
            End If
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDocumentVarrios.SelectedIndexChanged
        If ListDocumentVarrios.ValueMember.ToString.Length > 0 Then
            If ListDocumentVarrios.DisplayMember.ToString.Length > 0 Then
                CargaDatosVarios(ListDocumentVarrios.SelectedValue)
            End If
        End If
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            If ValidaPageVarios() Then
                If ActulizaDatoVarios() Then
                    MsgBox("Informacióm actualizada correctamente", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub Ok_EtiquetasButton_Click(sender As Object, e As EventArgs) Handles Ok_EtiquetasButton.Click
        Try
            If ValidaPageEtiquetas() Then
                If ActulizaDatoEtiquetas() Then
                    MsgBox("Informacióm actualizada correctamente", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "" & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
#End Region
#Region "Functions"

    Private Sub Loated_FontZise(combo As System.Windows.Forms.ComboBox)
        Dim dtable As New DataTable

        dtable = New DataTable
        dtable.Columns.Add(New DataColumn With
                {
                    .ColumnName = "ID",
                    .DataType = System.Type.GetType("System.Int32"),
                    .Caption = "ID"
                 })
        dtable.Columns.Add(New DataColumn With
            {
                .ColumnName = "FontZise",
                .DataType = System.Type.GetType("System.String"),
                .Caption = "Font zise"
             })

        For Each item In [Enum].GetValues(GetType(FontZise))
            Dim drow As DataRow = dtable.NewRow()
            drow("ID") = item
            drow("FontZise") = CType(item, FontZise).ToString()
            dtable.Rows.Add(drow)
        Next
        combo.DataSource = dtable
        combo.DisplayMember = "FontZise"
        combo.ValueMember = "ID"
    End Sub
    Private Function ValidaPageVentas() As Boolean
        Return True
    End Function

    Private Function ValidaPageEtiquetas() As Boolean

        Return True
    End Function

    Private Function ValidaPageVarios() As Boolean


        Dim itemcolor As Boolean = False


        If Not itemcolor Then
            MsgBox("Seleccione un tipo de color de tinta", MsgBoxStyle.Exclamation, "Aviso")

            Return False
        End If

        Dim isDefaul = False

        If Not isDefaul Then
            MsgBox("Seleccione una de las opciones..", MsgBoxStyle.Exclamation, "Aviso")

            Return False
        End If


        Return True
    End Function

#End Region
#Region "Comands"
    Private Sub RefreshListDocumentButton_Click(sender As Object, e As EventArgs) Handles RefreshListDocumentButton.Click
        Try
            dataTable.Clear()
            Using db As New DataContext
                Dim listDocument = From l In db.GetListDocument
                For Each item In listDocument
                    dataTable.Add(item)
                Next
            End Using
            XtraTabControl1_SelectedPageChanged(Me.XtraTabControl1, New DevExpress.XtraTab.TabPageChangedEventArgs(XtraTabPage1, XtraTabPage1))
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            ListDocumentVentas.DataSource = Nothing
        End Try
    End Sub

    Private Function ActulizaDatoVentas()
        Try

            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function ActulizaDatoEtiquetas()
        Try


            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function ActulizaDatoVarios()
        Try
            Dim data As New TerminalConfiTableAdapter
            Dim myforma As String = String.Empty
            Return False
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub SaveVentasButton_Click(sender As Object, e As EventArgs) Handles SaveVentasButton.Click
        Try
            If Not ListDocumentVentas.SelectedItems.Count = 1 Then
                Return
            End If
            Dim _idDocument As Integer = ListDocumentVentas.SelectedValue
            Using db As New DataContext
                'delete de list not font
                Dim deletable = db.SettingDocument.Where(Function(x) x.idDocument = _idDocument And x.idBodega = _IDBodega)
                For Each itemDelete In deletable
                    db.SettingDocument.DeleteOnSubmit(itemDelete)
                Next
                db.SubmitChanges()

                For Each item As SettingDocument In ListOptiosChecken
                    Dim itemInser As New SettingDocument With
                    {
                        .FontZise = item.FontZise,
                        .ForeColor = item.ForeColor,
                        .idDocument = item.idDocument,
                        .IDPrintingTape = item.IDPrintingTape,
                        .idBodega = item.idBodega
                    }
                    db.SettingDocument.InsertOnSubmit(itemInser)
                Next
                db.SubmitChanges()
            End Using

            MsgBox("Información fuardara correctamente", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub checkColorVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles checListVentas.SelectedIndexChanged
        SelectOneItemInCheckList(sender)
    End Sub
    Private Sub SelectOneItemInCheckList(sender As System.Windows.Forms.CheckedListBox)
        If sender.SelectedIndex >= 0 Then
            For itemAct = 0 To sender.Items.Count - 1
                If sender.Items(itemAct) = sender.Items(sender.SelectedIndex) Then
                    sender.SetItemChecked(itemAct, True)
                    If itemAct = 0 Then
                    ElseIf itemAct = 1 Then

                    ElseIf itemAct = 2 Then
                    End If
                Else
                    sender.SetItemChecked(itemAct, False)
                End If
            Next
        End If
    End Sub

    Private Sub VentaListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VentaListView.SelectedIndexChanged
        Try

            If Not ListDocumentVentas.SelectedItems.Count = 1 Then
                Return
            End If

            AdminControlsCheck = True
            For itemAct = 0 To Me.checListVentas.Items.Count - 1
                checListVentas.SetItemChecked(itemAct, False)
            Next
            VentaComboBox.Text = CType(0, FontZise).ToString()




            If VentaListView.SelectedItems.Count = 1 Then
                Dim _IDPrintingTape As Integer = VentaListView.SelectedItems(0).Text
                Dim _idDocument As Integer = ListDocumentVentas.SelectedValue
                Dim mySelect = ListOptiosChecken.Where(Function(x) x.IDPrintingTape = _IDPrintingTape And x.idDocument = _idDocument)

                For Each item In mySelect
                    VentaComboBox.Text = CType(item.FontZise, FontZise).ToString()
                    AdminControlsCheck = False
                    For itemAct = 0 To Me.checListVentas.Items.Count - 1
                        If Me.checListVentas.Items(itemAct).ToString() = item.ForeColor Then
                            checListVentas.SetItemChecked(itemAct, True)
                        Else
                            checListVentas.SetItemChecked(itemAct, False)
                        End If
                    Next
                Next
            End If
            AdminControlsCheck = False
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub VentaListView_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles VentaListView.ItemChecked
        Try
            sql = e.Item.Text
            e.Item.Selected = True
            If Not ListDocumentVentas.SelectedItems.Count = 1 Then
                Return
            End If
            If Not VentaListView.SelectedItems.Count = 1 Then
                Return
            End If

            Dim _idDocument = 0
            Dim _idPrintingTape = 0
            Dim _foreColor As String = ""
            Dim fontZise As Int16 = 0
            Dim listView As ListView = Nothing



            _idDocument = ListDocumentVentas.SelectedValue
            _idPrintingTape = Integer.Parse(e.Item.Text)
            For Each item In checListVentas.CheckedItems
                _foreColor = item.ToString
            Next
            fontZise = VentaComboBox.SelectedValue
            listView = VentaListView

            If e.Item.Checked Then
                'if not fount
                Dim item = ListOptiosChecken.Where(Function(x) x.idDocument = _idDocument And
                                                       x.IDPrintingTape = _idPrintingTape And x.idBodega = _IDBodega).FirstOrDefault()
                If IsNothing(item) Then
                    Me.ListOptiosChecken.Add(New SettingDocument With
                                        {
                                        .FontZise = fontZise,
                                        .ForeColor = _foreColor,
                                        .idBodega = _IDBodega,
                                        .idDocument = _idDocument,
                                        .IDPrintingTape = _idPrintingTape
                                        })
                Else
                    With item
                        .FontZise = fontZise
                        .ForeColor = _foreColor
                        .idBodega = _IDBodega
                        .idDocument = _idDocument
                        .IDPrintingTape = e.Item.Text
                    End With

                End If

            Else
                Dim item = ListOptiosChecken.Where(Function(x) x.idDocument = _idDocument And
                                                       x.IDPrintingTape = _idPrintingTape And x.idBodega = _IDBodega).FirstOrDefault()
                If Not IsNothing(item) Then
                    ListOptiosChecken.Remove(item)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub VentaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VentaComboBox.SelectedIndexChanged, checListVentas.SelectedIndexChanged
        Try
            If AdminControlsCheck Then
                Return
            End If

            If Not ListDocumentVentas.SelectedItems.Count = 1 Then
                Return
            End If
            If Not VentaListView.SelectedItems.Count = 1 Then
                Return
            End If

            Dim _idDocument As Integer = ListDocumentVentas.SelectedValue
            Dim _IDPrintingTape As Integer = VentaListView.SelectedItems(0).Text
            Dim _foreColor As String = String.Empty
            Dim FontZise As Int32 = 0

            If VentaListView.SelectedItems(0).Checked Then
                For Each item In checListVentas.CheckedItems
                    _foreColor = item.ToString
                Next
                If VentaComboBox.ValueMember.ToString.Length > 0 Then
                    FontZise = VentaComboBox.SelectedValue
                End If


                Dim data = ListOptiosChecken.Where(Function(x) x.idDocument = _idDocument And x.IDPrintingTape = _IDPrintingTape).FirstOrDefault()

                If Not IsNothing(data) Then
                    data.FontZise = FontZise
                    data.ForeColor = _foreColor
                Else
                    MsgBox("Ups..!  parece que no esta seleccionado..", MsgBoxStyle.Exclamation, "Error")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#End Region

End Class
