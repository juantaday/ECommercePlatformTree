Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmMyCommerce
    Private CommerceId As Integer
    Private Ultimo_menu As String
    Private _BackColor As Color = Color.FromArgb(230, 229, 255)
    Private _ForeColor As Color = Color.FromArgb(230, 229, 255)

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        CommerceId = 0
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmMyCommerce_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_datacommerce()
        AppliTheme()
        menuDetalle.PerformClick()
    End Sub

    Private Sub Load_datacommerce()
        Try
            Using db As New DataContext
                Dim _commerce = From c In db.myCommerce

                For Each item In _commerce
                    Me.CommerceId = item.CommerceId
                    Return
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AppliTheme()
        Try
            Me.PanelViewData.BackColor = _ForeColor
            Me.PanelViewData.ForeColor = _BackColor
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub menuDetalle_Click(sender As Object, e As EventArgs) Handles menuDetalle.Click
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name = "PanelViewDetail") Then
            Pinta_Menu(sender.Name)
            SetDetail()
            AppliTheme()
        End If

    End Sub

    Private Sub SetDetail()
        Me.PanelViewData.Controls.Clear()
        Dim frmDetail As New Frm_DetailEcommerce
        Dim panlevew = frmDetail.PanelViewDetail
        PanelViewData.Controls.Add(panlevew)
        panlevew.Dock = DockStyle.Fill
        PanelViewData.AutoScroll = True

    End Sub

    Private Sub Pinta_Menu(ByVal NameNemu As String)
        Try
            For i = 0 To MenuStrip1.Items.Count - 1
                If MenuStrip1.Items(i).Name = NameNemu Then
                    MenuStrip1.Items(i).BackColor = Color.FromArgb(130, 130, 95)
                    MenuStrip1.Items(i).ForeColor = _BackColor
                    Ultimo_menu = NameNemu
                Else
                    MenuStrip1.Items(i).BackColor = MenuStrip1.BackColor
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub menuConfiguracion_Click(sender As Object, e As EventArgs) Handles menuConfiguracion.Click
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name = "PanelViewSetthing") Then
            Pinta_Menu(sender.Name)
            SetSetthing()
            AppliTheme()
        End If
    End Sub

    Private Sub SetSetthing()
        Try
            Me.PanelViewData.Controls.Clear()
            Dim frmDetail As New frmSetthingCommerce(Me.CommerceId)
            Dim panlevew = frmDetail.PanelViewSetthing
            PanelViewData.Controls.Add(panlevew)
            panlevew.Dock = DockStyle.Fill
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub SetOwner()
        Try
            Me.PanelViewData.Controls.Clear()
            Dim frmDetail As New frmOwnerCommerce
            Dim panlevew = frmDetail.PanelViewOwner
            PanelViewData.Controls.Add(panlevew)
            panlevew.Dock = DockStyle.Fill
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub menuOwner_Click(sender As Object, e As EventArgs)
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name = "PanelViewOwner") Then
            Pinta_Menu(sender.Name)
            SetOwner()
            AppliTheme()
        End If
    End Sub

    Private Sub menuWhereHouse_Click(sender As Object, e As EventArgs) Handles menuWhereHouse.Click
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name = "PanelViewWhereHouse") Then
            Pinta_Menu(sender.Name)
            SetWhereHouse()
            AppliTheme()
        End If
    End Sub

    Private Sub SetWhereHouse()
        Try
            Me.PanelViewData.Controls.Clear()
            Dim frmDetail As New frmWhereHouseCommerce(Me.CommerceId)
            Dim panlevew = frmDetail.PanelViewWhereHouse
            PanelViewData.Controls.Add(panlevew)
            panlevew.Dock = DockStyle.Fill
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub frmMyCommerce_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        GetInformationServices.EcommerceInfo.GetEccomerceInfo(True)
    End Sub



    Private Sub PropietariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropietariosToolStripMenuItem.Click
        If Me.PanelViewData.Controls.Count = 0 OrElse Not (Me.PanelViewData.Controls(0).Name = "PanelViewOwner") Then
            Pinta_Menu(sender.Name)
            SetOwner()
            AppliTheme()
        End If
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Try
            Using listEmployee As New frmList_Empleados(stateClient.Admin)
                With listEmployee
                    .Width = 1000
                    .Height = 600
                    .StartPosition = FormStartPosition.CenterScreen
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub menuProveedor_Click(sender As Object, e As EventArgs) Handles menuProveedor.Click
        Try
            Using provider As New frmList_Proveedores(stateLoad.List, stateClient.Admin)
                provider.StartPosition = FormStartPosition.CenterScreen
                provider.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
