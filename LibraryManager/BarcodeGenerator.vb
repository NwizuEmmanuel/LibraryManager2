Imports ZXing

Public Class BarcodeGenerator
    Function GenerateBarcode(text As String) As Bitmap
        Dim writer As New BarcodeWriter With {
            .Format = BarcodeFormat.CODE_128 ' You can change the format if needed
            }
        writer.Options.Width = 300
        writer.Options.Height = 150
        writer.Options.PureBarcode = True

        Return writer.Write(text)
    End Function
End Class
