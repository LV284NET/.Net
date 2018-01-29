using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTravelWeb.Models
{

    /// <summary>
    ///    
    /// </summary>
    public class City
    {
        /// <summary>
        ///    
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string PicturePath { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public double CityRating { get; set; }
    }
}