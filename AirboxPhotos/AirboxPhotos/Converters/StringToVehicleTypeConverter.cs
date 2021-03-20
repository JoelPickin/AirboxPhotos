using AirboxPhotos.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace AirboxPhotos.Converters
{
    public class StringToVehicleTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "Boats":
                    return VehicleType.Boat;
                case "Helicopters":
                    return VehicleType.Helicopter;
                default:
                    return VehicleType.Car;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
