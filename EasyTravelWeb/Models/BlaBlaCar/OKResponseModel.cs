using System.Collections.Generic;

namespace EasyTravelWeb.Models.BlaBlaCar
{
    /// <summary>
    ///     model for parse info from success request 
    /// </summary
    public class OKResponseModel
    {
        public Links links { get; set; }

        public Pager pager { get; set; }

        public IEnumerable<Trip> trips { get; set; }

        public int distance { get; set; }

        public int duration { get; set; }

        public int lowest_price { get; set; }
    }
}