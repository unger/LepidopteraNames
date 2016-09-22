using System;
using System.Collections.Generic;
using System.Text;
using LepidopteraNames.iOS.Renderers;
using LepidopteraNames.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SearchBar), typeof(SwedishSearchBarRenderer))]


namespace LepidopteraNames.iOS.Renderers
{
    public class SwedishSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "Text")
            {
                Control.ShowsCancelButton = false;
            }
        }
    }
}
