using System.Collections.Generic;

namespace EasyTravelWeb.Infrastructure
{
    interface IValidator<T>
    {
        List<string> Validate(T obj);
    }
}
