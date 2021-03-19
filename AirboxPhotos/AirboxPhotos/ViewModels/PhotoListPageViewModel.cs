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

namespace AirboxPhotos.ViewModels
{
    public class PhotoListPageViewModel : ViewModelBase
    {
        //Load Requested Photos
        //Loop through and add to single photo object
        IPhotoRepository _photoRepostiory { get; set; }
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

            LoadData();
        }

        public void LoadData()
        {
            Photos = _photoRepostiory.GetAllPhotos().ToList();

            Photo1 = new Photo
            {
                Source = "boat5.jpg"
            };

            Photo2 = new Photo
            {
                Source = "boat2.jpg"
            };

            Photo3 = new Photo
            {
                Source = "boat1.jpg"
            };

            Photo4 = new Photo
            {
                Source = "boat3.jpg"
            };

            Photo5 = new Photo
            {
                Source = "boat3.jpg"
            };

            Photo6 = new Photo
            {
                Source = "boat1.jpg"
            };

            Photo7 = new Photo
            {
                Source = "boat2.jpg"
            };
            Photo8 = new Photo
            {
                Source = "boat3.jpg"
            };

            Photo9 = new Photo
            {
                Source = "boat1.jpg"
            };
        }

        public override void Initialize(INavigationParameters parameters)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}
