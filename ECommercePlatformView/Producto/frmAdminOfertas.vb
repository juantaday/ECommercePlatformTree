Imports System.Windows.Forms

Public Class frmAdminOfertas
    Private MinimoCant As Double
    Private MaximoCant As Double
    Private isLoad As Boolean
    Private isClosed As Boolean

    Private MinimoPorcent As Double
    Private MaximoPorcent As Double
    Protected Friend NomMedida As String
    Protected Friend desMedida As String
    Protected Friend PrecioNormal As Decimal

    Sub New(MinimoCant As Double, MaximoCant As Double,
        MinimoPorcent As Double, MaximoPorcent As Double, precioNormal As Decimal)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MinimoCant = MinimoCant
        Me.MaximoCant = MaximoCant

        Me.MinimoPorcent = MinimoPorcent
        Me.MaximoPorcent = MaximoPorcent
        Me.PrecioNormal = precioNormal
        'set the values
        aPartirDeNumeric.Minimum = MinimoCant
        aPartirDeNumeric.Maximum = MaximoCant

        porCentageDescuentNumeric.Minimum = MinimoPorcent
        porCentageDescuentNumeric.Maximum = MaximoPorcent
    End Sub
    Private Sub frmAdminOfertas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.precioNormalTextBox.Text = Me.PrecioNormal.ToString("C5")
        isLoad = True
        CalculateValue()
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        isClosed = False
        Try
            If Me.ChkExpira.Checked Then
                Using db As New DataContext
                    Dim getDateServer = (From dte In db.getDateServer).ToList()(0)
                    If Not IsNothing(getDateServer) Then
                        If FormatDateTime(expireDate.Value, DateFormat.ShortDate) < FormatDateTime(getDateServer.Column1, DateFormat.ShortDate) Then
                            MsgBox("La fecha de expiración no puede ser menor que la de hoy.", MsgBoxStyle.Exclamation, "Importante")
                            isClosed = True
                            Return
                        End If
                    Else
                        MsgBox("No se pudo validar la fecha del servidor.", MsgBoxStyle.Exclamation, "Importante")
                        isClosed = True
                        Return
                    End If
                End Using
            End If
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            isClosed = True
            Return
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub aPartirDeNumeric_ValueChanged(sender As Object, e As EventArgs) Handles aPartirDeNumeric.ValueChanged
        If isLoad Then
            CalculateValue()
        End If
    End Sub
    Private Sub porCentageDescuentNumeric_ValueChanged(sender As Object, e As EventArgs) Handles porCentageDescuentNumeric.ValueChanged
        If isLoad Then
            CalculateValue()
        End If
    End Sub

    Private Function CalculateValue() As Boolean
        Try
            If Not PrecioNormal > 0 Then
                MsgBox("No existe precio normal", MsgBoxStyle.Exclamation, "Impotante")
                Return False
            End If

            If Not (aPartirDeNumeric.Value > 0) And Not (porCentageDescuentNumeric.Value > 0) Then
                Return False
            End If


            Dim apartirDe As Integer = aPartirDeNumeric.Value
            Dim decuenUnit As Decimal = PrecioNormal * (porCentageDescuentNumeric.Value / 100)
            Dim totalDescuento As Decimal = decuenUnit * aPartirDeNumeric.Value
            Dim totalPrecioNormal As Decimal = aPartirDeNumeric.Value * PrecioNormal
            Dim totalPrecioOferta = totalPrecioNormal - totalDescuento

            'linea de precio normal
            precioNormalLabel.Text = "Precio normal por " + Me.NomMedida
            'linea decuento por unida
            descuenEnCadaLabel.Text = "Descuento por cada " + NomMedida
            descuetoEnCadaUnoTextBox.Text = decuenUnit.ToString("C5")
            'total en precio normanl
            precioNormalEnLabel.Text = "Total precio normal en " + apartirDe.ToString("N0") + " " + NomMedida
            precioNormalEnTextBox.Text = totalPrecioNormal.ToString("C5")
            'total aplicando el decuento
            precioOfertaEnLabel.Text = "Total precio aplicando descuento en " + apartirDe.ToString("N0") + " " + NomMedida
            precioOfertaEnTextBox.Text = totalPrecioOferta.ToString("C5")
            'total descuento 
            totalDescuentoEnLabel.Text = "Total descuento en " + apartirDe.ToString("N0") + " " + NomMedida
            totalDecuantoEnTextBox.Text = totalDescuento.ToString("C5")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ChkExpira_CheckedChanged(sender As Object, e As EventArgs) Handles ChkExpira.CheckedChanged
        If ChkExpira.Checked Then
            expireDate.Enabled = True
        Else
            expireDate.Enabled = False
        End If

    End Sub

    Private Sub frmAdminOfertas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = isClosed
    End Sub
End Class
