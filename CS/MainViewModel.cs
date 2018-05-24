using DevExpress.Core;
using DevExpress.Mvvm;
using System.Collections.Generic;

namespace App68 {
    public class MainViewModel : ViewModelBase {

        public MainViewModel() {
            this.ColorSchemeName = this.ColorSchemeNames[0];
        }

        protected List<string> _ColorSchemeNames;
        public List<string> ColorSchemeNames {
            get {
                if (this._ColorSchemeNames == null) {
                    this._ColorSchemeNames = new List<string>() { ThemeManager.GenericSchemeName, ThemeManager.Win8SchemeName };
                }
                return this._ColorSchemeNames;
            }
        }

        public string ColorSchemeName {
            get {
                return ThemeManager.CurrentColorSchemeName;
            }
            set {
                ThemeManager.CurrentColorSchemeName = value;
                this.RaisePropertyChanged("ColorSchemeName");
            }
        }


    }
}
