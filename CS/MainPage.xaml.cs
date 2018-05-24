using DevExpress.Core;
using DevExpress.UI.Xaml.Layout;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App68 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : DXPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if(ThemeManager.CurrentColorSchemeName == "Generic") {
                ThemeManager.CurrentColorSchemeName = "GreenTitleColorScheme";
            }
            else {
                ThemeManager.CurrentColorSchemeName = "Generic";
            }
        }
    }
}
