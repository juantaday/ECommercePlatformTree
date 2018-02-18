Imports CADsisVenta.DataSetMonedasTableAdapters
Imports CADsisVenta.DataSetSystemTableAdapters

Public Class FrmSaldo_caja
    Protected Friend codTerminal As String
    Protected Friend idTerminal As Integer
    Private idCajaStado As Integer
    Private msgSelect As String
    Private isVisibleMenu As Boolean
    Public Sub New(idCajaStado As Integer, ByVal isVisibleMenu As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idCajaStado = idCajaStado
        Me.isVisibleMenu = isVisibleMenu
    End Sub
    Private Sub FrmSaldo_caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msgSelect = String.Empty
        If IsNothing(codTerminal) Then
            'cod 0 not terminal
            Not_Data(1)
            Return
        Else
            NameCajaLabel.Text = "Estado de caja: " + codTerminal
        End If
        Carga_Datos(Me.idCajaStado)
        Me.AbrirCajaToolStripMenuItem.Enabled = isVisibleMenu
    End Sub
    Private Sub Carga_Datos(idCajaStado As Integer)
        Dim dt As New DataTable
        Dim dtList As New DataTable
        Dim listAdap As New CajaStadoTableAdapter
        Dim listDetail As New SaldoCajaTableAdapter
        Dim _saldo As Double = 0


        PanelView.Controls.Clear()
        Try
            'Carga  datos  Abiertos
            If idCajaStado > 0 Then
                dtList = listAdap.GetDataByIdCajaStado(idCajaStado)
            Else
                dtList = listAdap.GetDataByListCajaStado(idTerminal, 1)
            End If

            For Each row As DataRow In dtList.Rows
                _saldo = 0
                dt = listDetail.GetData(row("idCajaStado"))
                Dim colSaldos As New System.Data.DataColumn With {
                    .ColumnName = "Saldo",
                    .DataType = System.Type.GetType("System.Decimal")}
                dt.Columns.Add(colSaldos)
                For Each rowSaldo As DataRow In dt.Rows
                    rowSaldo("Saldo") = (rowSaldo("SaldoInicial") + rowSaldo("Debe")) - rowSaldo("Haber")
                    _saldo += rowSaldo("Saldo")
                Next
                If dt.Rows.Count > 0 Then
                    Inicializa_Controls()
                    sql = "Abierto/ Operación N°:" & row("idCajaStado")
                    If (row("isAllUser")) Then
                        sql = sql & "/ Para:Todos"
                    Else
                        sql = sql & "/ Para:" & row("own_User")
                    End If
                    ButtonTitle.Text = sql
                    itemCheckBox.Text = sql
                    ButtonTitle.Tag = row("idCajaStado")
                    LabelTotal_op.Text = "Saldo total ==> " & _saldo.ToString("C2")
                    LabelTotal_op.Tag = _saldo
                    itemCheckBox.Tag = row("idCajaStado")
                    DtgView.DataSource = dt
                    MyApp()
                End If
            Next
            'Carga datos en suspendidos
            If idCajaStado > 0 Then
                Return
            Else
                dtList = listAdap.GetDataByListCajaStado(idTerminal, 2)
            End If
            For Each row As DataRow In dtList.Rows
                _saldo = 0
                dt = listDetail.GetData(row("idCajaStado"))
                Dim colSaldos As New System.Data.DataColumn With {
                    .ColumnName = "Saldo",
                    .DataType = System.Type.GetType("System.Decimal")}
                dt.Columns.Add(colSaldos)
                For Each rowSaldo As DataRow In dt.Rows
                    rowSaldo("Saldo") = (rowSaldo("SaldoInicial") + rowSaldo("Debe")) - rowSaldo("Haber")
                    _saldo += rowSaldo("Saldo")
                Next
                If dt.Rows.Count > 0 Then
                    Inicializa_Controls()
                    sql = "Hibernado(suspendido)/ Operación N°:" & row("idCajaStado")
                    If (row("isAllUser")) Then
                        sql = sql & "/ Para:Todos"
                    Else
                        sql = sql & "/ Para:" & row("own_User")
                    End If
                    ButtonTitle.Text = sql
                    itemCheckBox.Text = sql
                    ButtonTitle.Tag = dt.Rows(0)("idCajaStado")
                    LabelTotal_op.Text = "Saldo total ==> " & _saldo.ToString("C2")
                    LabelTotal_op.Tag = _saldo
                    itemCheckBox.Tag = row("idCajaStado")
                    DtgView.DataSource = dt
                    MyApp()
                End If
            Next
            Return

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ArqueoDeCajaToolStripMenuItem.Enabled = False
            HibernarToolStripMenuItem.Enabled = False
            EliminarToolStripMenuItem.Enabled = False
            If PanelView.Controls.Count = 0 Then
                NameCajaLabel.AutoSize = False
                NameCajaLabel.Height = 20
                NameCajaLabel.Dock = DockStyle.Top
                NameCajaLabel.Text = "No existe operaciones abiertas o suspendidas.."

                NameCajaLabel.Visible = True
                Dim LinkLabelNew As New System.Windows.Forms.LinkLabel With {
                    .AutoSize = False,
                    .Height = 18,
                    .Dock = DockStyle.Top,
                    .Text = "Abrir nueva operación.."}

                PanelView.Controls.Add(LinkLabelNew)
                PanelView.Controls.Add(NameCajaLabel)
                AddHandler LinkLabelNew.LinkClicked, AddressOf LinkLabelNew_LinkClicked
            End If
        End Try
    End Sub

    Private Sub LinkLabelNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        AbrirCajaToolStripMenuItem.PerformClick()
    End Sub

    Private Sub MyApp()
        Try
            applyGridTheme(DtgView)
            clm = DtgView.Columns(DtgView.Columns("idCajaStado").Index)
            clm.Visible = False

            clm = DtgView.Columns(DtgView.Columns("idFormaPago").Index)
            clm.Visible = False

            clm = DtgView.Columns(DtgView.Columns("FormaPago").Index)
            clm.HeaderText = "Forma de pago"
            clm.Width = 150

            clm = DtgView.Columns(DtgView.Columns("SaldoInicial").Index)
            clm.HeaderText = "Saldo inicial"
            clm.DefaultCellStyle = myStileMoney

            clm = DtgView.Columns(DtgView.Columns("Debe").Index)
            clm.DefaultCellStyle = myStileMoney

            clm = DtgView.Columns(DtgView.Columns("Haber").Index)
            clm.DefaultCellStyle = myStileMoney

            clm = DtgView.Columns(DtgView.Columns("Saldo").Index)
            clm.DefaultCellStyle = myStileMoney
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Inicializa_Controls()
        Try
            'inicialiti
            Dim font As New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Dim font_total As New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PanelData = New System.Windows.Forms.Panel With {
                           .Height = 180,
                           .Name = "PanelData",
                           .BorderStyle = BorderStyle.FixedSingle,
                           .Dock = DockStyle.Top
                           }
            Me.PanelTop = New System.Windows.Forms.Panel With {
                           .Name = "PanelTop",
                           .Height = 30,
                           .Dock = DockStyle.Top}
            Me.PanelLeft = New System.Windows.Forms.Panel With {
                           .Name = "PanelLeft",
                           .Width = 35,
                           .Dock = DockStyle.Left}
            Me.itemCheckBox = New System.Windows.Forms.CheckBox With {
                           .Name = "itemCheckBox",
                           .Width = 20,
                           .ForeColor = Color.Transparent,
                           .Dock = DockStyle.Left
                           }
            Me.ButtonTitle = New System.Windows.Forms.Button With {
                           .AutoSize = True,
                           .Height = 30,
                           .Name = "ButtonTitle",
                           .TextAlign = ContentAlignment.BottomLeft,
                           .UseVisualStyleBackColor = False,
                           .FlatStyle = FlatStyle.Flat,
                           .Dock = DockStyle.Left,
                           .Font = font,
                           .Cursor = Cursors.Hand}
            Me.PanelList = New System.Windows.Forms.Panel With {
                           .Name = "PanelList",
                           .Dock = DockStyle.Fill}
            Me.DtgView = New System.Windows.Forms.DataGridView With {
                           .Name = "DtgView",
                           .Dock = DockStyle.Fill}
            Me.LabelTotal_op = New System.Windows.Forms.Label With {
                           .Name = "LabelTotal_op",
                           .AutoSize = False,
                           .Height = 20,
                           .ForeColor = Color.Black,
                           .Font = font_total,
                           .Dock = DockStyle.Bottom}

            'ButtonTitle.FlatAppearance.BorderSize = 0
            'ButtonTitle.FlatAppearance.MouseDownBackColor = Color.Blue
            'ButtonTitle.FlatAppearance.MouseOverBackColor = Color.OrangeRed
            ButtonTitle.ForeColor = Color.Red
            'Organizacion
            PanelList.SuspendLayout()
            PanelList.Controls.Add(LabelTotal_op)
            PanelList.Controls.Add(DtgView)
            'data
            PanelData.SuspendLayout()
            PanelData.Controls.Add(PanelList)

            PanelData.Controls.Add(PanelLeft)
            PanelData.Controls.Add(PanelTop)
            PanelTop.Controls.Add(ButtonTitle)
            PanelTop.Controls.Add(itemCheckBox)

            'suspende A matris
            PanelView.SuspendLayout()
            PanelView.Controls.Add(PanelData)
            '
            'actulizamos los datos
            PanelList.ResumeLayout()
            PanelLeft.ResumeLayout()
            PanelTop.ResumeLayout()
            ButtonTitle.ResumeLayout()
            PanelData.ResumeLayout()
            PanelView.ResumeLayout()
            'generacion de eventos
            AddHandler ButtonTitle.Click, AddressOf ButtonTitle_Click_Format
            AddHandler ButtonTitle.Click, AddressOf ButtonTitle_Click_ActionDetail
            'AddHandler ButtonTitle.Click, AddressOf ButtonTitle_Click_ActionEnableMenu
            AddHandler itemCheckBox.CheckedChanged, AddressOf itemCheckBox_CheckedChanged
            AddHandler DtgView.DataBindingComplete, AddressOf DataGridViewSearchReport_DataBindingComplete
            AddHandler DtgView.CellContentClick, AddressOf DataGridView_CellContentClick

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGridViewSearchReport_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        For Each row As DataGridViewRow In sender.Rows
            If Not IsNothing(row.Cells("FormaPago")) Then
                row.Cells("FormaPago") = New DataGridViewLinkCell
            End If
        Next
    End Sub
    Private Sub ButtonTitle_Click_ActionEnableMenu(sender As Object, e As EventArgs)
        Try
            sql = sql
            For Each pnlData In PanelView.Controls
                For Each pnlTop In pnlData.Controls
                    If pnlTop.Name.Equals("PanelTop") Then
                        For Each iteBotChec In pnlTop.Controls
                            If iteBotChec.Name.Equals("itemCheckBox") Then
                                If Not DirectCast(iteBotChec, CheckBox).Tag = sender.Tag Then
                                    DirectCast(iteBotChec, CheckBox).Checked = False
                                End If
                            End If
                        Next
                    End If
                Next
            Next
            If sender.Text.Contains("Abierto") Or sender.Text.Contains("Hiberna") Then
                If sender.Text.Contains("suspendido") Then
                    HibernarToolStripMenuItem.Enabled = False
                Else
                    HibernarToolStripMenuItem.Enabled = True
                End If
                ArqueoDeCajaToolStripMenuItem.Enabled = True
                EliminarToolStripMenuItem.Enabled = True
                ArqueoDeCajaToolStripMenuItem.ToolTipText = "Arqueo de caja N°: " & sender.tag
                ArqueoDeCajaToolStripMenuItem.Tag = sender.tag
                msgSelect = sender.Text
            Else
                ArqueoDeCajaToolStripMenuItem.Enabled = False
                HibernarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonTitle_Click_ActionDetail(sender As Object, e As EventArgs)
        Try
            If IsNumeric(sender.tag) Then
                TitleDetailLabel.Text = String.Empty
                TitleDeatailInformationLabel.Text = String.Empty

                Dim adt As New CajaDescripTableAdapter
                Dim dt As New DataTable
                dt = adt.GetData(sender.tag)
                If Not dt.Rows.Count = 0 Then
                    sql = "Operación:" & vbNewLine
                    sql = sql & dt.Rows(0)("idCajaStado")
                    TitleDetailLabel.Text = sql

                    sql = "Estado: " & dt.Rows(0)("Stado") & vbNewLine
                    sql = sql & "Fecha apertura: " & vbNewLine & dt.Rows(0)("Inicio") & vbNewLine
                    sql = sql & "Ultimo movimiento: " & vbNewLine & dt.Rows(0)("UltimoMovi") & vbNewLine
                    sql = sql & "Total movimientos: " & vbNewLine & dt.Rows(0)("Registros") & vbNewLine
                    sql = sql & "Total usuarios: " & dt.Rows(0)("Usuarios") & vbNewLine
                    Dim hibernar As String = Convert.ToString(dt.Rows(0)("Hiberna"))
                    If Not String.IsNullOrWhiteSpace(hibernar) Then
                        sql = sql & "Suspendido " & hibernar & vbNewLine
                    End If
                    Dim cierre As String = Convert.ToString(dt.Rows(0)("Cierre"))
                    If Not String.IsNullOrWhiteSpace(cierre) Then
                        sql = sql & "Cerrado: " & hibernar & vbNewLine
                    End If
                    TitleDeatailInformationLabel.Text = sql
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButtonTitle_Click_Format(sender As Object, e As EventArgs)
        Try
            Dim _controName As String = sender.name
            Dim _panel As System.Windows.Forms.Panel = sender.Parent
            _panel.Tag = 1
            Dim ClicKado As Boolean = False

            For Each _control In PanelView.Controls
                ClicKado = False
                If IsNumeric(_control.tag) Then
                    If _control.tag = 1 Then
                        ClicKado = True
                    Else
                        ClicKado = False
                    End If
                Else
                    ClicKado = False
                End If
                For Each _control2 In _control.Controls
                    If _control2.name.ToString.Equals(_controName) Then
                        If ClicKado Then
                            _control2.BackColor = Color.Red
                            _control2.ForeColor = Color.White
                        Else
                            _control2.BackColor = _control.BackColor
                            _control2.ForeColor = Color.Red
                        End If
                    End If
                Next
                _control.tag = 0
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Not_Data(cod As Integer)
        Dim mesag As String = String.Empty
        Select Case cod
            Case 0
                mesag = "No se deternino el código de caja"
            Case 1
                mesag = "No existe información"
        End Select
        Dim label As New System.Windows.Forms.Label With {
        .Text = mesag,
        .Dock = DockStyle.Fill}
        Me.Controls.Add(label)
    End Sub
    Private Sub MaxiDetailButton_Click(sender As Object, e As EventArgs) Handles MaxiDetailButton.Click
        Try
            Dim maxize As Boolean = False
            If IsNumeric(sender.tag) Then
                If sender.tag = 0 Then
                    maxize = False
                    sender.tag = 1
                Else
                    sender.tag = 0
                    maxize = True
                End If
            Else
                maxize = False
                sender.tag = 1
            End If

            PanelDetail.Visible = maxize
            PanelDetail.Dock = DockStyle.Right
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AbrirCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirCajaToolStripMenuItem.Click
        Try
            Using frmNewOperationCaja
                With frmNewOperationCaja
                    .idTerminal = idTerminal
                    .codTerminalTextBox.Text = codTerminal
                    .Operation = _operation.Insert
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Carga_Datos(Me.idCajaStado)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            If (MsgBox("Está seguro de eliminar." & vbNewLine & msgSelect,
                MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda")) = MsgBoxResult.Yes Then
                Dim id As Nullable(Of Integer) = ArqueoDeCajaToolStripMenuItem.Tag
                If Not id = 0 Then
                    Dim tap As New CajaStadoTableAdapter
                    If Not tap.DeleteCajaStado(id) = 0 Then
                        Carga_Datos(Me.idCajaStado)
                    End If
                End If
            End If
        Catch ex As Exception
            If ex.Message.Contains("REFERENCE") Then
                sql = "Esta operación ya tiene movimientos." & vbNewLine
                sql = sql & "Imposible eliminar.."
                MsgBox(sql, MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If

        End Try
    End Sub

    Private Sub HibernarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HibernarToolStripMenuItem.Click
        Try
            Dim id As Nullable(Of Integer) = ArqueoDeCajaToolStripMenuItem.Tag
            If Not id = 0 Then
                sql = "Está seguro de hibernar (suspender)" + vbNewLine
                sql = sql & msgSelect
                If (MsgBox(sql, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda")) = MsgBoxResult.Yes Then
                    Dim tap As New CajaStadoTableAdapter
                    If Not tap.UpdateCajaStado_State(id) = 0 Then
                        Carga_Datos(Me.idCajaStado)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex >= 0 And e.ColumnIndex = sender.Columns("FormaPago").Index Then
                sql = sql
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub itemCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Try
            Me.AbrirCajaToolStripMenuItem.Enabled = isVisibleMenu

            If DirectCast(sender, System.Windows.Forms.CheckBox).Checked Then
                ButtonTitle_Click_ActionEnableMenu(sender, e)
                DirectCast(sender, System.Windows.Forms.CheckBox).BackColor = Color.Purple
            Else
                DirectCast(sender, System.Windows.Forms.CheckBox).BackColor = Color.White
                ArqueoDeCajaToolStripMenuItem.Enabled = False
                HibernarToolStripMenuItem.Enabled = False
                EliminarToolStripMenuItem.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ArqueoDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArqueoDeCajaToolStripMenuItem.Click
        Try
            Using newform As New frmCajaDetail(ArqueoDeCajaToolStripMenuItem.Tag)
                With newform
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Me.idCajaStado = 0
                        Carga_Datos(Me.idCajaStado)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Friend WithEvents PanelData As System.Windows.Forms.Panel
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents PanelList As System.Windows.Forms.Panel
    Friend WithEvents ButtonTitle As System.Windows.Forms.Button
    Friend WithEvents DtgView As System.Windows.Forms.DataGridView
    Friend WithEvents LinkLabelNew As System.Windows.Forms.LinkLabel
    Friend WithEvents LabelTotal_op As System.Windows.Forms.Label
    Friend WithEvents itemCheckBox As System.Windows.Forms.CheckBox

End Class