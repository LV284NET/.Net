using System.Web.Mvc;

namespace EasyTravelWeb.Controllers
{
	/// <summary>
	///     Controller for the default page which informs about the app running
	/// </summary>
	public class MainPageController : Controller
	{
		// GET: MainPage
		public ActionResult Index()
		{
			return this.View();
		}
	}
}