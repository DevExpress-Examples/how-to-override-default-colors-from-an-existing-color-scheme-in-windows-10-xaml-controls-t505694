Imports DevExpress.Core
Imports DevExpress.Mvvm

Public Class MainViewModel
    Inherits ViewModelBase

    Public Sub New()
        Me.ColorSchemeName = Me.ColorSchemeNames(0)
    End Sub

    Protected _ColorSchemeNames As List(Of String)
    Public ReadOnly Property ColorSchemeNames() As List(Of String)
        Get
            If Me._ColorSchemeNames Is Nothing Then
                Me._ColorSchemeNames = New List(Of String)(New String() {ThemeManager.GenericSchemeName, ThemeManager.Win8SchemeName})
            End If
            Return Me._ColorSchemeNames
        End Get
    End Property

    Public Property ColorSchemeName() As String
        Get
            Return ThemeManager.CurrentColorSchemeName
        End Get
        Set(ByVal value As String)
            ThemeManager.CurrentColorSchemeName = value
            Me.RaisePropertyChanged("ColorSchemeName")
        End Set
    End Property


End Class
