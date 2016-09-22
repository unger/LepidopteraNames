using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LepidopteraNames.Models;
using Xamarin.Forms;

namespace LepidopteraNames.ViewModels
{
    public abstract class ViewModelBase : NotifyPropertyChangedBase
    {
        private Func<Task> doneAction;
        private Func<Task> cancelAction;

        public string Title
        {
            get { return GetProperty<string>(); }
            set { SetProperty(value); }
        }

        public bool IsDone
        {
            get { return GetProperty<bool>(); }
            set { SetProperty(value); }
        }

        public bool IsBusy
        {
            get { return GetProperty<bool>(); }
            set { SetProperty(value); }
        }

        public void SetState<T>(Action<T> action) where T : class
        {
            action(this as T);
        }

        public void SetDoneAction(Func<Task> action)
        {
            doneAction = action;
        }

        public void SetCancelAction(Func<Task> action)
        {
            cancelAction = action;
        }

        public async Task DoneAction()
        {
            if (doneAction != null)
            {
                await doneAction();
            }
        }

        public async Task CancelAction()
        {
            if (cancelAction != null)
            {
                await cancelAction();
            }
        }

        public INavigation Navigation { get; set; }

        public virtual void Appearing()
        {
        }

        public virtual void Disappearing()
        {
        }
    }
}
