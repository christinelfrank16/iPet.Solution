using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Pets.Models;

namespace Pets.Controllers
{
	public class iPetController : Controller
	{

		[HttpGet("/{petType}")]
		public ActionResult Index(string petType)
		{
			return View(petType);
		}

		[HttpGet("/pet/new")]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost("/pet")]
		public ActionResult Show(string name, string type, string c1, string c2, string c3, string c4, string blurb, string image)
		{
			List<string> characteristicList = new List<string>{c1, c2, c3, c4};
			switch (type)
			{
				case "dog": 
				Dog newDog = new Dog(name, characteristicList, blurb, image);
					return View(newDog);

				case "cat":
				Cat newCat = new Cat(name, characteristicList, blurb, image);
					return View(newCat);
				default:
					// insert an error message
					return View("Error");
			}
			
		}

		[HttpGet("/pet/error")]
		public ActionResult Error()
		{
			return View();
		}

	}
}