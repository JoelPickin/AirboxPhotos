using AirboxPhotos.Models;
using AirboxPhotos.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirboxPhotos.Data
{
    public interface IPhotoRepository
    {
        IEnumerable<Photo> GetAllPhotos();
        IEnumerable<Photo> GetPhotosByType(VehicleType type);
    }
}
