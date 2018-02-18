Imports System.IO
Imports System.Text
Imports System.Windows.Media.Imaging

Module ImageAdmin
    Public Function ImageToByte(imageSource As BitmapImage) As [Byte]()
        Try
            Dim stream As MemoryStream = imageSource.StreamSource
            Dim byteToStream As [Byte]()
            byteToStream = stream.ToArray()
            Return byteToStream
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function
End Module
