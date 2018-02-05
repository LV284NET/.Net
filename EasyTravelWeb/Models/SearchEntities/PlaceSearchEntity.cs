namespace EasyTravelWeb.Models.SearchEntities
{
	/// <summary>
	///    Provides info about a place for searching.
	/// </summary>
	public class PlaceSearchEntity : ISearchEntity
	{
		/// <summary>
		///    ID of a place.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		///    ID of a city.
		/// </summary>
		public long CityId { get; set; }

		/// <summary>
		///    ID of a place.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///    Type is necessary for distinguishing SearchItems on Front-End.
		/// </summary>
		public string Type { get; } = "Place";
	}
}