using System;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace App68 {
    public class RichEditEx : RichEditBox {

        protected Uri _Source;

        public Uri Source {
            get {
                return this._Source;
            }
            set {
                this._Source = value;
                this.OnSourceChanged();
            }
        }

        async void OnSourceChanged() {
            if (Source == null) {
                Document.SetText(Windows.UI.Text.TextSetOptions.None, null);
            }
            else {
                var file = await StorageFile.GetFileFromApplicationUriAsync(Source);
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                Document.LoadFromStream(Windows.UI.Text.TextSetOptions.FormatRtf, stream);
            }
        }
    }
}
