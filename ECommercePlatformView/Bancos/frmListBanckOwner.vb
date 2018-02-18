Imports System.Collections.Generic
Imports System.Windows.Forms
Imports ECommercePlatformView.EnumSatateModule

Public Class frmListBanckOwner
    Private isClosed As Boolean
    Private CommerceId As Integer
    Private TypeData As TypeData
    Protected Friend idBancoCuenta As Integer
    Public Sub New(ByVal _CommerId As Integer, _TypeDada As TypeData)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.CommerceId = _CommerId
        Me.TypeData = _TypeDada
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        isClosed = False
        If Me.ListView1.SelectedItems.Count = 1 Then
            idBancoCuenta = ListView1.SelectedItems(0).Text
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            isClosed = True
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        isClosed = False
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmListBanckOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case TypeData
                Case TypeData.All
                    Load_DataBanckComemrce(Me.CommerceId)
                    Load_DataOwner()
                Case TypeData.Commeerce
                    Load_DataBanckComemrce(Me.CommerceId)
                Case TypeData.Owner
                    Load_DataOwner()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub Load_DataBanckComemrce(_commerceId As Integer)
        Try
            Using db As New DataContext
                Dim _Ruccommerce = From c In db.myCommerce
                                   Where c.CommerceId = _commerceId
                For Each item In _Ruccommerce
                    Dim myListBanck = From bc In db.BancosCuentas
                                      Join b In db.Bancos On bc.idBanco Equals b.idBanco
                                      Join p In db.Personas On p.idPersona Equals bc.idPersona
                                      Where p.Ruc_Ci = item.Ruc
                                      Select p.Ruc_Ci, OwnerName = p.Apellidos & " " & p.Nombre, b.nom_Banco,
                                          bc.num_Cuenta, bc.tipo_cuenta, bc.idBancoCuenta

                    If myListBanck.Count > 0 Then
                        ViewItemInListView(myListBanck.OrderBy(Function(x) x.OwnerName).ThenBy(Function(x) x.nom_Banco).ToList())
                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Load_DataOwner()
        Try
            Using db As New DataContext
                Dim myListBanck = From bc In db.BancosCuentas
                                  Join b In db.Bancos On bc.idBanco Equals b.idBanco
                                  Join p In db.Personas On p.idPersona Equals bc.idPersona
                                  Join oW In db.Propietarios On oW.idPerson Equals p.idPersona
                                  Select p.Ruc_Ci, OwnerName = p.Apellidos & " " & p.Nombre, b.nom_Banco,
                                      bc.num_Cuenta, bc.tipo_cuenta, bc.idBancoCuenta

                If myListBanck.Count > 0 Then
                    ViewItemInListView(myListBanck.OrderBy(Function(x) x.OwnerName).ThenBy(Function(x) x.nom_Banco).ToList())
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ViewItemInListView(_List As IEnumerable(Of Object))
        Try
            For Each item In _List
                ListView1.Items.Add(SetItem(item))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SetItem(item As Object) As ListViewItem
        Dim myItem As New ListViewItem
        Try
            With myItem
                .Text = item.idBancoCuenta
                .SubItems.Add(item.Ruc_Ci)
                .SubItems.Add(item.OwnerName)
                .SubItems.Add(item.nom_Banco)
                .SubItems.Add(item.num_Cuenta)
                .SubItems.Add(item.tipo_cuenta)
            End With
            Return myItem
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return myItem
        End Try
    End Function

    Private Sub frmListBanckOwner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = isClosed
    End Sub
End Class
