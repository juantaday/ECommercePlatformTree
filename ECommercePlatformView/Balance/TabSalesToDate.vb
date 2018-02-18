Imports CADsisVenta.DataSetReport
Imports CADsisVenta.DataSetReportTableAdapters
Imports CrystalDecisions.CrystalReports.Engine

Public Class TabSalesToDate
    Private isLoated As Boolean
    Private adt As GetSalesByDateTableAdapter
    Private dt As GetSalesByDateDataTable

    Private rpt As ReportDocument
    Private dateFilter As Date
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dt = New GetSalesByDateDataTable
        adt = New GetSalesByDateTableAdapter
        rpt = New ReportDocument
        dateFilter = Date.Now
        Load_Report()
    End Sub
    Private Sub TabSalesToDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Bodega()
        isLoated = True
    End Sub
    Private Sub NowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles NowRadioButton.CheckedChanged,
            YesterdayRadioButton.CheckedChanged, BeforeYesterdayRadioButton.CheckedChanged, DetermineDateRadioButton.CheckedChanged
        Try
            If DirectCast(sender, Windows.Forms.RadioButton).Checked Then
                If Me.BodegasComboBox.SelectedIndex > -1 Then
                    Me.DateTimePicker1.Enabled = sender.Name.ToString.Equals("DetermineDateRadioButton")
                    ManegerSelect()
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & "" & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ManegerSelect()
        Try
            Dim nameSelectControl As String = String.Empty

            If Me.BodegasComboBox.SelectedIndex = -1 Then
                Return
            End If

            For Each control As Windows.Forms.Control In Me.PanelRadioButons.Controls
                Dim cnt = CType(control, Windows.Forms.RadioButton)
                If cnt.Checked Then
                    nameSelectControl = control.Name
                    Exit For
                End If
            Next
            Dim _date As Date = Date.Now
            Select Case nameSelectControl
                Case "NowRadioButton"
                    Load_Data(_date)
                Case "YesterdayRadioButton"
                    Load_Data(_date.AddDays(-1))
                Case "BeforeYesterdayRadioButton"
                    Load_Data(_date.AddDays(-2))
                Case "DetermineDateRadioButton"
                    Load_Data(DateTimePicker1.Value)
            End Select
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & "" & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Load_Report()
        Try
            rpt.Load(file_rptViewSalesByDate)
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & vbCrLf & " LUGAR:" & ex.StackTrace & vbCrLf & " Direccion reporte:" & file_rptViewSalesByDate, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SetParameters()
        rpt.SetParameterValue(2, UsuarioActivo.codUser)
        rpt.SetParameterValue(3, Me.BodegasComboBox.Text)
        rpt.SetParameterValue(4, dateFilter.ToString("dd/MMM/yyyy"))
        rpt.SetParameterValue(5, EcommerceActive.RazonSocial)
    End Sub


    Private Sub Load_Data(filter As Date)
        dateFilter = filter
        Dim _idBodega = Me.BodegasComboBox.SelectedValue
        If IsNothing(_idBodega) Then
            MsgBox("No se ha cargado el local o bodega a consultar.", MsgBoxStyle.Exclamation, "Aviso")
            Return
        End If
        Try
            Me.rptViewer.ReportSource = Nothing
            Me.adt.Fill(dt, dateFilter, _idBodega)
            If Not (dt.Rows.Count > 0) Then
                Me.Cursor = Cursors.Default
                MsgBox("No hay información", MsgBoxStyle.Information, "Aviso")
            Else
                rpt.SetDataSource(CType(dt, DataTable))
                SetParameters()
                Me.rptViewer.ReportSource = rpt
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message & "" & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub Load_Bodega()
        Try
            Using db As New DataContext
                Dim lis = (From b In db.Bodegas).ToList()

                Me.BodegasComboBox.DataSource = lis
                Me.BodegasComboBox.DisplayMember = "Nom_Bodega"
                Me.BodegasComboBox.ValueMember = "idBodega"
                Me.BodegasComboBox.SelectedValue = TerminalActivo.idBodega
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "" & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BodegasComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BodegasComboBox.SelectedIndexChanged
        If isLoated Then
            ManegerSelect()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If isLoated Then
            ManegerSelect()
        End If
    End Sub

End Class
