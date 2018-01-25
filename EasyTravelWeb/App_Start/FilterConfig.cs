using System.Web;
using System.Web.Mvc;

namespace EasyTravelWeb
{
    /// <summary>
    ///     Filter config
    /// </summary>

    public class FilterConfig
    {
        /// <summary>
        ///    
        /// </summary>

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
