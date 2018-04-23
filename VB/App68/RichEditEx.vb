Imports Windows.Storage

Public Class RichEditEx
    Inherits RichEditBox

    Protected _Source As Uri

    Public Property Source() As Uri
        Get
            Return Me._Source
        End Get
        Set(ByVal value As Uri)
            Me._Source = value
            Me.OnSourceChanged()
        End Set
    End Property

    Private Async Sub OnSourceChanged()
        If Source Is Nothing Then
            Document.SetText(Windows.UI.Text.TextSetOptions.None, Nothing)
        Else
            Dim file As StorageFile = Await StorageFile.GetFileFromApplicationUriAsync(Source)
            Dim stream As Streams.IRandomAccessStream = Await file.OpenAsync(FileAccessMode.Read)
            Document.LoadFromStream(Windows.UI.Text.TextSetOptions.FormatRtf, stream)
        End If
    End Sub
End Class
