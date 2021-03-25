using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AirboxPhotos.ViewModels
{
    public class MainNavigationPageViewModel : ViewModelBase
    { 
        public ICommand NavigateToListPageCommand { get; set; }
        public ICommand NavigateToAlternativeListPageCommand { get; set; }

        public MainNavigationPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            NavigateToListPageCommand = new Command(async () => await NavigateToListPage());
            NavigateToAlternativeListPageCommand = new Command(async () => await NavigateToAlternativeListPage());
        }

        private async Task NavigateToListPage()
        {
            await NavigationService.NavigateAsync("PhotoListPage");
        }

        private async Task NavigateToAlternativeListPage()
        {
            await NavigationService.NavigateAsync("AlternativePhotoListPage");
        }
    }
}
