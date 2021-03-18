using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AirboxPhotos.Models
{
    public class Photo
    {
        public ImageSource Source { get; set; }
        public string PhotoName { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
