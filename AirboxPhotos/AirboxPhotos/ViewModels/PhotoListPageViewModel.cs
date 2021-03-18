using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using AirboxPhotos.Models;

namespace AirboxPhotos.ViewModels
{
    public class PhotoListPageViewModel : ViewModelBase
    {
        public ObservableCollection<Photo> Photos { get; set; }

        public PhotoListPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {

        }

        public override void Initialize(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}
