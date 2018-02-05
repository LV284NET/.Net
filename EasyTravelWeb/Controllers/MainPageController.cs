using System.Web.Mvc;

namespace EasyTravelWeb.Controllers
{
	/// <summary>
	///     Controller for the default page which informs about the app running
	/// </summary>
	public class MainPageController : Controller
	{
		/// <summary>
		///		Returns a ViewResult object that rensers a view to the MainPage
		/// </summary>
		/// <returns>A ViewResult object that rensers a view to the MainPage</returns>
		public ActionResult Index()
		{
			return this.View();
		}
	}
}