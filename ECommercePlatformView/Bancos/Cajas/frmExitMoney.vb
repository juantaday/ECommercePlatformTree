Imports System.Windows.Forms

Public Class frmExitMoney
    Protected Friend idbodega As Integer
    Protected Friend IdCajaStado As Integer
    Protected Friend IdCaja As Integer
    Protected Friend IdFormaPago As Integer
    Protected Friend MontoDivisa As Double

    Public Sub New(ByVal idBodega As Integer, ByVal montoDivisa As Double, _idCajaStado As Integer, _idformaPago As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.idbodega = idBodega
        Me.MontoDivisa = montoDivisa
        Me.IdCajaStado = _idCajaStado
        Me.IdFormaPago = _idformaPago
    End Sub
#Region "Forms"
    Private Sub frmExitMoney_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.montoDivisaLabel.Text = "Monto divisa: " & Me.MontoDivisa.ToString("C2")
        If Me.IdCajaStado = 0 Then
            MsgBox("No se ha determinado la caja ha administrar [IdCajaStado =0]", MsgBoxStyle.Exclamation, "Importante")
            Me.Close()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
#End Region

#Region "Radio Butonn"
    Private Sub virtualBoxRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles virtualBoxRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("virtualBoxRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub

    Private Sub BankAccountRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BankAccountRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("BankAccountRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub

    Private Sub PaymentProviderRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PaymentProviderRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("PaymentProviderRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub
    Private Sub AccountEmployeeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AccountEmployeeRadioButton.CheckedChanged
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name.Equals("AccountEmployeeRadioButton")) Then
            If ControlCheck(sender) Then

            End If
        End If
    End Sub

#End Region

#Region "Controllers"
    Private Function ControlCheck(sender As System.Object) As Boolean
        Try
            If Not (DirectCast(sender, RadioButton).Checked) Then
                Return False
            End If

            Select Case DirectCast(sender, RadioButton).Name
                Case "virtualBoxRadioButton"
                    Return SetViartualBox()
                Case "BankAccountRadioButton"
                    SetBanckAccount()
                Case "PaymentProviderRadioButton"
                    SetPaymentProvider()
                Case "AccountEmployeeRadioButton"
                    SetAccountEmployee()
                Case ""

                Case ""


            End Select

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

#End Region

#Region "Set View"

    Private Function SetPaymentProvider() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim frmdat As New frmChildPaymentProvider(Me)
            Dim controlView = frmdat.PanelView
            PanelViewData.Controls.Add(controlView)
            controlView.Dock = DockStyle.Fill
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SetViartualBox() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim frmdat As New frmchilVirtualBox(Me, Me.idbodega)
            Dim controlView = frmdat.PanelView
            PanelViewData.Controls.Add(controlView)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SetBanckAccount() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim frmdat As New frmChilBanckDeposit(Me, Me.IdCajaStado, Me.IdFormaPago, Me.MontoDivisa)

            Dim controlView = frmdat.PanelView
            PanelViewData.Controls.Add(controlView)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Function SetAccountEmployee() As Boolean
        Try
            PanelViewData.Controls.Clear()
            Dim frmdat As New frmChildEmployeeAccount(Me)

            Dim controlView = frmdat.PanelViewAccountEmployee
            PanelViewData.Controls.Add(controlView)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
#End Region
End Class
