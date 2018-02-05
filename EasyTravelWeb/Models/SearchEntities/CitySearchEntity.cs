namespace EasyTravelWeb.Models.SearchEntities
{
	/// <summary>
	///		Provides info about a city for searching.
	/// </summary>
	public class CitySearchEntity : ISearchEntity
	{
		/// <summary>
		///    ID of a city.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		///    ID of a city.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		Type is necessary for distinguishing SearchItems on Front-End.
		/// </summary>
		public string Type { get; } = "City";
	}
}