Module convertBitmapToBites
    Public Function ConvertToByteArray(ByVal value As Image) As Byte()
        Dim bitmapBytes As Byte()

        Using stream As New System.IO.MemoryStream
            value.Save(stream, value.RawFormat)
            bitmapBytes = stream.ToArray
        End Using

        Return bitmapBytes
    End Function

    Public Function ConvertByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using ms As New IO.MemoryStream(byteArrayIn)
            Dim returnImage As Image = Image.FromStream(ms)
            Return returnImage
        End Using
    End Function
    Public Function ConvertImageToByteArray(ByVal imageIn As System.Drawing.Image) As Byte()
        Using ms As New IO.MemoryStream()
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function
End Module
