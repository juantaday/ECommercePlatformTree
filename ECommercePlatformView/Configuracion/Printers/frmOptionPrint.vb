Imports CADsisVenta
Imports CADsisVenta.DataSetCompras
Imports CADsisVenta.DataSetComprasTableAdapters
Imports CADsisVenta.DataSetTicketTableAdapters

Public Class frmOptionPrint
    Inherits System.Windows.Forms.Form
    Public Título As String
    Private prtFont As System.Drawing.Font
    Private lineaActual As Integer
    Private Idfucntio As Integer = 0
    Private isLoadCheck As Boolean

    Private dataTable As List(Of GetListDocumentResult)
    Private Sub OptionPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TerminalActivo.idTerminal = 0 Then
            MsgBox("Necesita registrarse en un terminal para esta operción.", MsgBoxStyle.Exclamation, "Importante")
            Me.Close()
        End If
        dataTable = New List(Of GetListDocumentResult)
        RefreshListDocumentButton.PerformClick()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSeleciona.Click
        If SeleccionarImpresora() Then
            Me.txtNameTicketVentas.Text = prtSettings.PrinterName
        End If
    End Sub
    Private Sub btnGuardaTicket_Click(sender As Object, e As EventArgs) Handles okBooton.Click
        Try
            If ValidaPageVentas() Then
                If ActulizaDatoVentas() Then
                    MsgBox("Informacióm actualizada correctamente", MsgBoxStyle.Information, "Aviso")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub chekColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chekColor.SelectedIndexChanged
        If chekColor.SelectedIndex >= 0 Then
            For itemAct = 0 To Me.chekColor.Items.Count - 1
                If Me.chekColor.Items(itemAct) = Me.chekColor.Items(chekColor.SelectedIndex) Then
                    chekColor.SetItemChecked(itemAct, True)
                    If itemAct = 0 Then
                    ElseIf itemAct = 1 Then

                    ElseIf itemAct = 2 Then
                    End If
                Else
                    chekColor.SetItemChecked(itemAct, False)
                End If
            Next
        End If
    End Sub

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
    Private Sub isDEfaultCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles isDEfaultCheckedListBox.ItemCheck
        Try
            If Not isLoadCheck Then
                isLoadCheck = True
                If e.Index = 0 Then
                    If e.NewValue = CheckState.Checked Then
                        PaneTicketDetail.Enabled = False
                        isDEfaultCheckedListBox.SetItemChecked(1, False)
                    Else
                        isDEfaultCheckedListBox.SetItemChecked(1, True)
                        PaneTicketDetail.Enabled = True
                    End If
                ElseIf e.Index = 1 Then
                    If e.NewValue = CheckState.Checked Then
                        isDEfaultCheckedListBox.SetItemChecked(0, False)
                        PaneTicketDetail.Enabled = True
                    Else
                        isDEfaultCheckedListBox.SetItemChecked(0, True)
                        PaneTicketDetail.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            isLoadCheck = False
        End Try

    End Sub

    Private Sub XtraTabPage3_Paint(sender As Object, e As PaintEventArgs) Handles XtraTabPage3.Paint

    End Sub

    Private Sub OptionAdvanceButton_Click(sender As Object, e As EventArgs) Handles OptionAdvanceButton.Click
        Try
            Using SettingDocument As New frmAdminDocument
                With SettingDocument
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Try
            Dim lisControl As Object = Nothing

            Select Case e.Page.Tag.ToString.ToUpper
                Case "VENTAS"
                    lisControl = ListDocumentVentas
                Case "COMPRAS"
                    lisControl = ListBox1
                Case "ETIQUETAS"
                    lisControl = ListDocumentEtiquetas
                Case "VARIOS"
                    lisControl = ListDocumentVarrios
            End Select

            If Not (lisControl Is Nothing) Then
                lisControl.DataSource = dataTable.Where(Function(x) x.NameDocumentCatg.ToUpper.Contains(e.Page.Tag.ToString.ToUpper)).ToList
                lisControl.DisplayMember = "Nom_Docu"
                lisControl.ValueMember = "idTypoDocu"
            End If

        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
#Region "Eveents"

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If SeleccionarImpresora() Then
            Me.namePrintEtiquetasTextBox.Text = prtSettings.PrinterName
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.ValueMember.ToString.Length > 0 Then
            If ListBox1.DisplayMember.ToString.Length > 0 Then
                CargaDatosVentas(ListBox1.SelectedValue)
                Me.PaneTicketDetail.Visible = True
                Me.PaneTicketDetail.Text = "Configurando para " & ListDocumentVentas.Text
            End If
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDocumentVarrios.SelectedIndexChanged
        If ListDocumentVarrios.ValueMember.ToString.Length > 0 Then
            If ListDocumentVarrios.DisplayMember.ToString.Length > 0 Then
                CargaDatosVarios(ListDocumentVarrios.SelectedValue)
                Me.PaneTicketDetail.Visible = True
                Me.PaneTicketDetail.Text = "Configurando para " & ListDocumentVentas.Text
            End If
        End If
    End Sub

    Private Sub CheckedListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox3.SelectedIndexChanged
        If CheckedListBox3.SelectedIndex >= 0 Then
            For itemAct = 0 To Me.CheckedListBox3.Items.Count - 1
                If Me.CheckedListBox3.Items(itemAct) = Me.CheckedListBox3.Items(CheckedListBox3.SelectedIndex) Then
                    CheckedListBox3.SetItemChecked(itemAct, True)
                    If itemAct = 0 Then
                    ElseIf itemAct = 1 Then

                    ElseIf itemAct = 2 Then
                    End If
                Else
                    CheckedListBox3.SetItemChecked(itemAct, False)
                End If
            Next
        End If
    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        If CheckedListBox2.SelectedIndex >= 0 Then
            For itemAct = 0 To Me.CheckedListBox2.Items.Count - 1
                If Me.CheckedListBox2.Items(itemAct) = Me.CheckedListBox2.Items(CheckedListBox2.SelectedIndex) Then
                    CheckedListBox2.SetItemChecked(itemAct, True)
                    If itemAct = 0 Then
                    ElseIf itemAct = 1 Then

                    ElseIf itemAct = 2 Then
                    End If
                Else
                    CheckedListBox2.SetItemChecked(itemAct, False)
                End If
            Next
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

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.SelectedIndex >= 0 Then
            For itemAct = 0 To Me.CheckedListBox1.Items.Count - 1
                If Me.CheckedListBox1.Items(itemAct) = Me.CheckedListBox1.Items(CheckedListBox1.SelectedIndex) Then
                    CheckedListBox1.SetItemChecked(itemAct, True)
                    If itemAct = 0 Then
                    ElseIf itemAct = 1 Then

                    ElseIf itemAct = 2 Then
                    End If
                Else
                    CheckedListBox1.SetItemChecked(itemAct, False)
                End If
            Next
        End If
    End Sub
    Private Sub isDEfaultCheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles isDEfaultCheckedListBox.SelectedIndexChanged
        If isDEfaultCheckedListBox.SelectedIndex >= 0 Then
            For itemAct = 0 To Me.isDEfaultCheckedListBox.Items.Count - 1
                If Me.isDEfaultCheckedListBox.Items(itemAct) = Me.isDEfaultCheckedListBox.Items(isDEfaultCheckedListBox.SelectedIndex) Then
                    isDEfaultCheckedListBox.SetItemChecked(itemAct, True)
                    If itemAct = 0 Then
                    ElseIf itemAct = 1 Then

                    ElseIf itemAct = 2 Then
                    End If
                Else
                    isDEfaultCheckedListBox.SetItemChecked(itemAct, False)
                End If
            Next
        End If
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

#Region "Check in list Document"
    Private Sub DocumentListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDocumentVentas.SelectedIndexChanged
        If ListDocumentVentas.ValueMember.ToString.Length > 0 Then
            If ListDocumentVentas.DisplayMember.ToString.Length > 0 Then
                CargaDatosVentas(ListDocumentVentas.SelectedValue)
                Me.PaneTicketDetail.Visible = True
                Me.PaneTicketDetail.Text = "Configurando para " & ListDocumentVentas.Text
            End If
        End If
    End Sub
    Private Sub ListDocumentEtiquetas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDocumentEtiquetas.SelectedIndexChanged
        If ListDocumentEtiquetas.ValueMember.ToString.Length > 0 Then
            If ListDocumentEtiquetas.DisplayMember.ToString.Length > 0 Then
                CargaDatosEtiquetas(ListDocumentVentas.SelectedValue)
                Me.PaneTicketDetail.Visible = True
                Me.PaneTicketDetail.Text = "Configurando para " & ListDocumentEtiquetas.Text
            End If
        End If
    End Sub
#End Region
#Region "Load Detail dcouments"
    Private Sub CargaDatosVentas(idDocument As Integer)
        Me.txtNameTicketVentas.Text = ""
        Me.chekColor.SetItemChecked(0, False)
        Me.chekColor.SetItemChecked(1, False)
        typePrintComboBox.SelectedIndex = -1
        CheckedListBox1.SelectedIndex = 0
        'get detail in ventas
        If LoadOptionsPrint(ListDocumentVentas.SelectedValue, warn:=False) Then
            Dim selectItem As Integer = 0
            If (myOptnsPrint.isDefaultConfig) Then
                CheckedListBox1.SelectedIndex = 0
            Else
                CheckedListBox1.SelectedIndex = 1
            End If

            Me.txtNameTicketVentas.Text = myOptnsPrint.NamePrint
            If myOptnsPrint.Color = "Rojo" Then
                Me.chekColor.SetItemChecked(1, True)
            ElseIf myOptnsPrint.Color = "Negro" Then
                Me.chekColor.SetItemChecked(0, True)
            End If
            txtItems.Value = myOptnsPrint.items
            Me.typePrintComboBox.Text = myOptnsPrint.typePrint
        Else
        End If
    End Sub
    Private Sub CargaDatosCompra(idDocument As Integer)
        Me.txtNameTicketVentas.Text = ""
        Me.chekColor.SetItemChecked(0, False)
        Me.chekColor.SetItemChecked(1, False)
        typePrintComboBox.SelectedIndex = -1
        CheckedListBox1.SelectedIndex = 0
        'get detail in ventas
        If LoadOptionsPrint(ListDocumentVentas.SelectedValue, warn:=False) Then
            Dim selectItem As Integer = 0
            If (myOptnsPrint.isDefaultConfig) Then
                CheckedListBox1.SelectedIndex = 0
            Else
                CheckedListBox1.SelectedIndex = 1
            End If

            Me.txtNameTicketVentas.Text = myOptnsPrint.NamePrint
            If myOptnsPrint.Color = "Rojo" Then
                Me.chekColor.SetItemChecked(1, True)
            ElseIf myOptnsPrint.Color = "Negro" Then
                Me.chekColor.SetItemChecked(0, True)
            End If
            txtItems.Value = myOptnsPrint.items
            Me.typePrintComboBox.Text = myOptnsPrint.typePrint
        Else
        End If
    End Sub
    Private Sub CargaDatosEtiquetas(idDocument As Integer)
        Me.namePrintEtiquetasTextBox.Text = ""
        typeprintsCombobox.SelectedIndex = -1
        isDEfaultCheckedListBox.SelectedIndex = 0

        'get detail in ventas
        If LoadOptionsPrint(ListDocumentEtiquetas.SelectedValue, warn:=False) Then
            isDEfaultCheckedListBox.SelectedIndex = 1

            Me.namePrintEtiquetasTextBox.Text = myOptnsPrint.NamePrint
            Me.typeprintsCombobox.Text = myOptnsPrint.typePrint
        Else
        End If
    End Sub

    Private Sub CargaDatosVarios(idDocument As Integer)
        Me.TextBox4.Text = ""
        Me.CheckedListBox5.SetItemChecked(0, False)
        Me.CheckedListBox5.SetItemChecked(1, False)
        ComboBox2.SelectedIndex = -1
        CheckedListBox3.SelectedIndex = 0
        'get detail in ventas
        If LoadOptionsPrint(ListDocumentVarrios.SelectedValue, warn:=False) Then
            Dim selectItem As Integer = 0
            If (myOptnsPrint.isDefaultConfig) Then
                CheckedListBox3.SelectedIndex = 0
            Else
                CheckedListBox3.SelectedIndex = 1
            End If

            Me.TextBox4.Text = myOptnsPrint.NamePrint
            If myOptnsPrint.Color = "Rojo" Then
                Me.CheckedListBox5.SetItemChecked(1, True)
            ElseIf myOptnsPrint.Color = "Negro" Then
                Me.CheckedListBox5.SetItemChecked(0, True)
            End If
            NumericUpDown2.Value = myOptnsPrint.items
            Me.ComboBox2.Text = myOptnsPrint.typePrint
        Else
        End If
    End Sub

#End Region
#Region "Functions"
    Private Function ValidaPageVentas() As Boolean
        'si no ha seleccionado predeterminado retornamos
        If isDEfaultCheckedListBox.GetItemChecked(0) Then
            Return True
        End If
        If typePrintComboBox.SelectedIndex = -1 Then
            MsgBox("Determine el tipo de impresora", MsgBoxStyle.Exclamation, "Aviso")
            typePrintComboBox.Focus()
            Return False
        End If
        'si esta selecionado totas
        If IsNothing(typePrintComboBox.SelectedValue = 0) Then
            MsgBox("Seleccione una del listado", MsgBoxStyle.Exclamation, "Aviso")
            typePrintComboBox.Focus()
            Return False
        End If

        Dim itemcolor As Boolean = False

        For Each itemChecked In chekColor.CheckedItems
            itemcolor = True
        Next

        If Not itemcolor Then
            MsgBox("Seleccione un tipo de color de tinta", MsgBoxStyle.Exclamation, "Aviso")
            chekColor.Focus()
            Return False
        End If

        Dim isDefaul = False
        For Each itemChecked In CheckedListBox1.CheckedItems
            isDefaul = True
        Next
        If Not isDefaul Then
            MsgBox("Seleccione una de las opciones..", MsgBoxStyle.Exclamation, "Aviso")
            isDEfaultCheckedListBox.Focus()
            Return False
        End If

        If txtItems.Value = 0 Or txtItems.Value > 120 Then
            MsgBox("La cantidad de item puede tener maximo de 120 y minimo de 1", MsgBoxStyle.Exclamation, "Aviso")
            txtItems.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(txtNameTicketVentas.Text) Then
            MsgBox("Determine el nombre de la impresora", MsgBoxStyle.Exclamation, "Aviso")
            txtItems.Focus()
            Return False
        End If

        If Not PrinterNametInstol(txtNameTicketVentas.Text) Then
            MsgBox("Esta impresona no esta instalada", MsgBoxStyle.Exclamation, "Aviso")
            btnSeleciona.PerformClick()
            Return False
        End If
        Return True
    End Function

    Private Function ValidaPageEtiquetas() As Boolean
        If Not isDEfaultCheckedListBox.SelectedIndex = 0 Then
            'si no ha seleccionado predeterminado retornamos
            If namePrintEtiquetasTextBox.Text.ToString.Length = 0 Then
                MsgBox("Determine el nombre de la impresora", MsgBoxStyle.Exclamation, "Aviso")
                Button2.PerformClick()
                Return False
            End If
            If typeprintsCombobox.SelectedIndex = -1 Then
                MsgBox("Determine el tipo de impresora", MsgBoxStyle.Exclamation, "Aviso")
                typeprintsCombobox.Focus()
                Return False
            End If
            Return True
        End If
        Return True
    End Function

    Private Function ValidaPageVarios() As Boolean
        If CheckedListBox3.SelectedIndex = 0 Then
            Return True
        End If

        If ComboBox2.SelectedIndex = -1 Then
            MsgBox("Determine el tipo de impresora", MsgBoxStyle.Exclamation, "Aviso")
            ComboBox2.Focus()
            Return False
        End If
        'si esta selecionado totas
        If IsNothing(typePrintComboBox.SelectedValue = 0) Then
            MsgBox("Seleccione una del listado", MsgBoxStyle.Exclamation, "Aviso")
            typePrintComboBox.Focus()
            Return False
        End If

        Dim itemcolor As Boolean = False

        For Each itemChecked In CheckedListBox5.CheckedItems
            itemcolor = True
        Next

        If Not itemcolor Then
            MsgBox("Seleccione un tipo de color de tinta", MsgBoxStyle.Exclamation, "Aviso")
            CheckedListBox5.Focus()
            Return False
        End If

        Dim isDefaul = False
        For Each itemChecked In CheckedListBox3.CheckedItems
            isDefaul = True
        Next
        If Not isDefaul Then
            MsgBox("Seleccione una de las opciones..", MsgBoxStyle.Exclamation, "Aviso")
            isDEfaultCheckedListBox.Focus()
            Return False
        End If

        If NumericUpDown2.Value = 0 Or txtItems.Value > 120 Then
            MsgBox("La cantidad de item puede tener maximo de 120 y minimo de 1", MsgBoxStyle.Exclamation, "Aviso")
            txtItems.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(TextBox4.Text) Then
            MsgBox("Determine el nombre de la impresora", MsgBoxStyle.Exclamation, "Aviso")
            TextBox4.Focus()
            Return False
        End If

        If Not PrinterNametInstol(TextBox4.Text) Then
            MsgBox("Esta impresona no esta instalada", MsgBoxStyle.Exclamation, "Aviso")
            btnSeleciona.PerformClick()
            Return False
        End If
        Return True
    End Function

#End Region
#Region "Comands"
    Private Function ActulizaDatoVentas()
        Try
            Dim data As New TerminalConfiTableAdapter
            Dim myforma As String = String.Empty
            For Each item In CheckedListBox1.CheckedItems
                myforma = item
            Next
            'leo si ya esta tregistrado este tipode Documento

            Dim dt As New DataTable
            dt = data.GetDataByRegisterWithIdTerminalAndIdDocument(TerminalActivo.idTerminal, ListDocumentVentas.SelectedValue)
            'si no esta registrado lo insertamos
            If Not dt.Rows.Count > 0 Then
                If Not (data.InsertPageDefault(TerminalActivo.idTerminal, ListDocumentVentas.SelectedValue) = 1) Then
                    Return False
                End If
            End If


            Select Case myforma
                Case "Personalizar"
                    If data.UpdateTicketPageOne(
                       txtItems.Value,
                       chekColor.Text,
                       txtNameTicketVentas.Text,
                       Me.typePrintComboBox.Text,
                       False,'uno es codigo de configrar independiente
                       TerminalActivo.idTerminal,
                       ListDocumentVentas.SelectedValue
                                          ) = 1 Then

                        Return True
                    End If

                Case "Predeterminado en el sistema"
                    If data.UpdateIsDefaultConfig(True, TerminalActivo.idTerminal, ListDocumentVentas.SelectedValue) = 1 Then
                        Return True
                    End If
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function ActulizaDatoEtiquetas()
        Try
            Dim data As New TerminalConfiTableAdapter
            Dim myforma As String = String.Empty
            For Each item In isDEfaultCheckedListBox.CheckedItems
                myforma = item
            Next
            'leo si ya esta tregistrado este tipode Documento

            Dim dt As New DataTable
            dt = data.GetDataByRegisterWithIdTerminalAndIdDocument(TerminalActivo.idTerminal, ListDocumentEtiquetas.SelectedValue)
            'si no esta registrado lo insertamos
            If Not dt.Rows.Count > 0 Then
                If Not (data.InsertPageDefault(TerminalActivo.idTerminal, ListDocumentEtiquetas.SelectedValue) = 1) Then
                    Return False
                End If
            End If


            Select Case myforma
                Case "Personalizar"
                    If data.UpdateTicketPageOne(
                       100,
                       Nothing,
                       namePrintEtiquetasTextBox.Text,
                       Me.typeprintsCombobox.Text,
                       False,'uno es codigo de configrar independiente
                       TerminalActivo.idTerminal,
                       ListDocumentEtiquetas.SelectedValue
                                          ) = 1 Then

                        Return True
                    End If

                Case "Predeterminado en el sistema"
                    If data.UpdateIsDefaultConfig(True, TerminalActivo.idTerminal, ListDocumentEtiquetas.SelectedValue) = 1 Then
                        Return True
                    End If
            End Select
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
            For Each item In CheckedListBox3.CheckedItems
                myforma = item
            Next
            'leo si ya esta tregistrado este tipode Documento

            Dim dt As New DataTable
            dt = data.GetDataByRegisterWithIdTerminalAndIdDocument(TerminalActivo.idTerminal, ListDocumentVarrios.SelectedValue)
            'si no esta registrado lo insertamos
            If Not dt.Rows.Count > 0 Then
                If Not (data.InsertPageDefault(TerminalActivo.idTerminal, ListDocumentVarrios.SelectedValue) = 1) Then
                    Return False
                End If
            End If


            Select Case myforma
                Case "Personalizar"
                    If data.UpdateTicketPageOne(
                       NumericUpDown2.Value,
                       CheckedListBox5.Text,
                       TextBox4.Text,
                       Me.ComboBox2.Text,
                       False,'uno es codigo de configrar independiente
                       TerminalActivo.idTerminal,
                       ListDocumentVarrios.SelectedValue
                                          ) = 1 Then

                        Return True
                    End If

                Case "Predeterminado en el sistema"
                    If data.UpdateIsDefaultConfig(True, TerminalActivo.idTerminal, ListDocumentVarrios.SelectedValue) = 1 Then
                        Return True
                    End If
            End Select
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If SeleccionarImpresora() Then
            Me.TextBox4.Text = prtSettings.PrinterName
        End If
    End Sub

#End Region
End Class