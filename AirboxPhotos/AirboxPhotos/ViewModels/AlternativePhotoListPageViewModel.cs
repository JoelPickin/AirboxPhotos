using AirboxPhotos.Data;
using AirboxPhotos.Extensions;
using AirboxPhotos.Models;
using AirboxPhotos.Models.Enums;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AirboxPhotos.ViewModels
{
    public class AlternativePhotoListPageViewModel : ViewModelBase
    {
        IPhotoRepository _photoRepostiory { get; set; }
        public ICommand VehicleSelectedCommand { get; set; }
        public ICommand NavigateToImageViewer { get; set; }
        public ObservableCollection<Photo> Photos { get; set; }

        public AlternativePhotoListPageViewModel(INavigationService navigationService, IPhotoRepository photoRepository)
            : base(navigationService)
        {
            _photoRepostiory = photoRepository;

            VehicleSelectedCommand = new Command<VehicleType>((vehicleType) => LoadData(vehicleType));
            NavigateToImageViewer = new Command<Photo>(async (photo) => await NavigateToImage(photo));
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (IsNewNavigation(parameters))
            {
                LoadData(VehicleType.Car);
            }
        }

        public void LoadData(VehicleType vehicleType)
        {
            Photos = new ObservableCollection<Photo>();

            Photos = _photoRepostiory.GetPhotosByType(vehicleType).ToObservableCollection();
        }

        private async Task NavigateToImage(Photo photo)
        {
            if (photo != null)
            {
                var navParams = new NavigationParameters();
                navParams.Add("Photo", photo);

                await NavigationService.NavigateAsync("PhotoViewerPage", navParams);
            }
        }
    }
}
