Public Class AboutBox
    Private Const CodeProyecSpanish = "Spanish (Spain) (International sort) {7CA6EF39-748D-46C1-BC56-FE46919AA617}"
    Private Const CodeProyecEnglis = "English (United States) {D3A794A7-D91E-4B58-84B6-A0494AE4E015}"
    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Título de la aplicación
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        '
        Version.Text = System.String.Format("{0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        'Información de Copyright
        Copyright.Text = My.Application.Info.Copyright
        CodeProductSpanishLabel.Text = CodeProyecSpanish
        CodeProductEnglishLabel.Text = CodeProyecEnglis
    End Sub
End Class