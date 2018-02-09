using System.Collections.Generic;

namespace EasyTravelWeb.Models.BlaBlaCar
{
    public class ResponseModel
    {
        public Links links { get; set; }

        public Pager pager { get; set; }

        public IEnumerable<Trip> trips { get; set; }

        public int distance { get; set; }

        public int duration { get; set; }

        public int lowest_price { get; set; }
    }
}