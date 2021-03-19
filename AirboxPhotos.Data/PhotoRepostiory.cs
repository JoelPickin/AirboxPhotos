using AirboxPhotos.Models;
using AirboxPhotos.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirboxPhotos.Data
{
    public class PhotoRepostiory : IPhotoRepository
    {
        readonly List<Photo> photos;
        public PhotoRepostiory()
        {
            photos = new List<Photo>()
            {
                new Photo { Id = 1, VehicleType = VehicleType.Car, Source = "car1.jpg" },
                new Photo { Id = 2, VehicleType = VehicleType.Car, Source = "car2.jpg" },

                new Photo { Id = 3, VehicleType = VehicleType.Boat, Source = "boat1.jpg" },
                new Photo { Id = 4, VehicleType = VehicleType.Boat, Source = "boat2.jpg" },
                new Photo { Id = 5, VehicleType = VehicleType.Boat, Source = "boat3.jpg" },
                new Photo { Id = 6, VehicleType = VehicleType.Boat, Source = "boat4.jpg" },
                new Photo { Id = 7, VehicleType = VehicleType.Boat, Source = "boat5.jpg" },

                new Photo { Id = 8, VehicleType = VehicleType.Helicopter, Source = "helicopter1.jpg" },
                new Photo { Id = 9, VehicleType = VehicleType.Helicopter, Source = "helicopter2.jpg" },
                new Photo { Id = 10, VehicleType = VehicleType.Helicopter, Source = "helicopter3.jpg" }
            };
        }

        public IEnumerable<Photo> GetAllPhotos()
        {
            return photos;
        }

        public IEnumerable<Photo> GetPhotosByType(VehicleType type)
        {
            return photos.Where(photo => photo.VehicleType == type); 
        }
    }
}
