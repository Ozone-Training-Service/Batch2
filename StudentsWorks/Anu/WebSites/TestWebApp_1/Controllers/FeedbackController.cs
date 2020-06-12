using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApp_1.Models;

namespace TestWebApp_1.Controllers
{
	public class FeedbackController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Feed(Feedback feedback)
		{
			ViewBag.Name = feedback.Name;
			ViewBag.Message = feedback.Message;
			ViewBag.Date = feedback.Date;
			return View();


		}
	}
}
