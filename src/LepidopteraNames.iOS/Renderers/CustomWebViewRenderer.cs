using LepidopteraNames.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(WebView), typeof(CustomWebViewRenderer))]

namespace LepidopteraNames.iOS.Renderers
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            var view = (UIWebView)NativeView;
            view.ScrollView.ScrollEnabled = true;
            view.ScalesPageToFit = true;
        }
    }
}
