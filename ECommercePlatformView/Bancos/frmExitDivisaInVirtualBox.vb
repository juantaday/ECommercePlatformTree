Imports CADsisVenta
Imports CADsisVenta.DataSetSystemTableAdapters
Imports DGVPrinterHelper

Public Class frmExitDivisaInVirtualBox
    Private IsLoad As Boolean
    Private _VirtualBox As List(Of VirtualBox)
    Private Sub frmExitDivisaInVirtualBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _VirtualBox = New List(Of VirtualBox)
        Load_Bodega()
        IsLoad = True
        Me.Cursor = Cursors.Default
        DescriptionLabel.Text = String.Empty
    End Sub
    Private Sub Load_Bodega()
        Try
            Dim dat As New BodegaSystemTableAdapter
            Dim dt As New DataTable
            dt = dat.GetData()
            If dt.Rows.Count > 0 Then
                ListBodegaComboBox.DataSource = dt
                ListBodegaComboBox.DisplayMember = "Nom_Bodega"
                ListBodegaComboBox.ValueMember = "idBodega"
                ListBodegaComboBox.SelectedIndex = -1
                If Not (IsNothing(TerminalActivo)) And IsNumeric(TerminalActivo.idBodega) Then
                    ListBodegaComboBox.SelectedValue = TerminalActivo.idBodega
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ListBodegaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBodegaComboBox.SelectedIndexChanged
        If ListBodegaComboBox.SelectedIndex >= 0 And ListBodegaComboBox.ValueMember.ToString.Length > 0 Then
            Load_VirtualBox(ListBodegaComboBox.SelectedValue)
        End If
    End Sub

    Private Sub Load_VirtualBox(_idBodega As Integer)
        Try
            _VirtualBox.Clear()
            IsLoad = False
            Using db As New DataContext
                Dim item_VirtualBox = From vb In db.VirtualBox
                                      Where vb.idBodega = _idBodega
                                      Select vb.idVirtualBox, vb.NameVirtualBox, vb.Saldo, vb.remark, vb.TypeVirtualBox

                For Each item In item_VirtualBox
                    _VirtualBox.Add(New VirtualBox With
                                    {
                                    .idVirtualBox = item.idVirtualBox,
                                    .NameVirtualBox = item.NameVirtualBox,
                                    .Saldo = item.Saldo,
                                    .remark = item.remark,
                                    .TypeVirtualBox = item.TypeVirtualBox
                                    })
                Next



                VirtualBoxComboBox.DataSource = Nothing
                Me.VirtualBoxComboBox.DataSource = _VirtualBox
                VirtualBoxComboBox.DisplayMember = "NameVirtualBox"
                VirtualBoxComboBox.ValueMember = "idVirtualBox"
                VirtualBoxComboBox.SelectedIndex = -1
                VirtualBoxComboBox.Text = "Selecione una caja virtual."
                Me.virtualNameSelectTextBox.Text = VirtualBoxComboBox.Text
                If _VirtualBox.Count = 1 Then
                    IsLoad = True
                    VirtualBoxComboBox.SelectedValue = _VirtualBox.FirstOrDefault().idVirtualBox
                Else
                    dtg.DataSource = Nothing
                    SaldoVirtualLabel.Text = String.Empty
                    DebitRadioButton.Enabled = False
                    CreditRadioButton.Enabled = False
                    ByDateRadioButton.Enabled = False
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            IsLoad = True
        End Try
    End Sub
    Private Sub VirtualBoxComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VirtualBoxComboBox.SelectedIndexChanged
        Try
            Me.virtualNameSelectTextBox.Text = String.Empty
            Me.NewExitDivisaButton.Visible = False
            If VirtualBoxComboBox.SelectedIndex >= 0 And VirtualBoxComboBox.ValueMember.ToString.Length > 0 Then
                Dim Saldo As Double = 0
                Dim _saldo As Double? = _VirtualBox.Where(Function(x) x.idVirtualBox = Me.VirtualBoxComboBox.SelectedValue).FirstOrDefault().Saldo
                If _saldo > 0 Then
                    Saldo = _saldo
                End If

                Me.SaldoVirtualLabel.Text = String.Format("Saldo de caja virtual {0} : {1}", VirtualBoxComboBox.Text, Saldo.ToString("C2"))
                Me.NewExitDivisaButton.Visible = True
                Me.virtualNameSelectTextBox.Text = VirtualBoxComboBox.Text

                DebitRadioButton.Enabled = True
                CreditRadioButton.Enabled = True
                ByDateRadioButton.Enabled = True

                DebitRadioButton.Checked = False
                DebitRadioButton.Checked = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If VirtualBoxComboBox.SelectedIndex = -1 Then
                SaldoVirtualLabel.Text = String.Empty
            End If
        End Try

    End Sub

    Private Sub Load_VirtualBoxDetail(_idVirtualBox As Integer, isDebit As Boolean)
        Try
            IsLoad = False
            DescriptionLabel.Text = String.Empty
            dtg.DataSource = Nothing
            Using db As New DataContext
                Dim _VirtualBoxDetails As IQueryable = Nothing

                If isDebit Then
                    _VirtualBoxDetails = (From v In db.VirtualBoxDetails
                                          Where v.idVirtualBox = _idVirtualBox And v.haber <> 0
                                          Order By v.idVirtualBoxDetails Descending
                                          Select v.idVirtualBoxDetails, v.DateTimeTransfer, v.haber, v.Descripcion) _
                                          .Take(10)
                Else
                    _VirtualBoxDetails = (From v In db.VirtualBoxDetails
                                          Where v.idVirtualBox = _idVirtualBox And v.debe <> 0
                                          Order By v.idVirtualBoxDetails Descending
                                          Select v.idVirtualBoxDetails, v.DateTimeTransfer, v.debe, v.Descripcion) _
                                        .Take(10)
                End If

                dtg.DataSource = _VirtualBoxDetails
                clm = dtg.Columns("idVirtualBoxDetails")
                clm.Visible = False

                clm = dtg.Columns("DateTimeTransfer")
                clm.HeaderText = "Fecha de salida"
                clm.DisplayIndex = 1

                If isDebit Then
                    clm = dtg.Columns("DateTimeTransfer")
                    clm.HeaderText = "Fecha de salida"
                    clm.DisplayIndex = 1

                    clm = dtg.Columns("haber")
                    clm.HeaderText = "Valor"
                    clm.DisplayIndex = 2
                Else
                    clm = dtg.Columns("DateTimeTransfer")
                    clm.HeaderText = "Fecha de ingreso"
                    clm.DisplayIndex = 1

                    clm = dtg.Columns("debe")
                    clm.HeaderText = "Valor"
                    clm.DisplayIndex = 2
                End If


                clm = dtg.Columns("Descripcion")
                clm.HeaderText = "Descripción"
                clm.DisplayIndex = 3

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            IsLoad = True
        End Try
    End Sub

    Private Sub VirtualBoxComboBox_DropDown(sender As Object, e As EventArgs) Handles VirtualBoxComboBox.DropDown
        VirtualBoxComboBox.Width = 120
        Me.NewExitDivisaButton.Visible = False
    End Sub

    Private Sub VirtualBoxComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles VirtualBoxComboBox.DropDownClosed
        VirtualBoxComboBox.Width = 22
    End Sub

    Private Sub dtg_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.RowEnter
        If IsLoad Then
            DescriptionLabel.Text = dtg.Rows(e.RowIndex).Cells(dtg.Columns("Descripcion").Index).Value.ToString()
        End If
    End Sub

    Private Sub NewExitDivisaButton_Click(sender As Object, e As EventArgs) Handles NewExitDivisaButton.Click
        Try
            Dim ValueExit As Double = 0
            Using _frmImputData As New frmImputData
                With _frmImputData
                    .Text = "Determine el monto de salida."
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        ValueExit = .txtNumber.Value
                    Else
                        Return
                    End If
                End With
            End Using
            Using NewExit As New frmExitMoneyVirtualBox(Me.ListBodegaComboBox.SelectedValue, ValueExit, Me.VirtualBoxComboBox.SelectedValue, 1)
                With NewExit
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        DebitRadioButton.Checked = False
                        DebitRadioButton.Checked = True
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DebitRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DebitRadioButton.CheckedChanged
        If DebitRadioButton.Checked And IsLoad Then
            Load_VirtualBoxDetail(VirtualBoxComboBox.SelectedValue, True)
        End If
    End Sub

    Private Sub CreditRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CreditRadioButton.CheckedChanged
        If CreditRadioButton.Checked And IsLoad Then
            Load_VirtualBoxDetail(VirtualBoxComboBox.SelectedValue, False)
        End If
    End Sub

    Private Sub ByDateRadioButton_Click(sender As Object, e As EventArgs) Handles ByDateRadioButton.Click
        If ByDateRadioButton.Checked Then
            SettDatingForMoviments()
        End If
    End Sub

    Private Sub SettDatingForMoviments()
        Try
            If Not ByDateRadioButton.Checked Then
                Return
            End If

            Dim date1 As Date = Nothing
            Dim date2 As Date = Nothing

            If ByDateRadioButton.Checked And IsLoad Then
                Using newdata As New FrmImputDate
                    With newdata
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            date1 = .DateStart.Value
                            date2 = .DateEnd.Value
                        Else
                            Return
                        End If
                    End With
                End Using
                Load_VirtualBoxDetailByDate(VirtualBoxComboBox.SelectedValue, date1, date2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Load_VirtualBoxDetailByDate(_idVirtualBox As Integer, date1 As Date, date2 As Date)
        Try
            IsLoad = False
            Me.Cursor = Cursors.WaitCursor
            DescriptionLabel.Text = String.Empty
            dtg.DataSource = Nothing
            Using db As New DataContext

                Dim _VirtualBoxDetails = From l In db.GetListMovimentInVirtualBox(_idVirtualBox, date1, date2)


                dtg.DataSource = _VirtualBoxDetails.ToList()
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

                clm = dtg.Columns("idVirtualBoxDetails")
                clm.Visible = False

                clm = dtg.Columns("DateTimeTransfer")
                clm.HeaderText = "Fecha de movimiento"
                clm.DisplayIndex = 1
                clm.Width = 120

                clm = dtg.Columns("debe")
                clm.HeaderText = "Debe"
                clm.DisplayIndex = 2
                clm.Width = 80

                clm = dtg.Columns("haber")
                clm.HeaderText = "Haber"
                clm.DisplayIndex = 3
                clm.Width = 80

                clm = dtg.Columns("saldo")
                clm.HeaderText = "Saldo"
                clm.DisplayIndex = 4
                clm.Width = 80

                clm = dtg.Columns("Descripcion")
                clm.HeaderText = "Descripción"
                clm.DisplayIndex = 5
                clm.Width = 80
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
            IsLoad = True
        End Try
    End Sub

    Private Sub PrintListButton_Click(sender As Object, e As EventArgs) Handles PrintListButton.Click
        If Not dtg.Rows.Count = 0 Then
            Print_List()
        End If
    End Sub

    Private Sub Print_List()
        Try
            Dim eCommerce As String
            Using db As New DataContext
                Dim myCommerce = db.myCommerce.ToList()
                eCommerce = myCommerce(0).RazonSocial
            End Using

            Dim printer As New DGVPrinter
            printer.Title = eCommerce

            sql = "MOVIMIENTOS DE SALIDA EN CAJAS VIRTUALES" & vbCrLf _
                & String.Format("Local o Bodega: {0}", ListBodegaComboBox.Text) & vbCrLf _
                & "Caja virtual: " & Me.VirtualBoxComboBox.Text
            printer.SubTitle = sql
            'printer.SubTitlePrint = String.Format("Fecha: {0}", Date.Now.Date.ToString)
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            printer.TitleSpacing = 8
            printer.PageNumbers = True
            printer.PorportionalColumns = True
            printer.HeaderCellAlignment = StringAlignment.Near
            printer.Footer = String.Format("Impreso: {0} {1}      User: {2}", Date.Now.ToShortDateString, Date.Now.ToShortTimeString, UsuarioActivo.codUser)
            printer.FooterSpacing = 15
            printer.FooterAlignment = StringAlignment.Near
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            printer.PrintDataGridView(dtg)
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub PrintTicketButton_Click(sender As Object, e As EventArgs) Handles PrintTicketButton.Click

    End Sub
End Class