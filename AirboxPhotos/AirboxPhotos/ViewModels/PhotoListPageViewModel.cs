using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using AirboxPhotos.Models;
using Xamarin.Essentials;
using AirboxPhotos.Data;
using System.Windows.Input;
using AirboxPhotos.Models.Enums;

namespace AirboxPhotos.ViewModels
{
    public class PhotoListPageViewModel : ViewModelBase
    {
        IPhotoRepository _photoRepostiory { get; set; }
        public ICommand VehicleSelectedCommand { get; set; }
        public List<Photo> Photos { get; set; }
        public Photo Photo1 { get; set; }
        public Photo Photo2 { get; set; }
        public Photo Photo3 { get; set; }
        public Photo Photo4 { get; set; }
        public Photo Photo5 { get; set; }
        public Photo Photo6 { get; set; }
        public Photo Photo7 { get; set; }
        public Photo Photo8 { get; set; }
        public Photo Photo9 { get; set; }

        public PhotoListPageViewModel(INavigationService navigationService, IPhotoRepository photoRepository) 
            : base(navigationService)
        {
            _photoRepostiory = photoRepository;

            LoadData(VehicleType.Car);

            VehicleSelectedCommand = new Command<VehicleType>((vehicleType) => LoadData(vehicleType));
        }

        public override void Initialize(INavigationParameters parameters)
        {
           
        }

        public void LoadData(VehicleType vehicleType)
        {
            Photos = _photoRepostiory.GetPhotosByType(vehicleType).ToList();

            LoadIndividualPhotos();
        }

        private void LoadIndividualPhotos()
        {
            if (Photos != null)
            {
                switch (Photos.Count)
                {
                    case 1:
                        Photo1 = Photos[0];
                        break;
                    case 2:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        break;
                    case 3:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        Photo3 = Photos[2];
                        break;
                    case 4:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        Photo3 = Photos[2];
                        Photo4 = Photos[3];
                        break;
                    case 5:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        Photo3 = Photos[2];
                        Photo4 = Photos[3];
                        Photo5 = Photos[4];
                        break;
                    case 6:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        Photo3 = Photos[2];
                        Photo4 = Photos[3];
                        Photo5 = Photos[4];
                        Photo6 = Photos[5];
                        break;
                    case 7:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        Photo3 = Photos[2];
                        Photo4 = Photos[3];
                        Photo5 = Photos[4];
                        Photo6 = Photos[5];
                        Photo7 = Photos[6];
                        break;
                    case 8:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        Photo3 = Photos[2];
                        Photo4 = Photos[3];
                        Photo5 = Photos[4];
                        Photo6 = Photos[5];
                        Photo7 = Photos[6];
                        Photo8 = Photos[7];
                        break;
                    case 9:
                        Photo1 = Photos[0];
                        Photo2 = Photos[1];
                        Photo3 = Photos[2];
                        Photo4 = Photos[3];
                        Photo5 = Photos[4];
                        Photo6 = Photos[5];
                        Photo7 = Photos[6];
                        Photo8 = Photos[7];
                        Photo9 = Photos[8];
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
