using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LepidopteraNames.Models;
using Xamarin.Forms;

namespace LepidopteraNames.ViewModels
{
    public class TaxonViewModel : ViewModelBase
    {
        private Command _closeCommand;

        public TaxonViewModel(Taxon taxon)
        {
            Taxon = taxon;
        }

        public Taxon Taxon
        {
            get { return GetProperty<Taxon>(); }
            set { SetProperty(value); }
        }

        public bool CanGoBack
        {
            get { return GetProperty<bool>(); }
            set { SetProperty(value); }
        }
        public bool CanGoForward
        {
            get { return GetProperty<bool>(); }
            set { SetProperty(value); }
        }

        public Command CloseCommand
        {
            get
            {
                return _closeCommand ?? (_closeCommand = new Command(async () =>
                {
                    await Navigation.PopModalAsync();
                }));
            }
        }
    }
}
