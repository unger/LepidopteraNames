using System.Collections.Generic;
using System.Windows.Input;
using LepidopteraNames.Models;
using LepidopteraNames.Services;
using LepidopteraNames.Views;
using Xamarin.Forms;

namespace LepidopteraNames.ViewModels
{
    public class SearchTaxonViewModel : ViewModelBase
    {
        private readonly ITaxonService _taxonService;
        private ICommand _detailCommand;
        private ICommand _searchCommand;

        public SearchTaxonViewModel(ITaxonService taxonService)
        {
            _taxonService = taxonService;
        }

        public List<Taxon> Taxons
        {
            get { return GetProperty<List<Taxon>>(); }
            set { SetProperty(value); }
        }

        public string SearchText
        {
            get { return GetProperty<string>(); }
            set
            {
                SetProperty(value);
                Search();
            }
        }

        public ICommand DetailCommand
        {
            get
            {
                return _detailCommand ?? (_detailCommand = new Command<Taxon>(async x =>
                {
                    await Navigation.PushModalAsync(new NavigationPage(new TaxonPage(x)));
                }));
            }
        }
        public ICommand SearchCommand
        {
            get
            {
                return _searchCommand ?? (_searchCommand = new Command(() =>
                {
                    Search();
                }));
            }
        }

        private void Search()
        {
            Taxons = _taxonService.Search(SearchText);
        }
    }
}
