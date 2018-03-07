Imports System.Data.SqlClient
Imports System.Linq
Imports CADsisVenta
Imports CADsisVenta.DataSetSystem
Imports CADsisVenta.DataSetSystemTableAdapters
Imports CADsisVenta.DataSetExpirateTableAdapters
Imports Microsoft.VisualBasic.PowerPacks
Imports CADsisVenta.DataSetExpirate

Public Class frmAdminDateExpir
    Dim Screen As Screen

    Private Shared PanelContainer As ShapeContainer
    Private PanelRectangle As RectangleShape
    Private isLoated As Boolean


    Private ListIndex As List(Of getIndexDaysInMonthForAnalicesRow)
    Private ListDataExpir As List(Of filterDataExpirForDrawRow)
    Private totalLinesData As Integer
    Private NowDay As Int16
    Private Pixel As Decimal

    Private Shared Tamaño As Byte = 2
    Private Shared ColorPenX As New System.Drawing.Pen(Brushes.Red, Tamaño)
    Private Shared ColorPenY As New System.Drawing.Pen(Brushes.Green, Tamaño)
    Private Shared FontCordinada As Font
    Private id_Producto As Integer
    Private nom_comercial As String

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        InitializeMyComponent()

    End Sub

    Public Sub New(id_Producto As Integer, nom_comercial As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        InitializeMyComponent()

        Me.id_Producto = id_Producto
        Me.nom_comercial = nom_comercial

    End Sub

    Private Sub InitializeMyComponent()
        ' initialize containers 
        PanelContainer = New ShapeContainer()
        PanelRectangle = New RectangleShape()

        ' initialize datas 
        ListIndex = New List(Of getIndexDaysInMonthForAnalicesRow)

        ' initialize fonts 
        Screen = Screen.PrimaryScreen
        FontCordinada = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub frmAdminDateExpir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_bodega()

        isLoated = True
        If Me.id_Producto > 0 Then
            PictureBox2_Click(Me.PictureBox2, New EventArgs)
            PictureBox2_Click(Me.PictureBox2, New EventArgs)
            Me.ListViewSelectProduct.DataSource = GetSelectProductExpirate(Me.id_Producto)
            ListViewSelectProduct.Columns(Nom_ComercialClm2.Index).Width = 0
            Me.Nom_ComercialLabel.Text = Me.nom_comercial
        Else
            PictureBox1_Click(Me.PictureBox1, New EventArgs)
        End If
    End Sub
    Private Sub Carga_bodega()
        Try
            Using dat As New BodegaSystemTableAdapter
                Using dt As New BodegaSystemDataTable
                    dat.Fill(dt)
                    ListBodegaComboBox.DataSource = dt.ToList()
                    ListBodegaComboBox.DisplayMember = "Nom_Bodega"
                    ListBodegaComboBox.ValueMember = "idBodega"
                    ListBodegaComboBox.SelectedValue = TerminalActivo.idBodega
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, vbCritical, "Error")
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub DrowLineXY(ByVal Grafico As System.Drawing.Graphics)

        Dim xini As New Point With {.X = 10, .Y = Screen.Bounds.Height * 0.6}
        Dim xfin As New Point With {.X = Screen.Bounds.Width * 0.9, .Y = Screen.Bounds.Height * 0.6}
        Grafico.DrawLine(ColorPenX, xini, xfin)


        Dim yini As New Point With {.X = Screen.Bounds.Width * 0.05, .Y = Screen.Bounds.Height * 0.05}
        Dim yfin As New Point With {.X = Screen.Bounds.Width * 0.05, .Y = Screen.Bounds.Height * 0.77}
        Grafico.DrawLine(ColorPenY, yini, yfin)

        Grafico.DrawString("Hoy día", FontCordinada, Brushes.Green, Screen.Bounds.Height * 0.03, Screen.Bounds.Width * 0.01)

    End Sub
    Private Sub DrawLine(informationData As String, ByVal StartPoint As Point, ByVal EndPoint As Point, ByVal color As Color)
        Dim linesha = New LineShape
        linesha.BorderColor = color
        linesha.BorderWidth = 3
        linesha.StartPoint = StartPoint
        linesha.EndPoint = EndPoint
        linesha.Parent = PanelContainer
        linesha.Tag = informationData
        AddHandler linesha.MouseMove, AddressOf linesha_MouseMove
        AddHandler linesha.Click, AddressOf linesha_click

        Dim lineshaHotizontal = New LineShape
        lineshaHotizontal.BorderColor = color
        lineshaHotizontal.BorderWidth = 1
        lineshaHotizontal.StartPoint = New Point With {.X = EndPoint.X - 5, .Y = EndPoint.Y}
        lineshaHotizontal.EndPoint = New Point With {.X = EndPoint.X + 5, .Y = EndPoint.Y}
        lineshaHotizontal.Parent = PanelContainer
    End Sub
    Private Sub linesha_MouseMove(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs
                )
        sender.BorderWidth = 4
        Me.LabelDescription.Text = sender.tag
    End Sub

    Private Sub linesha_click(
    ByVal sender As Object,
    ByVal e As System.Windows.Forms.MouseEventArgs
             )
        sender.BorderWidth = 4
        Me.LabelDescription.Text = sender.tag
    End Sub

    Private Sub DrawMoths()

        Dim color As Color
        Dim i As Integer = 0
        Dim A(6) As Object

        A(0) = Color.Red
        A(1) = Color.Green
        A(2) = Color.Yellow
        A(3) = Color.Violet
        A(4) = Color.Black
        A(5) = Color.Blue
        A(6) = Color.Fuchsia


        Dim starPoint As New Point With {.X = PanelRectangle.Width * 0.01, .Y = PanelRectangle.Height * 0.97}

        For Each item In Me.ListIndex
            color = A(i)
            DrawLineMes(If(item.itIsPreviousMonth, String.Empty, item.MonthsDescrip),
                        starPoint, Pixel * item.DrawDay, color)
            starPoint.X += Pixel * item.DrawDay
            i += 1
        Next
    End Sub
    Private Sub DrawLineMes(ByVal desMont As String, ByVal StartPoint As Point, ByVal WithLine As Integer, ByVal color As Color)
        Dim linesha As New LineShape
        linesha.BorderColor = color
        linesha.BorderWidth = 20
        linesha.StartPoint = StartPoint
        linesha.EndPoint = New Point With {.X = StartPoint.X + WithLine, .Y = StartPoint.Y}
        linesha.Parent = PanelContainer

        Me.Label1 = New Label()
        Me.Label1.AutoSize = False
        Me.Label1.Height = 12
        If String.IsNullOrEmpty(desMont) Then
            Me.Label1.Width = 0
        End If
        Label1.Text = desMont
        Label1.Location = New Point With {.X = StartPoint.X + 10, .Y = StartPoint.Y - 8}
        Label1.BackColor = color
        If color = Color.Black Or color = Color.Blue Then
            Label1.ForeColor = Color.White
        End If
        PanelContainer.Controls.Add(Label1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        load_DataIndex()

    End Sub
    Private Sub load_DataIndex()
        Using cmd As New getIndexDaysInMonthForAnalicesTableAdapter
            Using dt As New getIndexDaysInMonthForAnalicesDataTable
                cmd.Fill(dt)
                Me.ListIndex = dt.ToList()

                totalLinesData = Aggregate i In ListIndex
                                     Into Sum(i.DrawDay)
                If totalLinesData = 0 Then
                    Return
                End If

                Pixel = (PanelRectangle.Width - 10) / Me.totalLinesData

                If ListIndex.Count > 0 Then
                    NowDay = ListIndex.FirstOrDefault().Today
                End If

            End Using
        End Using
    End Sub

    Private Sub DrawXY()

        Dim starPointy As New Point With {.X = PanelRectangle.Width * 0.01, .Y = PanelRectangle.Height * 0.95}

        For Each item In ListIndex
            starPointy.X += Pixel * item.Today
            Exit For
        Next

        Dim linesha As New LineShape
        linesha.BorderColor = Color.Black
        linesha.BorderWidth = 5
        linesha.StartPoint = starPointy
        linesha.EndPoint = New Point With {.X = starPointy.X, .Y = PanelRectangle.Height * 0.06}
        linesha.Parent = PanelContainer

        Dim starPointx As New Point With {.X = PanelRectangle.Width * 0.01, .Y = PanelRectangle.Height * 0.9}



        linesha = New LineShape
        linesha.BorderColor = Color.Red
        linesha.BorderWidth = 1
        linesha.StartPoint = starPointx

        starPointx.X += Pixel * totalLinesData
        linesha.EndPoint = starPointx
        linesha.Parent = PanelContainer

    End Sub

    Private Sub DrawDataView()
        Dim i As Integer = 0
        Dim A(6) As Object

        A(0) = Color.Red
        A(1) = Color.Green
        A(2) = Color.Yellow
        A(3) = Color.Violet
        A(4) = Color.BlueViolet
        A(5) = Color.Blue
        A(6) = Color.LawnGreen



        Dim starPointy As New Point With {.X = PanelRectangle.Width * 0.01, .Y = PanelRectangle.Height * 0.9}
        Dim endPoint As New Point With {.X = PanelRectangle.Width * 0.01, .Y = PanelRectangle.Height * 0.9}
        Dim sql As String = String.Empty

        Dim pointIni As New Point With {.X = 0, .Y = starPointy.Y}
        Dim pointfin As New Point With {.X = 0, .Y = 0}

        Dim idOlddate As Date = Nothing

        For Each item In Me.ListDataExpir.OrderBy(Function(x) x.DateExpirate).ThenBy(Function(x) x.intervalo)
            i = If(i = 7, 0, i)

            If Not idOlddate = item.DateExpirate Then
                pointfin.Y = endPoint.Y * 0.5
            Else
                pointfin.Y -= endPoint.Y * 0.1
            End If

            sql = "Producto: " & item.Nom_Comercial & vbCrLf
            sql = sql & String.Format("Caduca en:{0} dias. ({1:d})", item.intervalo, item.DateExpirate) & vbCrLf
            sql = sql & String.Format("En stock:{0} {1})", item.stock, item.Und)

            pointIni.X = starPointy.X + (Me.NowDay + item.intervalo) * Pixel
            pointfin.X = starPointy.X + (Me.NowDay + item.intervalo) * Pixel

            DrawLine(sql, pointIni, pointfin, A(i))

            idOlddate = item.DateExpirate
            i += 1
        Next
        Dim rcta As RectangleShape = New RectangleShape
        rcta.Width = PanelRectangle.Width
        rcta.Height = PanelRectangle.Height
        rcta.Location = PanelRectangle.Location
        rcta.BackStyle = BackStyle.Transparent
        rcta.BorderWidth = PanelRectangle.BorderWidth
        rcta.CornerRadius = PanelRectangle.CornerRadius
        rcta.Parent = PanelContainer
        For Each item In PanelContainer.Controls
            PanelContainer.Controls.Add(item)
        Next
    End Sub


    Private Sub fildateExpit()
        If Me.ListIndex Is Nothing Then
            Return
        End If

        If ListIndex.Count = 0 Then
            Return
        End If

        If Me.ListBodegaComboBox.SelectedIndex = -1 Then
            Return
        End If

        Using cmd As New filterDataExpirForDrawTableAdapter
            Using dt As New filterDataExpirForDrawDataTable
                cmd.Fill(dt, Integer.Parse(ListBodegaComboBox.SelectedValue), Me.ListIndex.FirstOrDefault().DateStarDraw,
                         Me.ListIndex.FirstOrDefault().DateEndDraw)
                Me.ListDataExpir = dt.ToList()
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Label3.Click

        Try
            Me.LabelDescription.Text = String.Empty
            Me.Cursor = Cursors.WaitCursor
            PictureBox1.Parent.BackColor = Color.Yellow
            PictureBox2.Parent.BackColor = MenuStrip1.BackColor
            Me.Paneldata.Visible = False
            Me.PanelGraf.Visible = True
            Me.PanelFilter.Visible = False
            Me.PanelGraf.Dock = DockStyle.Fill
            RefresImage()
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub loadDataGrafigView()
        Try
            Me.Cursor = Cursors.WaitCursor

            load_DataIndex()
            fildateExpit()
            DrawRectangle()
            DrawDataView()
            DrawXY()
            DrawMoths()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub RefresImage()
        If ListIndex.Count = 0 Then
            load_DataIndex()
            fildateExpit()
        End If

        DrawRectangle()
        DrawDataView()
        DrawXY()
        DrawMoths()
    End Sub


    Private Sub DrawRectangle()
        Me.Panel4.Controls.Clear()
        PanelContainer.Controls.Clear()
        Dim cont As New ShapeContainer
        PanelContainer = Nothing

        PanelContainer = New ShapeContainer
        PanelContainer.Parent = Panel4
        sHAPE()
    End Sub
    Private Sub sHAPE()

        PanelRectangle.Parent = PanelContainer
        PanelRectangle.BackColor = Color.White
        PanelRectangle.BorderWidth = 2
        PanelRectangle.BackStyle = BackStyle.Transparent
        PanelRectangle.Size = New System.Drawing.Size(Me.Panel4.Width - 20, Me.Panel4.Height - 20)
        PanelRectangle.Location = New System.Drawing.Point(5, 5)
        PanelRectangle.CornerRadius = 12
        PanelRectangle.Visible = False
        Pixel = (PanelRectangle.Width - 10) / Me.totalLinesData

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label4.Click
        Me.LabelDescription.Text = String.Empty
        PictureBox2.Parent.BackColor = Color.Yellow
        PictureBox1.Parent.BackColor = MenuStrip1.BackColor
        Me.PanelGraf.Visible = False
        Me.Paneldata.Visible = True
        Me.Paneldata.Dock = DockStyle.Fill
        Me.PanelFilter.Visible = True
        PanelFilter.Width = 300

        Me.DateTimePicker1.Value = Date.Now().AddDays(-30)
        Me.DateTimePicker2.Value = Date.Now().AddDays(+120)

    End Sub

    Private Sub MenuStrip1_SizeChanged(sender As Object, e As EventArgs) Handles MenuStrip1.SizeChanged
        If MenuStrip1.Width >= 100 Then
            For Each item As System.Windows.Forms.Control In Me.PanelBarrControl.Controls
                If item.Name.Contains("Label") Then
                    item.Visible = True
                End If
            Next
            For Each item As System.Windows.Forms.Control In Me.PanelListControl.Controls
                If item.Name.Contains("Label") Then
                    item.Visible = True
                End If
            Next
        Else
            For Each item As System.Windows.Forms.Control In Me.PanelBarrControl.Controls
                If item.Name.Contains("Label") Then
                    item.Visible = False
                End If
            Next
            For Each item As System.Windows.Forms.Control In Me.PanelListControl.Controls
                If item.Name.Contains("Label") Then
                    item.Visible = False
                End If
            Next
        End If
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim list = GetDataProdcut(Trim(Me.FindTextBox1.Text))
        If list.Count > 0 Then
            ListViewProducto.GridLines = True
            ListViewProducto.View = View.Details
            ListViewProducto.DataSource = list
            Me.deletefilterButton.Visible = True
        Else
            ListViewProducto.GridLines = False
            ListViewProducto.View = View.LargeIcon
            Me.deletefilterButton.Visible = False
        End If
    End Sub
    Private Function GetDataProdcut(fintext As String) As List(Of ProductosRow)

        Dim listProduct As New List(Of ProductosRow)
        Dim list1 As New List(Of ProductosRow)
        Dim list2 As New List(Of ProductosRow)

        Dim listReturn As New List(Of ProductosRow)

        If String.IsNullOrWhiteSpace(fintext) Then
            Return listReturn
        End If
        Try


            Dim response = GenerateSpliter(fintext)


            If response.IsSucces Then

                Using cnn As New SqlConnection(SimpleDataApp.Utility.GetConnectionString())
                    cnn.Open()
                    Using cmd As New ProductosTableAdapter
                        Using dt As New ProductosDataTable
                            cmd.Fill(dt)
                            listProduct = dt.ToList()
                        End Using
                    End Using
                End Using


                Select Case response.Spliter.Count
                    Case 1
                        listReturn = listProduct.Where(Function(x) x.Nom_Comercial.ToUpper().Contains(response.Spliter(0).ToUpper())).ToList()
                    Case 2
                        list1 = listProduct.Where(Function(x) x.Nom_Comercial.ToUpper().Contains(response.Spliter(0).ToUpper())).ToList()
                        listReturn = list1.Where(Function(x) x.Nom_Comercial.ToUpper().Contains(response.Spliter(1).ToUpper())).ToList()
                    Case 3
                        list1 = listProduct.Where(Function(x) x.Nom_Comercial.ToUpper().Contains(response.Spliter(0).ToUpper())).ToList()
                        list2 = list1.Where(Function(x) x.Nom_Comercial.ToUpper().Contains(response.Spliter(1).ToUpper())).ToList()
                        listReturn = list2.Where(Function(x) x.Nom_Comercial.ToUpper().Contains(response.Spliter(1).ToUpper())).ToList()

                    Case Else
                End Select
            End If
            Return listReturn
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        Finally
            Me.Cursor = DefaultCursor
        End Try
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewProducto.SelectedIndexChanged
        If Not ListViewProducto.SelectedObjects.Count = 1 Then
            Return
        End If
        Me.PanelGraf.Visible = False
        Me.Paneldata.Visible = True
        Me.Paneldata.Dock = DockStyle.Fill

        Try
            Dim item As ProductosRow = CType(Me.ListViewProducto.SelectedObject(), ProductosRow)
            If item Is Nothing Then
                Return
            End If
            Me.Nom_ComercialLabel.Text = item.Nom_Comercial
            Me.Nom_ComercialLabel.Tag = item.idProducto

            Me.ListViewSelectProduct.DataSource = GetSelectProductExpirate(item.idProducto)
            ListViewSelectProduct.Columns(Nom_ComercialClm2.Index).Width = 0
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub FindTextBox1_TextChanged(sender As Object, e As EventArgs) Handles FindTextBox1.TextChanged
        If FindTextBox1.Text.Length > 2 Then
            Me.AcceptButton = FindButton
        Else
            Me.AcceptButton = Nothing
        End If
    End Sub

    Private Function GetSelectProductExpirate(idProduct As Integer?) As List(Of getfilterExpirationWithIdProductRow)
        Try
            Using cmd As New getfilterExpirationWithIdProductTableAdapter
                Using dt As New getfilterExpirationWithIdProductDataTable
                    cmd.Fill(dt, idProduct, DateTimePicker1.Value, DateTimePicker2.Value)
                    Return dt.ToList()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Private Sub deletefilterButton_Click(sender As Object, e As EventArgs) Handles deletefilterButton.Click
        Me.FindTextBox1.Text = String.Empty
        ListViewProducto.RemoveObjects(ListViewProducto.DataSource)
        Me.ListViewProducto.View = View.LargeIcon
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If isLoated Then
            loadDataGrafigView()
        End If
    End Sub

    Private Sub ListBodegaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBodegaComboBox.SelectedIndexChanged
        Me.UpdateButton.PerformClick()
    End Sub

    Private Sub GetDataFillButton_Click(sender As Object, e As EventArgs) Handles GetDataFillButton.Click
        Me.ListViewSelectProduct.DataSource = GetSelectProductExpirate(0)
        ListViewSelectProduct.Columns(Nom_ComercialClm2.Index).Width = 250
    End Sub
    Private Sub addNewDateExpirButton_Click(sender As Object, e As EventArgs) Handles addNewDateExpirButton.Click
        If Not ListViewProducto.SelectedObjects.Count = 1 Then
            MsgBox("Seleecion un producto en el listado de la parte izquierda.")
            Return
        End If
        Try
            Dim item As ProductosRow = CType(Me.ListViewProducto.SelectedObject, ProductosRow)
            If item Is Nothing Then
                MsgBox("Seleecion un producto en el listado de la parte izquierda.")
                Return
            End If
            Using addfor As New frmAddNewDateExpir(item.idProducto, item.Nom_Comercial)
                addfor.ShowDialog()
                If addfor.DialogResult = DialogResult.OK Then
                    Me.ListViewSelectProduct.DataSource = GetSelectProductExpirate(item.idProducto)
                    ListViewSelectProduct.Columns(Nom_ComercialClm2.Index).Width = 0
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If Not MsgBox("Esta seguro de elimar la fecha de caducidad.?",
                  MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Responda") = MsgBoxResult.Yes Then
            Return
        End If
        Try
            Using db As New DataContext
                For Each item In Me.ListViewSelectProduct.SelectedObjects
                    If Not DeleteExpirWithDase(db, CType(item, getfilterExpirationWithIdProductRow)) Then
                        Return
                    End If
                Next

            End Using
            Me.ListViewSelectProduct.DataSource = GetSelectProductExpirate(0)
            ListViewSelectProduct.Columns(Nom_ComercialClm2.Index).Width = 250
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function DeleteExpirWithDase(db As DataContext, item As getfilterExpirationWithIdProductRow) As Boolean
        Dim idex = db.ProductExpiration.Where(Function(x) x.IDExpiration = item.IDExpiration).FirstOrDefault()
        If idex Is Nothing Then
            Return False
        End If
        Try
            db.ProductExpiration.DeleteOnSubmit(idex)
            db.SubmitChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function
End Class
