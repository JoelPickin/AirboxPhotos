using AirboxPhotos.Models;
using AirboxPhotos.ViewModels;
using AirboxPhotos.Views.Templates;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AirboxPhotos.Views
{
    public partial class PhotoListPage : ContentPage
    {      
        public PhotoListPage()
        {
            InitializeComponent();
        }

        private void VehicleBtn_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Id.ToString() == "CarsBtn")
            {
                CarsBtn.Style = (Style)Application.Current.Resources["buttonSelectedStyle"];
                BoatsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                HelicopterBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
            }
            else if (button.Id.ToString() == "BoatsBtn")
            {
                CarsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                BoatsBtn.Style = (Style)Application.Current.Resources["buttonSelectedStyle"];
                HelicopterBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
            }
            else if (button.Id.ToString() == "HelicoptersBtn")
            {
                CarsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                BoatsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                HelicopterBtn.Style = (Style)Application.Current.Resources["buttonSelectedStyle"];
            }
        }
    }
}
