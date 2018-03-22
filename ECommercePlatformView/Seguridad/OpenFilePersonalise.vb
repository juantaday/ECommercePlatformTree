Imports System.Windows.Forms
Imports System
Imports BrightIdeasSoftware.Helpers
Imports BrightIdeasSoftware
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Text

Public Class OpenFilePersonalise
    Private TypeFile As typeFile
    Private ObjectModelo As Object
    Public FullName As String
    Dim _Object As Object
    Sub New(tyFile As typeFile, Optional file As String = "")

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.TypeFile = tyFile
        FullName = file
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If SaveNewFile() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub OpenFilePersonalise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTreeListExample()
        LoadData()
        AutoExpant(FullName)

    End Sub

    Private Sub AutoExpant(_fullName As String)
        If String.IsNullOrWhiteSpace(_fullName) Then
            Return
        End If

        ObjectModelo = Me.MytreeListView.Roots

        Dim mydata As String() = Split(_fullName, "\")
        For Each spliIndex In mydata
            FilterRoots(spliIndex)
        Next
    End Sub
    Private Sub FilterRoots(filter As String)
        For Each item In ObjectModelo

            Dim source As String = item.FullName
            Dim stringSeparators() As String = {"\"}
            Dim result() As String
            result = source.Split(stringSeparators,
                      StringSplitOptions.RemoveEmptyEntries)


            If result(result.Length - 1) = filter Then
                SetExpand(item)
                ObjectModelo = MytreeListView.GetChildren(item)
                Return
            End If
        Next
    End Sub
    Private Sub SetExpand(item As Object)
        MytreeListView.Expand(item)
    End Sub

    Private Sub LoadData()
        Try
            Me.TypeFileComboBox.DataSource = DataInternal.GetDateFile(Me.TypeFile)
            Me.TypeFileComboBox.ValueMember = "ID"
            Me.TypeFileComboBox.DisplayMember = "NameFile"
            If Me.TypeFileComboBox.Items.Count > 0 Then
                Me.TypeFileComboBox.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub InitializeTreeListExample()
        Try
            MytreeListView.HierarchicalCheckboxes = False
            MytreeListView.HideSelection = False
            MytreeListView.CanExpandGetter = Function(x As Object)
                                                 Return CType(x, MyFileSystemInfo).IsDirectory
                                             End Function

            MytreeListView.ChildrenGetter = Function(x As Object)
                                                Dim myFileSystemInfo As MyFileSystemInfo = CType(x, MyFileSystemInfo)
                                                Try
                                                    Return myFileSystemInfo.GetFileSystemInfos()
                                                Catch ex As UnauthorizedAccessException
                                                    MessageBox.Show(Me, ex.Message, "ObjectListViewDemo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                                    Return New ArrayList()
                                                End Try

                                            End Function



            Dim renderer As TreeListView.TreeRenderer = Me.MytreeListView.TreeColumnRenderer
            renderer.LinePen = New Pen(Color.Firebrick, 0.5F)
            renderer.LinePen.DashStyle = DashStyle.Dot


            Dim helper As SysImageListHelper = New SysImageListHelper(Me.MytreeListView)
            treeColumnName.ImageGetter = Function(X As Object)
                                             Return helper.GetImageIndex(CType(X, MyFileSystemInfo).FullName)
                                         End Function

            ' Show the size of files as GB, MB And KBs. Also, group them by
            ' some meaningless divisions

            treeColumnSize.AspectGetter = Function(x As Object)
                                              Dim myFileSystemInfo As MyFileSystemInfo = CType(x, MyFileSystemInfo)

                                              If (myFileSystemInfo.IsDirectory) Then
                                                  Return -1
                                              End If

                                              Try
                                                  Return myFileSystemInfo.Length
                                              Catch ex As System.IO.FileNotFoundException
                                                  ' // Mono 1.2.6 throws this for hidden files
                                                  Return -2
                                              End Try
                                          End Function
            treeColumnSize.AspectToStringConverter = Function(x As Object)
                                                         If (x = -1) Then  ' // folder
                                                             Return ""
                                                         End If
                                                         Return FormatFileSize(x)
                                                     End Function

            '// Show the system description for this object
            treeColumnFileType.AspectGetter = Function(x As Object)
                                                  Return ShellUtilities.GetFileType(CType(x, MyFileSystemInfo).FullName)
                                              End Function

            '// Show the file attributes for this object
            treeColumnAttributes.AspectGetter = Function(x As Object)
                                                    Return (CType(x, MyFileSystemInfo)).Attributes
                                                End Function
            Dim attributesRenderer As FlagRenderer = New FlagRenderer()
            attributesRenderer.Add(FileAttributes.Archive, "archive")
            attributesRenderer.Add(FileAttributes.ReadOnly, "readonly")
            attributesRenderer.Add(FileAttributes.System, "system")
            attributesRenderer.Add(FileAttributes.Hidden, "hidden")
            attributesRenderer.Add(FileAttributes.Temporary, "temporary")
            treeColumnAttributes.Renderer = attributesRenderer
            treeColumnAttributes.ClusteringStrategy =
             New FlagClusteringStrategy(GetType(System.IO.FileAttributes))

            ' // List all drives as the roots of the tree
            Dim roots As ArrayList = New ArrayList()
            For Each di In DriveInfo.GetDrives()
                If (di.IsReady) Then
                    roots.Add(New MyFileSystemInfo(New DirectoryInfo(di.Name)))
                End If
            Next
            MytreeListView.Roots = roots

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    Private Function FormatFileSize(ByVal size As Long) As String
        Dim limits As Integer() = New Integer() {1024 * 1024 * 1024, 1024 * 1024, 1024}
        Dim units As String() = New String() {"GB", "MB", "KB"}
        For i As Integer = 0 To limits.Length - 1
            If size >= limits(i) Then Return String.Format("{0:#,##0.##} " & units(i), (CDbl(size) / limits(i)))
        Next

        Return String.Format("{0} bytes", size)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim roots As ArrayList = New ArrayList()
        For Each di In DriveInfo.GetDrives()
            If (di.IsReady) Then
                roots.Add(New MyFileSystemInfo(New DirectoryInfo(di.Name)))
            End If
        Next
        MytreeListView.Roots = roots
    End Sub

    Private Sub TreeListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MytreeListView.SelectedIndexChanged
        Try
            If MytreeListView.SelectedObjects.Count = 1 Then
                _Object = MytreeListView.SelectedObject
                _Object.FullName.ToString()
                If Not IsNothing(_Object.AsFile) Then
                    Me.FileRelativeTextBox.Text = _Object.AsFile.DirectoryName.ToString()
                    Me.FileNameTextBox.Text = _Object.Info.Name.ToString()
                Else
                    Me.FileRelativeTextBox.Text = _Object.FullName.ToString()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Function SaveNewFile() As Boolean
        FullName = String.Empty
        Dim rutaNombreFichEAN As String = String.Empty
        Dim nameFile As String
        Dim extention As String

        If Not IsNothing(Me._Object) Then
            Try
                If Not IsNothing(Me._Object.AsFile) Then
                    rutaNombreFichEAN = Me._Object.Info.Directory.FullName.ToString()
                    nameFile = _Object.Info.Name
                    extention = _Object.Info.Extension

                    rutaNombreFichEAN = String.Format("{0}\{1}", rutaNombreFichEAN, nameFile)
                    If Not (extention.Contains("bak") Or extention.Contains(".tm")) Then
                        MsgBox("El archivo no es válido", MsgBoxStyle.Exclamation, "Importante")
                        Return False
                    End If

                Else
                    rutaNombreFichEAN = Me._Object.FullName.ToString()
                    If String.IsNullOrWhiteSpace(Me.FileNameTextBox.Text) Then
                        MsgBox("Escriba el nombre del archivo.", MsgBoxStyle.Exclamation, "Importante")
                        Return False
                    End If
                    nameFile = Me.FileNameTextBox.Text
                    extention = "bak"
                    rutaNombreFichEAN = String.Format("{0}\{1}.{2}", rutaNombreFichEAN, nameFile, extention)
                End If

                FullName = rutaNombreFichEAN
                If Dir(rutaNombreFichEAN) <> "" Then
                    Return True
                Else
                    Return SaveFile(rutaNombreFichEAN)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Private Function SaveFile(rutaNombreFichEAN As String) As Boolean
        Dim path As String = rutaNombreFichEAN

        ' Create or overwrite the file.
        Try
            Dim fs As FileStream = File.Create(path)

            ' '--Add text to the file.
            'Dim info As Byte() = New UTF8Encoding(True).GetBytes("This is some text in the file.")
            'fs.Write(info, 0, info.Length)
            fs.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.MytreeListView.Collapse(Me.MytreeListView.Roots)
    End Sub

    Private Sub treeListView_ItemActivate(sender As Object, e As EventArgs) Handles MytreeListView.ItemActivate
        Dim model As Object = Me.MytreeListView.SelectedObject
        If Not IsNothing(model) Then
            Me.MytreeListView.ToggleExpansion(model)
        End If
    End Sub

    Private Sub treeListView_ModelCanDrop(sender As Object, e As ModelDropEventArgs) Handles MytreeListView.ModelCanDrop
        e.Effect = DragDropEffects.None
        If e.TargetModel IsNot Nothing Then
            If TypeOf e.TargetModel Is DirectoryInfo Then
                e.Effect = e.StandardDropActionFromKeys
            Else
                e.InfoMessage = "Can only drop on directories"
            End If
        End If
    End Sub


End Class
