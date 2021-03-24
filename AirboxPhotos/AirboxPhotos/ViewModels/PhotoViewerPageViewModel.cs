using AirboxPhotos.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirboxPhotos.ViewModels
{
    public class PhotoViewerPageViewModel : ViewModelBase
    {
        public Photo Photo { get; set; }
        public bool HasNoPhoto { get; set; }

        public PhotoViewerPageViewModel(INavigationService navigationService)
                   : base(navigationService)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.TryGetValue("Photo", out Photo photo))
            {
                Photo = photo;
            }
            else
            {
                HasNoPhoto = true;
            }
        }
    }
}
