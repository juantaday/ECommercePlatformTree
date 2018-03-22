Namespace DataInternal
    Public Module GetDataFile
        Private listTypes As List(Of FileTypes)
        Public Function GetDateFile(ByVal typeData As typeFile) As IList
            listTypes = New List(Of FileTypes)
            BuildData(typeData)
            Return listTypes
        End Function

        Private Sub BuildData(typeData As typeFile)
            Select Case typeData
                Case typeFile.Backup
                    GeneratedFileBackup()
                Case typeFile.Data

                Case typeFile.Images
                Case typeFile.Text
            End Select
        End Sub

        Private Sub GeneratedFileBackup()
            listTypes.Add(New FileTypes With
                          {
                          .ID = 0,
                          .NameFile = "Archivos de copia de seguridad(*.bak)",
                          .Extension = ".bak"
                          })
            listTypes.Add(New FileTypes With
                          {
                          .ID = 1,
                          .NameFile = "Archivos de copia de seguridad(*.tm)",
                          .Extension = ".tm"
                          })
        End Sub


    End Module

End Namespace
