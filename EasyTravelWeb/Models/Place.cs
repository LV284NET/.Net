﻿    using System.Drawing;

namespace EasyTravelWeb.Models
{
    public class Place
    {
        public long PlaceId { get; set; }

        public string Name { get; set; }

        public string CityName { get; set; }

        public string Description { get; set; }

        public string PicturePlace { get; set; }

        public Place()
        {
            
        }

        public Place(string name, string cityName, string description, string picturePlace)
        {
            this.Name = name;
            this.CityName = cityName;
            this.Description = description;
            this.PicturePlace = picturePlace;
        }
    }
}