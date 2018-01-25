﻿    using System.Drawing;

namespace EasyTravelWeb.Models
{
    /// <summary>
    ///    Place Model
    /// </summary>

    public class Place
    {
        /// <summary>
        ///    
        /// </summary>
        public long PlaceId { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string PicturePlace { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public Place()
        {
            
        }

        /// <summary>
        ///    
        /// </summary>
        public Place(string name, string cityName, string description, string picturePlace)
        {
            this.Name = name;
            this.CityName = cityName;
            this.Description = description;
            this.PicturePlace = picturePlace;
        }
    }
}