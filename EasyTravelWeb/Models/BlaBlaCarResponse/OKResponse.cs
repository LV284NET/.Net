using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTravelWeb.Models.BlaBlaCarResponse
{
    public class OKResponse: BlaBlaCarResponseModel
    {
        public int LowestPrice { get; set; }

        public int HighestPrice { get; set; }

        public int TravelTime { get; set; }

        public int Distance { get; set; }

        public int CountOfSuggestions { get; set; }

        public string Link { get; set; }
    }
}