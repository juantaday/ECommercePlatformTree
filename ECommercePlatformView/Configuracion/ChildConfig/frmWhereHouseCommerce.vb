Imports CADsisVenta

Public Class frmWhereHouseCommerce
    Private CommerceId As Integer
    Private LastItem As String
    Public Sub New(ByVal CommerceId As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.CommerceId = CommerceId
        Load_listWhereHouse()
    End Sub
    Private Sub frmWhereHouseCommerce_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Load_listBanckInWhereHouse(_idBodega As Integer)
        Try
            Me.BanckLisListView.Items.Clear()
            Using db As New DataContext
                Dim _BanckWherehouse = From bW In db.BanckWhereHouse
                                       Join bc In db.BancosCuentas On bc.idBancoCuenta Equals bW.idBancoCuenta
                                       Join b In db.Bancos On b.idBanco Equals bc.idBanco
                                       Join p In db.Personas On p.idPersona Equals bc.idPersona
                                       Where bW.idBodega = _idBodega
                                       Select bW.idBanckWhereHouse, Owner = p.Apellidos & " " & p.Nombre, b.nom_Banco, bc.num_Cuenta, bc.tipo_cuenta


                For Each item In _BanckWherehouse
                    Me.BanckLisListView.Items.Add(SetViewItemInListBanck(item))
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub Load_listVirtualBoxInWhereHouse(_idBodega As Integer)
        Try
            Me.VirtualListView.Items.Clear()
            Using db As New DataContext
                Dim _BanckWherehouse = From vb In db.VirtualBox
                                       Where vb.idBodega = _idBodega
                                       Select vb.idVirtualBox, vb.NameVirtualBox, vb.Saldo, vb.remark, vb.TypeVirtualBox


                For Each item In _BanckWherehouse
                    Me.VirtualListView.Items.Add(SetViewItemInListVirtualBox(item))
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SetViewItemInListVirtualBox(item As Object) As ListViewItem

        Dim itemView As New ListViewItem
        Try
            Dim _saldo As Double = item.Saldo
            Dim _remark As String = String.Empty
            If Not IsNothing(item.remark) Then
                _remark = item.remark
            End If

            With itemView
                .Text = item.idVirtualBox
                .SubItems.Add(item.NameVirtualBox.ToString())
                .SubItems.Add(_saldo.ToString("C2"))
                .SubItems.Add(_remark)
                .SubItems.Add(item.TypeVirtualBox) '
            End With
            Return itemView
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return itemView
        End Try

    End Function

    Private Function SetViewItemInListBanck(item As Object) As ListViewItem
        Dim itemView As New ListViewItem
        With itemView
            .Text = item.idBanckWhereHouse
            .SubItems.Add(item.Owner)
            .SubItems.Add(item.nom_Banco)
            .SubItems.Add(item.num_Cuenta)
            .SubItems.Add(item.tipo_cuenta)
        End With
        Return itemView
    End Function

    Private Sub Load_listWhereHouse()
        Try
            Me.ListView1.Items.Clear()
            Using db As New DataContext
                Dim _Wherehouse = From b In db.Bodegas

                For Each item In _Wherehouse
                    Me.ListView1.Items.Add(SetViewItemInListView(item))
                Next
            End Using
            ListView1_SelectedIndexChanged(ListView1, New EventArgs)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SetViewItemInListView(item As Bodegas) As ListViewItem
        Dim _itemView As New ListViewItem
        With _itemView
            .Text = item.idBodega
            .SubItems.Add(item.Nom_Bodega)
            .SubItems.Add(item.Telef1_Bodega)
            .SubItems.Add(String.Format("Descripción: {0} {1}Dirección: {2}",
                                       item.Des_Bodega, vbCrLf, item.Direc_Bodega))
        End With
        Return _itemView
    End Function

    Private Sub addNewBanckButton_Click(sender As Object, e As EventArgs) Handles addNewBanckButton.Click
        Try
            If Not Me.ListView1.SelectedItems.Count = 1 Then
                MsgBox("Seleeccione un local o bodega..", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            Using listBanck As New frmListBanckOwner(Me.CommerceId, TypeData.All)
                With listBanck
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        If addNewBanck(Me.ListView1.SelectedItems(0).Text, .idBancoCuenta) Then
                            Load_listBanckInWhereHouse(Me.ListView1.SelectedItems(0).Text)
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function addNewBanck(idBodega As Integer, idBancoCuenta As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim NewBanck As New BanckWhereHouse With
                    {
                        .idBancoCuenta = idBancoCuenta,
                        .idBodega = idBodega
                    }
                db.BanckWhereHouse.InsertOnSubmit(NewBanck)
                db.SubmitChanges()
            End Using

            Return True
        Catch ex As Exception
            If ex.Message.Contains("UQ_BanckWhereHouse_Bodega_Cuenta") Then
                MsgBox("Esta cuenta ya existe..", MsgBoxStyle.Critical, "Error")
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End If
            Return False
        End Try

    End Function
    Private Sub BanckLisListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BanckLisListView.SelectedIndexChanged
        Me.DeleteButton.Enabled = If(BanckLisListView.SelectedItems.Count = 1, True, False)
    End Sub

    Private Function DeleteBanck(_idBanckWhereHouse As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim NewBanck = From bw In db.BanckWhereHouse
                               Where bw.idBanckWhereHouse = _idBanckWhereHouse

                For Each item In NewBanck
                    db.BanckWhereHouse.DeleteOnSubmit(item)
                    db.SubmitChanges()
                Next
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If Not BanckLisListView.SelectedItems.Count = 1 Then
            MsgBox("Seleeccione un cuanta...", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If

        If Not MsgBox("Esta seguro de eliminar esta cuenta",
                 MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 _
                 + MsgBoxStyle.Exclamation, "Responda") = MsgBoxResult.Yes Then
            Return
        End If

        If DeleteBanck(BanckLisListView.SelectedItems(0).Text) Then
            Load_listBanckInWhereHouse(ListView1.SelectedItems(0).Text)
        End If

    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        Try
            If Not e.IsSelected Then
                Return
            End If
            If Not Me.ListView1.SelectedItems.Count = 1 Then
                Me.BanckLisListView.Items.Clear()
                Me.VirtualListView.Items.Clear()
                Me.DesctiptionLabel.Text = ""
                Me.bodegaSelectedLabel1.Text = ""
                Me.BodegaSelectedLabel2.Text = ""
            Else
                If Not LastItem = ListView1.SelectedItems(0).Text Then
                    Load_listBanckInWhereHouse(ListView1.SelectedItems(0).Text)
                    Load_listVirtualBoxInWhereHouse(ListView1.SelectedItems(0).Text)
                    Load_DefaultRatesInWhereHouse(ListView1.SelectedItems(0).Text)
                    Me.bodegaSelectedLabel1.Text = "Cuentas para la bodega: " & ListView1.SelectedItems(0).SubItems(BodegaClm.Index).Text
                    Me.BodegaSelectedLabel2.Text = "Cajas virtuales para la bodega: " & ListView1.SelectedItems(0).SubItems(BodegaClm.Index).Text
                    Me.DesctiptionLabel.Text = ListView1.SelectedItems(0).SubItems(3).Text
                    LastItem = ListView1.SelectedItems(0).Text
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Load_DefaultRatesInWhereHouse(idBodega As Integer)
        Try
            Using db As New DataContext
                Dim bodega = From d In db.Bodegas
                             Where d.idBodega = idBodega
                For Each item In bodega
                    Dim _rates = From r In db.Rates
                                 Where r.idRates = item.idRates

                    For Each _ItemRate In _rates
                        FindRatesTextBox.Text = "(" & _ItemRate.idRates & ") " & _ItemRate.Descriptions
                        DeleteRatesButton.Tag = _ItemRate.idRates
                        DeleteRatesButton.Visible = True
                        Return
                    Next
                Next
            End Using

            FindRatesTextBox.Text = "Ninguno..."
            DeleteRatesButton.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub AddVirtualboxButton_Click(sender As Object, e As EventArgs) Handles AddVirtualboxButton.Click
        Try
            If Not Me.ListView1.SelectedItems.Count = 1 Then
                MsgBox("Seleeccione una bodega ...", MsgBoxStyle.Exclamation, "Importante")
                Return
            Else
                Using NewVirtualForm As New frmAddVirtualBox(stateOperation.Insert,
                                                         New VirtualBox With {.idBodega = ListView1.SelectedItems(0).Text})
                    With NewVirtualForm
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            Load_listVirtualBoxInWhereHouse(ListView1.SelectedItems(0).Text)
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditVirtualBoxButton_Click(sender As Object, e As EventArgs) Handles EditVirtualBoxButton.Click
        Try
            If Not Me.VirtualListView.SelectedItems.Count = 1 Then
                MsgBox("Seleeccione una caja virtual ...", MsgBoxStyle.Exclamation, "Importante")
                Return
            Else

                Using NewVirtualForm As New frmAddVirtualBox(stateOperation.Update,
                                                         New VirtualBox With
                                                         {
                                                             .idBodega = ListView1.SelectedItems(0).Text,
                                                             .idVirtualBox = VirtualListView.SelectedItems(0).Text,
                                                             .NameVirtualBox = VirtualListView.SelectedItems(0).SubItems(NameVirtualBoxClm.Index).Text,
                                                             .Saldo = VirtualListView.SelectedItems(0).SubItems(saldoClm.Index).Text,
                                                             .TypeVirtualBox = VirtualListView.SelectedItems(0).SubItems(idTypoCajaClm.Index).Text,
                                                             .remark = VirtualListView.SelectedItems(0).SubItems(RemarkClm.Index).Text
                                                          })
                    With NewVirtualForm
                        .ShowDialog()
                        If .DialogResult = DialogResult.OK Then
                            Load_listVirtualBoxInWhereHouse(ListView1.SelectedItems(0).Text)
                        End If
                    End With
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub DeleteVirtualboxButton_Click(sender As Object, e As EventArgs) Handles DeleteVirtualboxButton.Click
        Try
            If Not Me.VirtualListView.SelectedItems.Count = 1 Then
                MsgBox("Seleeccione una caja virtual ...", MsgBoxStyle.Exclamation, "Importante")
                Return
            Else
                If MsgBox(msgDelete, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = MsgBoxResult.Yes Then
                    If DeleteVirtualbox(Me.VirtualListView.SelectedItems(0).Text) Then
                        Load_listVirtualBoxInWhereHouse(ListView1.SelectedItems(0).Text)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Function DeleteVirtualbox(_idVirtualBox As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim _Vistual = From v In db.VirtualBox
                               Where v.idVirtualBox = _idVirtualBox
                For Each item In _Vistual
                    db.VirtualBox.DeleteOnSubmit(item)
                    db.SubmitChanges()
                    Return True
                Next
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub VirtualListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles VirtualListView.ItemSelectionChanged
        Try
            If Not e.IsSelected Then
                Me.EditVirtualBoxButton.Enabled = False
                Me.DeleteVirtualboxButton.Enabled = False
            End If
            If Not Me.VirtualListView.SelectedItems.Count = 1 Then
                Me.EditVirtualBoxButton.Enabled = False
                Me.DeleteVirtualboxButton.Enabled = False
            Else
                Me.EditVirtualBoxButton.Enabled = True
                Me.DeleteVirtualboxButton.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Async Sub findButton_Click(sender As Object, e As EventArgs) Handles findButton.Click
        Try
            DeleteRatesButton.Tag = 0
            If Not ListView1.SelectedItems.Count = 1 Then
                MsgBox("Seleccione un local o bodega", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            Using newForm As New frmList_RatesSelect
                With newForm
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        DeleteRatesButton.Tag = .idRates
                        If SaveRates(DeleteRatesButton.Tag, ListView1.SelectedItems(0).Text) Then
                            FindRatesTextBox.Text = "(" & .idRates & ") " & .Descriptios
                            Await GetInformationServices.GeneralInformation.Inicia_Terminal(True)
                        End If
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SaveRates(idRates As Integer, idBodega As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim bodega = From d In db.Bodegas
                             Where d.idBodega = idBodega

                For Each item In bodega
                    item.idRates = idRates
                    db.SubmitChanges()
                Next
            End Using
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
    Private Async Sub DeleteRatesButton_Click(sender As Object, e As EventArgs) Handles DeleteRatesButton.Click
        DeleteRatesButton.Tag = 0
        If Not ListView1.SelectedItems.Count = 1 Then
            MsgBox("Seleccione un local o bodega", MsgBoxStyle.Exclamation, "Importante")
            Return
        End If
        If MsgBox("Esta seguro de borrar la tarifa predeterminada.",
                  MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            If DeleteRates(ListView1.SelectedItems(0).Text) Then
                FindRatesTextBox.Text = "Ninguno..."
                DeleteRatesButton.Visible = False
                Await GetInformationServices.GeneralInformation.Inicia_Terminal(True)
            End If
        End If
    End Sub

    Private Function DeleteRates(_idBodega As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim _bodegas = From b In db.Bodegas
                               Where b.idBodega = _idBodega

                For Each item In _bodegas
                    item.idRates = Nothing
                    db.SubmitChanges()
                    Return True
                Next
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub AddWhereHouseButton_Click(sender As Object, e As EventArgs) Handles AddWhereHouseButton.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Using newWhereHouse As New frmAdd_Almacen(stateOperation.Insert, 0)
                With newWhereHouse
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Load_listWhereHouse()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EditWhereHouseButton_Click(sender As Object, e As EventArgs) Handles EditWhereHouseButton.Click
        Try
            If Not Me.ListView1.SelectedItems.Count = 1 Then
                MsgBox("Seleeccione un local o bodega..", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If
            Me.Cursor = Cursors.WaitCursor
            Using newWhereHouse As New frmAdd_Almacen(stateOperation.Update, ListView1.SelectedItems(0).Text)
                With newWhereHouse
                    .StartPosition = FormStartPosition.CenterParent
                    .ShowDialog()
                    If .DialogResult = DialogResult.OK Then
                        Load_listWhereHouse()
                    End If
                End With
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DeleteWhereHouseButton_Click(sender As Object, e As EventArgs) Handles DeleteWhereHouseButton.Click
        Try
            If Not Me.ListView1.SelectedItems.Count = 1 Then
                MsgBox("Seleeccione un local o bodega..", MsgBoxStyle.Exclamation, "Importante")
                Return
            End If

            If MsgBox("Esta seguro de eliminar: " & Me.ListView1.SelectedItems(0).SubItems(1).Text, MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Responda") = vbYes Then
                If DelteWhereHouse(ListView1.SelectedItems(0).Text) Then
                    Load_listWhereHouse()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function DelteWhereHouse(ByVal _idbodega As Integer) As Boolean
        Try
            Using db As New DataContext
                Dim _bodega = From b In db.Bodegas
                              Where b.idBodega = _idbodega

                For Each intem In _bodega
                    db.Bodegas.DeleteOnSubmit(intem)
                    db.SubmitChanges()
                    Return True
                Next
            End Using
            Return False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        PanelConfig.Enabled = ListView1.SelectedItems.Count = 1
    End Sub
End Class