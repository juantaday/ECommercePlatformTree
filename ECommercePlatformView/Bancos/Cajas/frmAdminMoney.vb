Imports System.Collections.ObjectModel
Imports System.Windows.Controls
Imports CADsisVenta.DataSetMonedasTableAdapters

Public Class frmAdminMoney
    Private estaCargado As Boolean
    Protected Friend idCajaStada As Integer
    Protected Friend callOpen As callShow
    Protected Friend TotalMoney As Double
    Protected Friend listMoneyRead = New Collection(Of MoneyList)
    Public Enum callShow
        arqueoTerminal = 1
    End Enum
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeObject()

        Me.GetMoneyTipe()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub GetMoneyTipe()
        Try
            estaCargado = False
            Dim tapd As New TypoMonedaTableAdapter
            ComboMenu.ComboBox.DataSource = tapd.GetData()
            ComboMenu.ComboBox.ValueMember = "idMoneda"
            ComboMenu.ComboBox.DisplayMember = "Nom_Moneda"
            ComboMenu.ComboBox.SelectedValue = 44
            ComboMenu.ComboBox.RightToLeft = RightToLeft.No
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            estaCargado = True
        End Try
    End Sub
    Private Function readListMoney() As Boolean
        Try
            listMoneyRead = New Collection(Of MoneyList)
            Dim M_MoneyDetail As MoneyDetail = ElementHost1.Child
            Dim hasList As Boolean = False

            Dim listMoney = New ObservableCollection(Of MoneyList)
            For Each money As MoneyList In M_MoneyDetail.listViewMoneda.Items
                If money.Quantity > 0 Then
                    hasList = True
                    listMoneyRead.Add(money)
                End If
            Next
            For Each money As MoneyList In M_MoneyDetail.listViewVillete.Items
                If money.Quantity > 0 Then
                    hasList = True
                    listMoneyRead.Add(money)
                End If
            Next
            Return hasList
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Sub ControlRadioBoton(sender As Object)
        Try
            Dim MyControlName As String = sender.name
            If MyControlName.ToString.ToString.Contains("1") Then
                GroupBoxInputData.Visible = True
                PanelView.Enabled = False
                Dim textBox As system.Windows.Forms.TextBox = ValorManualTextBox
                If String.IsNullOrWhiteSpace(textBox.Text) Then
                    DirectCast(ValorManualTextBox, System.Windows.Forms.TextBox).Text = "0.00"
                End If
                textBox.Focus()
            ElseIf MyControlName.ToString.ToString.Contains("2") Then
                GroupBoxInputData.Visible = False
                PanelView.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub InitializeObject()


        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        'ElementHost1
        '
        Me.ElementHost1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElementHost1.Location = New System.Drawing.Point(0, 0)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(853, 315)
        Me.ElementHost1.TabIndex = 1
        Me.ElementHost1.Text = "ElementHost1"
        Me.PanelView.Controls.Add(Me.ElementHost1)
    End Sub
    Friend WithEvents ElementHost1 As Integration.ElementHost

    Private Sub ValorManualTextBox_TextChanged(sender As Object, e As EventArgs) Handles ValorManualTextBox.TextChanged
        Try
            ConfimButton.Enabled = False
            Me.AcceptButton = OkButton

            If IsNumeric(sender.Text) Then
                If Double.Parse(DirectCast(sender, System.Windows.Forms.TextBox).Text) > 0 Then
                    ConfimButton.Enabled = True
                    Me.OkButton.Enabled = True
                    Me.AcceptButton = ConfimButton
                    Return
                End If
            End If
            If RadioButton1.Checked Then
                If Double.Parse(DirectCast(sender, System.Windows.Forms.TextBox).Text) >= 0 Then
                    ConfimButton.Enabled = True
                    Me.AcceptButton = ConfimButton
                    Me.OkButton.Enabled = True
                    Return
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Dim radio As System.Windows.Forms.RadioButton = sender
        If radio.Checked Then
            ControlRadioBoton(sender)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim radio As System.Windows.Forms.RadioButton = sender
        If radio.Checked Then
            ControlRadioBoton(sender)
        End If
    End Sub

    Private Sub TStripComboBoxTypoMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMenu.SelectedIndexChanged
        Try
            If ComboMenu.ComboBox.SelectedIndex > 0 And
               ComboMenu.ComboBox.ValueMember.Length > 0 Then
                Me.LoadView(ComboMenu.ComboBox.SelectedValue)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LoadView(idMoney As Integer)
        Try
            Dim M_MoneyDetail As MoneyDetail
            M_MoneyDetail = New ECommercePlatformView.MoneyDetail(RealizedMenu, DeleteMenu, EditMenu, TotalLabel, idMoney)
            Me.ElementHost1.Child = M_MoneyDetail
            EditMenu.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub cancelButton_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub ReturToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturToolStripMenuItem.Click
        If ComboMenu.Visible Then
            Me.Close()
        Else
            Visivilite_CheckBox(False)
            ComboMenu.Visible = True
            DeleteMenu.Visible = False
            RealizedMenu.Visible = False
            EditMenu.Visible = False
        End If
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EditMenu.Tag = 0
        If PanelView.Enabled Then
            If Visivilite_CheckBox(True) Then
                RealizedMenu.Visible = True
                ComboMenu.Visible = False
                EditMenu.Visible = False
            End If
        End If
    End Sub
    Private Function Visivilite_CheckBox(state As Boolean) As Boolean
        Try
            Dim M_MoneyDetail As MoneyDetail = ElementHost1.Child
            Dim hasList As Boolean = False
            Dim listMoney = New ObservableCollection(Of MoneyList)
            For Each money As MoneyList In M_MoneyDetail.listViewMoneda.Items
                money.IsSelect = state
                money.IsChecken = False
                hasList = True
                listMoney.Add(money)
            Next
            M_MoneyDetail.listViewMoneda.ItemsSource = listMoney

            listMoney = New ObservableCollection(Of MoneyList)
            For Each money As MoneyList In M_MoneyDetail.listViewVillete.Items
                money.IsSelect = state
                money.IsChecken = False
                hasList = True
                listMoney.Add(money)
            Next
            M_MoneyDetail.listViewVillete.ItemsSource = listMoney
            Return hasList
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub RealizedMenu_Click(sender As Object, e As EventArgs) Handles RealizedMenu.Click
        Dim state As Boolean
        If RealizedMenu.Tag = 0 Then
            RealizedMenu.Image = Global.ECommercePlatformView.My.Resources.Resources.checkbox_notChecked_16
            RealizedMenu.Tag = 1
            state = False
        Else
            RealizedMenu.Image = Global.ECommercePlatformView.My.Resources.Resources.checkbox_checked_16
            RealizedMenu.Tag = 0
            state = True
        End If
        Me.CheckList(state)
    End Sub
    Private Sub CheckList(state As Boolean)
        Try
            Dim M_MoneyDetail As MoneyDetail = ElementHost1.Child

            Dim listMoney = New ObservableCollection(Of MoneyList)
            For Each money As MoneyList In M_MoneyDetail.listViewMoneda.Items
                money.IsChecken = state
                listMoney.Add(money)
            Next
            M_MoneyDetail.listViewMoneda.ItemsSource = listMoney

            listMoney = New ObservableCollection(Of MoneyList)
            For Each money As MoneyList In M_MoneyDetail.listViewVillete.Items
                money.IsChecken = state
                listMoney.Add(money)
            Next
            M_MoneyDetail.listViewVillete.ItemsSource = listMoney
            M_MoneyDetail.ActivaMenuDelete(state)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub EditMenuItem_Click(sender As Object, e As EventArgs) Handles EditMenuItem.Click
        EditMenu.Tag = 1
        If Visivilite_CheckBox(True) Then
            ComboMenu.Visible = False
            RealizedMenu.Visible = False
            DeleteMenu.Visible = False
        End If
    End Sub
    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click
        Try
            Dim M_MoneyDetail As MoneyDetail = ElementHost1.Child
            Dim money As New MoneyList

            For Each money In M_MoneyDetail.listViewMoneda.Items
                If money.IsChecken Then
                    GoTo ViewEdit
                End If
            Next
            For Each money In M_MoneyDetail.listViewVillete.Items
                If money.IsChecken Then
                    GoTo ViewEdit
                End If
            Next
            Exit Sub
ViewEdit:
            Using newmoney As New frmAdd_UpdateMoney(ComboMenu.ComboBox.SelectedValue, money)
                With newmoney
                    .Operation = _operation.Update
                    .isFraccion = True
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Me.LoadView(ComboMenu.ComboBox.SelectedValue)
                    End If
                End With
            End Using
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub ConfimButton_Click(sender As Object, e As EventArgs) Handles ConfimButton.Click
        Try
            Dim total As Double = DirectCast(ValorManualTextBox, System.Windows.Forms.TextBox).Text
            TotalLabel.Text = total.ToString("C2")
            Me.AcceptButton = Nothing
            Me.AcceptButton = Me.OkButton
            Me.OkButton.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub TotalLabel_TextChanged(sender As Object, e As EventArgs) Handles TotalLabel.TextChanged
        Try
            Me.TotalMoney = DirectCast(sender, System.Windows.Forms.Label).Text
            If TotalMoney > 0 Then
                OkButton.Enabled = True
                Me.AcceptButton = OkButton
            Else
                OkButton.Enabled = False
                Me.AcceptButton = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cancel_Button_Click(sender As Object, e As EventArgs) Handles cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        If RadioButton2.Checked Then
            If readListMoney() Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Using newmoney As New frmAdd_UpdateMoney(ComboMenu.ComboBox.SelectedValue, New MoneyList())
            With newmoney
                .Operation = _operation.Insert
                .isFraccion = True
                .ShowDialog()
                If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                    Me.LoadView(ComboMenu.ComboBox.SelectedValue)
                End If
            End With
        End Using
    End Sub

    Private Sub VilleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VilleteToolStripMenuItem.Click
        Try
            Using newmoney As New frmAdd_UpdateMoney(ComboMenu.ComboBox.SelectedValue, New MoneyList())
                With newmoney
                    .Operation = _operation.Insert
                    .isFraccion = False
                    .ShowDialog()
                    If .DialogResult = System.Windows.Forms.DialogResult.OK Then
                        Me.LoadView(ComboMenu.ComboBox.SelectedValue)
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class