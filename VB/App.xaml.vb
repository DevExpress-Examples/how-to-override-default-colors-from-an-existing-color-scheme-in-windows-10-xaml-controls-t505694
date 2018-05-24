Imports DevExpress.Core
Imports DevExpress.Themes.ColorKeys
Imports Windows.UI
''' <summary>
''' Provides application-specific behavior to supplement the default Application class.
''' </summary>
NotInheritable Class App
    Inherits Application

    Public Sub New()
        OverrideThemeColors()

        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLaunched(e As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)

        If rootFrame Is Nothing Then
            rootFrame = New Frame()

            AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed

            If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
            End If
            Window.Current.Content = rootFrame
        End If

        If e.PrelaunchActivated = False Then
            If rootFrame.Content Is Nothing Then
                rootFrame.Navigate(GetType(MainPage), e.Arguments)
            End If

            Window.Current.Activate()
        End If
    End Sub

    Private Sub OnNavigationFailed(sender As Object, e As NavigationFailedEventArgs)
        Throw New Exception("Failed to load Page " + e.SourcePageType.FullName)
    End Sub

    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
        deferral.Complete()
    End Sub


    Private Sub OverrideThemeColors()
        ThemeManager.GenericColorScheme.AllScopes.RibbonControlColors(RibbonControlColorKeys.HeaderBackground) = Color.FromArgb(&HFF, &H21, &H73, &H46)
        ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderContextualItemColors(RibbonHeaderContextualItemColorKeys.Background) = Color.FromArgb(&H33, &H0, &H0, &H0)
        ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderContextualItemColors(RibbonHeaderContextualItemColorKeys.ForegroundSelected) = Color.FromArgb(&HFF, &H21, &H73, &H46)
        ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderItemColors(RibbonHeaderItemColorKeys.ForegroundSelected) = Color.FromArgb(&HFF, &H21, &H73, &H46)
        ThemeManager.GenericColorScheme.AllScopes.BackstageViewColors(BackstageViewColorKeys.Background) = Color.FromArgb(&HAA, &HFF, &HFF, &HFF)
        ThemeManager.GenericColorScheme.AllScopes.BackstageViewColors(BackstageViewColorKeys.TabContentBackground) = Colors.Transparent

        ThemeManager.Win8ColorScheme.AllScopes.RibbonControlColors(RibbonControlColorKeys.HeaderBackground) = Color.FromArgb(&HFF, &H9, &H34, &H67)
        ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderContextualItemColors(RibbonHeaderContextualItemColorKeys.Background) = Color.FromArgb(&H33, &H0, &H0, &H0)
        ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderContextualItemColors(RibbonHeaderContextualItemColorKeys.ForegroundSelected) = Color.FromArgb(&HFF, &H2B, &H57, &H9A)
        ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderItemColors(RibbonHeaderItemColorKeys.ForegroundSelected) = Color.FromArgb(&HFF, &H2B, &H57, &H9A)
        ThemeManager.Win8ColorScheme.AllScopes.BackstageViewColors(BackstageViewColorKeys.Background) = Color.FromArgb(&H77, &HFF, &HFF, &HFF)
        ThemeManager.Win8ColorScheme.AllScopes.BackstageViewColors(BackstageViewColorKeys.TabContentBackground) = Colors.Transparent
    End Sub

End Class
