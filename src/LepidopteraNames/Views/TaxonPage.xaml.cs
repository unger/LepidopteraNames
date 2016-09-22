using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LepidopteraNames.Models;
using LepidopteraNames.ViewModels;
using Xamarin.Forms;

namespace LepidopteraNames.Views
{
    public partial class TaxonPage : ContentPage
    {
        public TaxonPage(Taxon taxon)
        {
            InitializeComponent();

            var vm = new TaxonViewModel(taxon);
            vm.Navigation = Navigation;
            BindingContext = vm;
            //Browser.Source = new UrlWebViewSource() { Url = string.Format("http://www.lepidoptera.se/arter/{0}.aspx", taxon.Name.ToLower().Replace(" ", "_")) };
            Browser.Source = new UrlWebViewSource() { Url = string.Format("https://www.google.com/search?tbm=isch&q={0}", taxon.ScientificName.Replace(" ", "%20")) };
        }

        private void backClicked(object sender, EventArgs e)
        {
            //check to see if there is anywhere to go back to
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
        }

        private void forwardClicked(object sender, EventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
            }
        }
    }
}
