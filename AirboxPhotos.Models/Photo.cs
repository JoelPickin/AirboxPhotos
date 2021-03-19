using AirboxPhotos.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirboxPhotos.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public ImageSource Source { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
