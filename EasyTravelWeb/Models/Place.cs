    using System.Drawing;

namespace EasyTravelWeb.Models
{
    public class Place
    {
        public int PlaceId { get; set; }

        public string Name { get; set; }

        public string CityName { get; set; }

        public string Description { get; set; }

//        public Image PicturePlace { get; set; }

        public Place()
        {
            
        }

        public Place(string name, string cityName, string description, Image picturePlace)
        {
            this.Name = name;
            this.CityName = cityName;
            this.Description = description;
//            this.PicturePlace = picturePlace;
        }
    }
}