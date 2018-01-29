using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTravelWeb.Models
{
    public class UserPlaceRating
    {
        /// <summary>
        ///    
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public long PlaceId { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public double Rating { get; set; }
    }
}