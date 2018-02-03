using System.Collections.Generic;

namespace EasyTravelWeb.Infrastructure.Validators
{
	/// <summary>
	///		Defines methods for data validation
	/// </summary>
	/// <typeparam name="T">Type that contains data that must be validated</typeparam>
	internal interface IValidator<T> 
	{
		/// <summary>
		///		Returns an information about a validation process
		/// </summary>
		/// <param name="obj">Type that contains data that must be validated</param>
		/// <returns>Information about validation process</returns>
		List<string> GetValidationData(T obj);

		/// <summary>
		///		Checks if a data is valid
		/// </summary>
		/// <param name="obj">Type that contains data that must be validated</param>
		/// <returns>True when a data is valid. Otherwise - false.</returns>
		bool IsValid(T obj);
	}
}