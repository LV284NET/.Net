using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTravelWeb.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public string Description { get; set; }
    }
}