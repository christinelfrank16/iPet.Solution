using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Pets.Models;
using System.Linq;

namespace Pets.Controllers
{
	public class OwnerController : Controller
	{

		[HttpGet("/owners/{id}")]
		public ActionResult Show(int id)
		{
			List<Owner> allOwners = Owner.GetAll();
			Owner owner = allOwners.Where(person => person.Id == id).FirstOrDefault();
			return View(owner);
		}

		[HttpGet("/owners/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("/owners")]
		public ActionResult Create(string name)
		{
			Owner owner = new Owner(name);
			return RedirectToAction("Show", owner);
		}

	}
}