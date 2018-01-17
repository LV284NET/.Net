using System.Collections.Generic;

namespace EasyTravelWeb.Infrastructure
{
	internal interface IValidator<T>
	{
		List<string> GetValidationData(T obj);

		bool IsValid(T obj);
	}
}