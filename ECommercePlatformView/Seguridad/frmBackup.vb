Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class frmBackup
    Private MyBackColor As Color
    Private ListProperty As List(Of ItemProperty)
    Public MyDirFiles As List(Of FileTypes)
    Public isClosable As Boolean
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MyDirFiles = New List(Of FileTypes)
    End Sub

    Private Sub frmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AccordionControl1.CollapseAll()
        InitializaComponet()
        LoadData()

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If ValidatedControls() Then
            Dim bottoonmy As Button
            isClosable = True
            Select Case Me.PanelView.Tag
                Case 0
                    bottoonmy = PanelView.Controls(0).Controls("btnbackup")
                    bottoonmy.Tag = 0
                    bottoonmy.PerformClick()
                    If bottoonmy.Tag = 1 Then
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                Case 1

            End Select

        End If

    End Sub

    Private Function ValidatedControls() As Boolean
        SaveLastedFile()
        Return True
    End Function
    Private Sub SaveLastedFile()
        Try
            Dim path As String = String.Format("{0}\FileBackup.txt", Application.StartupPath)
            If Dir(path) <> "" Then
                Kill(path)
            End If

            Dim fs As FileStream = File.Create(path)
            Dim index As Integer = 1

            For Each item In MyDirFiles
                Dim info As Byte() = New UTF8Encoding(True).GetBytes(item.NameFile)
                fs.Write(info, 0, info.Length)

                If Not (index = MyDirFiles.Count) Then
                    info = New UTF8Encoding(True).GetBytes(vbCrLf)
                    fs.Write(info, 0, info.Length)
                End If
                index += 1
            Next
            fs.Close()
        Catch ex As Exception
            MsgBox(ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub ViewLastedFile()

        Dim path As String = String.Format("{0}\FileBackup.txt", Application.StartupPath)
        If Dir(path) <> "" Then
            Try

                Dim line As String

                '//Pass the file path And file name to the StreamReader constructor
                Dim SR As StreamReader = New StreamReader(path)

                '//Read the first line of text
                line = SR.ReadLine()

                '//Continue to read until you reach end of file
                While (Not IsNothing(line))
                    MyDirFiles.Add(New FileTypes With {.NameFile = line})
                    line = SR.ReadLine()
                End While

                SR.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        End If

    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub LoadData()
        laod_Property()
        ViewLastedFile()
    End Sub


    Private Sub InitializaComponet()

        MyBackColor = Me.SettingControls.Appearance.Pressed.BackColor

        PropertiesClm.AspectGetter = Function(ByVal row As Object)
                                         Dim p As ItemProperty = CType(row, ItemProperty)
                                         If Not IsNothing(p) Then
                                             Return p.NameDescription
                                         End If
                                         Return Nothing
                                     End Function

        PropertiesClm.ImageGetter = Function(ByVal row As Object)
                                        Dim p As ItemProperty = CType(row, ItemProperty)
                                        If Not IsNothing(p) Then
                                            Return Integer.Parse(p.ID)
                                        Else
                                            Return -1
                                        End If
                                    End Function


    End Sub



    Private Sub laod_Property()
        If IsNothing(ListProperty) Then
            ListProperty = New List(Of ItemProperty)
        Else
            ListProperty.Clear()
        End If
        ListProperty.Add(New ItemProperty With
                          {.ID = 0,
                          .ImageIndex = 0,
                          .NameDescription = "General"
                        })
        ListProperty.Add(New ItemProperty With
                         {.ID = 1,
                         .ImageIndex = 1,
                         .NameDescription = "Opciones de medio"
                       })

        ListProperty.Add(New ItemProperty With
                         {.ID = 2,
                         .ImageIndex = 2,
                         .NameDescription = "Opciones de copia de seguridad"
                       })

        Me.ListView1.SetObjects(ListProperty)


    End Sub

    Private Class ItemProperty
        Sub New()

        End Sub
        Sub New(id As Int16, descripcion As String, IndexImage As Int16)
            Me.ID = id
            Me.NameDescription = descripcion
            Me.ImageIndex = IndexImage
        End Sub
        Sub New(other As ItemProperty)
            Me.ID = other.ID
            Me.NameDescription = other.NameDescription
            Me.ImageIndex = other.ImageIndex
        End Sub
        Private _id As Int16
        Public Property ID() As Int16
            Get
                Return _id
            End Get
            Set(ByVal value As Int16)
                _id = value
            End Set
        End Property
        Private _Name As String
        Public Property NameDescription() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property
        Private _idImageIndex As Int16
        Public Property ImageIndex() As Int16
            Get
                Return _idImageIndex
            End Get
            Set(ByVal value As Int16)
                _idImageIndex = value
            End Set
        End Property
    End Class

    Private Sub PreViewButton_Click(sender As Object, e As EventArgs) Handles PreViewButton.Click
        Me.PanelView.Tag = 0
        PreViewButton.Appearance.Normal.BackColor = Color.LightBlue
        SettingControls.Appearance.Normal.BackColor = MyBackColor

        Try
            Me.Cursor = Cursors.WaitCursor
            PanelView.Controls.Clear()
            Dim TabBalanceGeneral1 = New ECommercePlatformView.
                    frmbackup_Simple(Me, If(Me.MyDirFiles.Count > 0,
                    Me.MyDirFiles(Me.MyDirFiles.Count - 1).NameFile,
                    String.Empty))

            TabBalanceGeneral1.Dock = DockStyle.Fill
            PanelView.Controls.Add(TabBalanceGeneral1)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub SettingControls_Click(sender As Object, e As EventArgs) Handles SettingControls.Click
        Me.PanelView.Tag = 1
        SettingControls.Appearance.Normal.BackColor = Color.LightBlue
        PreViewButton.Appearance.Normal.BackColor = MyBackColor
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Me.Cursor = Cursors.WaitCursor
            If ListView1.SelectedIndex = 0 Then
                Me.PanelView.Controls.Clear()
                Dim view As New BackupGeneral(MyDirFiles)
                Me.PanelView.Controls.Add(view)
                view.Dock = DockStyle.Fill
            ElseIf ListView1.SelectedIndex = 1 Then
                Me.PanelView.Controls.Clear()
                Dim view As New BackupOverwrite
                Me.PanelView.Controls.Add(view)
                view.Dock = DockStyle.Fill
            ElseIf ListView1.SelectedIndex = 2 Then
                Me.PanelView.Controls.Clear()
                Dim view As New BackupMediaOption
                Me.PanelView.Controls.Add(view)
                view.Dock = DockStyle.Fill
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub frmBackup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = isClosable
    End Sub
End Class


