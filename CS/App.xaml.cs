using DevExpress.Core;
using DevExpress.Themes.ColorKeys;
using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace App68 {

    sealed partial class App : Application {
        public App() {
            OverrideThemeColors();

            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        void OverrideThemeColors() {
            ThemeManager.GenericColorScheme.AllScopes.RibbonControlColors[RibbonControlColorKeys.HeaderBackground] = Color.FromArgb(0xFF, 0x21, 0x73, 0x46);
            ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.Background] = Color.FromArgb(0x33, 0x00, 0x00, 0x00);
            ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.ForegroundSelected] = Color.FromArgb(0xFF, 0x21, 0x73, 0x46);
            ThemeManager.GenericColorScheme.AllScopes.RibbonHeaderItemColors[RibbonHeaderItemColorKeys.ForegroundSelected] = Color.FromArgb(0xFF, 0x21, 0x73, 0x46);
            ThemeManager.GenericColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.Background] = Color.FromArgb(0xAA, 0xFF, 0xFF, 0xFF);
            ThemeManager.GenericColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.TabContentBackground] = Colors.Transparent;

            ThemeManager.Win8ColorScheme.AllScopes.RibbonControlColors[RibbonControlColorKeys.HeaderBackground] = Color.FromArgb(0xFF, 0x09, 0x34, 0x67);
            ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.Background] = Color.FromArgb(0x33, 0x00, 0x00, 0x00);
            ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderContextualItemColors[RibbonHeaderContextualItemColorKeys.ForegroundSelected] = Color.FromArgb(0xFF, 0x2B, 0x57, 0x9A);
            ThemeManager.Win8ColorScheme.AllScopes.RibbonHeaderItemColors[RibbonHeaderItemColorKeys.ForegroundSelected] = Color.FromArgb(0xFF, 0x2B, 0x57, 0x9A);
            ThemeManager.Win8ColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.Background] = Color.FromArgb(0x77, 0xFF, 0xFF, 0xFF);
            ThemeManager.Win8ColorScheme.AllScopes.BackstageViewColors[BackstageViewColorKeys.TabContentBackground] = Colors.Transparent;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e) {
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null) {
                rootFrame = new Frame();//{ AllowCustomizingWindowTitle = true, WindowTitle = "Sample Application" };
                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated) {
                }

                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false) {
                if (rootFrame.Content == null) {
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }
                Window.Current.Activate();
            }
        }

        void OnNavigationFailed(object sender, NavigationFailedEventArgs e) {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        private void OnSuspending(object sender, SuspendingEventArgs e) {
            var deferral = e.SuspendingOperation.GetDeferral();
            deferral.Complete();
        }
    }
}
