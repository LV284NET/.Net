namespace EasyTravelWeb.Models.SearchEntities
{
	/// <summary>
	///		Provides members for SearchEntities types.
	/// </summary>
	public interface ISearchEntity
	{
		/// <summary>
		///    ID of SearchEntity.
		/// </summary>
		long Id { get; set; }

		/// <summary>
		///    Name of SearchEntity.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		///    Type of SearchEntity.
		/// </summary>
		string Type { get; }
	}
}
