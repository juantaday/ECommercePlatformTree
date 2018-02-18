Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

<System.Windows.Data.ValueConversion(GetType(Byte()), GetType(ImageSource))>
Public Class BinaryJPEGToImageSourceConverter
    Implements System.Windows.Data.IValueConverter
    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
        Dim binaryimagedata As UInt32() = New UInt32(100 * 100 - 1) {}
        For i As Long = 0 To 9999
            binaryimagedata(i) = &HFFFFFF00UI
        Next
        Dim bitmapSource__1 As BitmapSource = BitmapSource.Create(100, 100, 96, 96, PixelFormats.Pbgra32, Nothing,
            binaryimagedata, 400)
        Return bitmapSource__1
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
        Throw New NotImplementedException()
    End Function

    Private Function IValueConverter_Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Throw New NotImplementedException()
    End Function

    Private Function IValueConverter_ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class
