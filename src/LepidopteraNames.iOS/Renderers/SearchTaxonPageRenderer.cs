using System;
using System.Collections.Generic;
using System.Text;
using LepidopteraNames.iOS.Renderers;
using LepidopteraNames.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SearchTaxonPage), typeof(SearchTaxonPageRenderer))]

namespace LepidopteraNames.iOS.Renderers
{
    public class SearchTaxonPageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            NavigationController.SetNavigationBarHidden(true, true);
        }
    }
}
