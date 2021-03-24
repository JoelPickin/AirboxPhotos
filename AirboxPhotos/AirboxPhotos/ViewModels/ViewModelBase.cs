using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirboxPhotos.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        protected bool IsNewNavigation(INavigationParameters navParams)
        {
            try
            {
                return navParams.GetNavigationMode() == Prism.Navigation.NavigationMode.New;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return true;
            }
        }

        public virtual void Destroy()
        {

        }
    }
}
