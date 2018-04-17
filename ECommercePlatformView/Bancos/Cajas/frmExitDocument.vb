Imports CADsisVenta
Public Class frmExitDocument
    Protected Friend ListDocument As List(Of DocumentInTerminal)

    Private TotalValue As Double

    Protected Friend idbodega As Integer
    Protected Friend IdCajaStado As Integer
    Protected Friend IdCaja As Integer
    Protected Friend IdFormaPago As Integer
    Protected Friend MontoDivisa As Double
    Sub New(ByVal idBodega As Integer, ByVal montoDivisa As Double, _idCajaStado As Integer, _idformaPago As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idbodega = idBodega
        Me.MontoDivisa = montoDivisa
        Me.IdCajaStado = _idCajaStado
        Me.IdFormaPago = _idformaPago
        ListDocument = New List(Of DocumentInTerminal)
    End Sub
    Private Sub frmExitDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_ListDocument()
        DepositorBanckRadioButton.Checked = True
    End Sub

    Private Sub Load_ListDocument()
        ListDocument.Clear()
        TotalValue = 0
        Try
            Using db As New DataContext
                Dim myListDomunet = From cob In db.CobroDetail
                                    Join doc In db.CobroDocumento On cob.idCobroDetail Equals doc.idCobroDetail
                                    Join caj In db.CajaDetailDocument On doc.idCobroDocumento Equals caj.idCobroDocumento
                                    Join cue In db.BancosCuentas On doc.idBancoDetail Equals cue.idBancoCuenta
                                    Join ban In db.Bancos On cue.idBanco Equals ban.idBanco
                                    Where caj.idCajaStado = Me.IdCajaStado And caj.isArching = 0
                                    Select caj.idCajaDetailCheque, ban.nom_Banco, cue.num_Cuenta, doc.Num_Documento, cob.val_Cobro

                For Each item In myListDomunet
                    Dim document As New DocumentInTerminal With
                    {
                        .idCajaDetailCheque = item.idCajaDetailCheque,
                        .IsSelected = True,
                        .nom_Banco = item.nom_Banco,
                        .num_Cuenta = item.num_Cuenta,
                        .Num_Documento = item.Num_Documento,
                        .val_Cobro = item.val_Cobro
                    }
                    ListDocument.Add(document)
                    TotalValue += document.val_Cobro
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ViewData()
        End Try
    End Sub
    Private Sub ViewData()
        Try
            dtg.DataSource = Me.ListDocument
            applyGridTheme(dtg)
            dtg.RowHeadersWidth = 5

            clm = dtg.Columns("idCajaDetailCheque")
            clm.Visible = False

            clm = dtg.Columns("IsSelected")
            clm.HeaderText = "    "
            clm.DisplayIndex = 1

            clm = dtg.Columns("nom_Banco")
            clm.HeaderText = "Banco"

            clm = dtg.Columns("num_Cuenta")
            clm.HeaderText = "Cuenta"

            clm = dtg.Columns("Num_Documento")
            clm.HeaderText = "Nro documento" 'val_Cobro

            clm = dtg.Columns("val_Cobro")
            clm.HeaderText = "Valor documento"
            clm.DefaultCellStyle = myStileMoney

            Me.TotalValueListLabel.Text = "Total valor: " & TotalValue.ToString("C2")
            TotalDocumentsLabel.Text = "Total documentos: " & ListDocument.Count.ToString("N")
            ViewSelect()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DepositorBanckRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DepositorBanckRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("PanelDepositorBanck")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub
    Private Function ControlCheck(sender As System.Object) As Boolean
        Try
            If Not (DirectCast(sender, RadioButton).Checked) Then
                Return False
            End If

            Select Case DirectCast(sender, RadioButton).Name
                Case "DepositorBanckRadioButton"
                    Return SetDepositorBanck()
                Case "BankAccountRadioButton"

                Case "PaymentProviderRadioButton"

                Case "AccountEmployeeRadioButton"

                Case ""

                Case ""


            End Select

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Function SetDepositorBanck() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim frmdat As New frmChiltExitDocumentBanck(Me, Me.IdCajaStado, Me.IdFormaPago, Me.MontoDivisa)

            Dim controlView = frmdat.PanelView
            PanelViewData.Controls.Add(controlView)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub dtg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick
        If e.RowIndex > -1 And e.ColumnIndex = dtg.Columns("IsSelected").Index Then
            dtg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not dtg.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            ViewSelect()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For Each item As DataGridViewRow In dtg.Rows
            item.Cells(dtg.Columns("IsSelected").Index).Value = CheckBox1.Checked
        Next
        ViewSelect()
    End Sub
    Private Sub ViewSelect()
        Try
            Me.MontoDivisa = 0

            If IsNothing(ListDocument) Then
                Return
            End If

            Dim _TotalSelect = Aggregate sel In ListDocument
                                   Where sel.IsSelected = True
                                   Into Sum(sel.val_Cobro)

            If Not IsNothing(_TotalSelect) Then
                Me.MontoDivisa = _TotalSelect
            End If

            Me.totalSelectLabel.Text = Me.MontoDivisa.ToString("C2")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class