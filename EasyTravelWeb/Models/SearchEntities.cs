namespace EasyTravelWeb.Models
{
    /// <summary>
    ///    
    /// </summary>
    public interface ISearchEntity
    {
        /// <summary>
        ///    
        /// </summary>
        long Id { get; set; }

        /// <summary>
        ///    
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///    
        /// </summary>
        string Type { get; }
    }

    /// <summary>
    ///    
    /// </summary>
    public class CitySearchEntity : ISearchEntity
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
        public string Type { get; } = "City";
    }

    /// <summary>
    ///    
    /// </summary>
    public class PlaceSearchEntity : ISearchEntity
    {
        /// <summary>
        ///    
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public long CityId { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///    
        /// </summary>
        public string Type { get; } = "Place";
    }
}