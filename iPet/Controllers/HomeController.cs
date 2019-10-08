using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
	public class HomeController : Controller
	{

		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}

	}
}