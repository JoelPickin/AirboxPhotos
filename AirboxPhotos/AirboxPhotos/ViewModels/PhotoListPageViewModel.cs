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
        public ObservableCollection<Photo> Photos1 { get; set; }
        public ObservableCollection<Photo> Photos2 { get; set; }
        public int PhotoHeight { get; set; } = 110;
        public int PhotoWidth { get; set; } = 110;

        public PhotoListPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Photos1 = new ObservableCollection<Photo>
            {
                new Photo
                {
                    Source = "boat1.jpg",
                    Height = 160,
                    Width = 160
                },
                new Photo
                {
                    Source = "boat2.jpg",
                    Height = 80,
                    Width = 80
                },
                new Photo
                {
                    Source = "boat5.jpg",
                    Height = 80,
                    Width = 80
                }
                //new Photo
                //{
                //    Source = "car1.jpg",
                //    Height = 100,
                //    Width = 100
                //},
                //new Photo
                //{
                //    Source = "car2.jpg",
                //    Height = 100,
                //    Width = 100
                //},
                //new Photo
                //{
                //    Source = "helicopter1.jpg",
                //    Height = 100,
                //    Width = 100
                //},
                //new Photo
                //{
                //    Source = "helicopter2.jpg",
                //    Height = 100,
                //    Width = 100
                //},
                //new Photo
                //{
                //    Source = "helicopter3.jpg",
                //    Height = 100,
                //    Width = 100
                //}
            };

            Photos2 = new ObservableCollection<Photo>
            {
                new Photo
                {
                    Source = "boat3.jpg",
                    Height = 80,
                    Width = 80
                },
                new Photo
                {
                    Source = "boat4.jpg",
                    Height = 80,
                    Width = 80
                },
                new Photo
                {
                    Source = "boat5.jpg",
                    Height = 80,
                    Width = 80
                }
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
