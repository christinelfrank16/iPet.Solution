using Microsoft.AspNetCore.Mvc;

namespace Pets.Controllers
{
	public class iPetController : Controller
	{

		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}

	}
}