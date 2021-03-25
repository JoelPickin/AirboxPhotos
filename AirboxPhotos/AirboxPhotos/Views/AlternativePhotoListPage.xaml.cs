using System;
using Xamarin.Forms;

namespace AirboxPhotos.Views
{
    public partial class AlternativePhotoListPage : ContentPage
    {
        public AlternativePhotoListPage()
        {
            InitializeComponent();
        }

        private void VehicleBtn_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.ClassId == "Cars")
            {
                CarsBtn.Style = (Style)Application.Current.Resources["buttonSelectedStyle"];
                BoatsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                HelicopterBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
            }
            else if (button.ClassId == "Boats")
            {
                CarsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                BoatsBtn.Style = (Style)Application.Current.Resources["buttonSelectedStyle"];
                HelicopterBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
            }
            else if (button.ClassId == "Helicopters")
            {
                CarsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                BoatsBtn.Style = (Style)Application.Current.Resources["buttonStyle"];
                HelicopterBtn.Style = (Style)Application.Current.Resources["buttonSelectedStyle"];
            }
        }
    }
}
