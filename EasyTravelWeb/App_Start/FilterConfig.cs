using System.Web.Mvc;

namespace EasyTravelWeb
{
    /// <summary>
    ///     Filter config
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        ///    Register Global Filters
        /// </summary>

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
