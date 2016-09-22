using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LepidopteraNames.Services;
using LepidopteraNames.ViewModels;
using Xamarin.Forms;

namespace LepidopteraNames.Views
{
    public partial class SearchTaxonPage : ContentPage
    {
        public SearchTaxonPage()
        {
            InitializeComponent();

            var vm = new SearchTaxonViewModel(new TaxonService());
            vm.Navigation = Navigation;
            BindingContext = vm;
        }
    }
}
