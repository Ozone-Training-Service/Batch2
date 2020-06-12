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


			return View(feedback);


		}
		public IActionResult FeedbackDetails()
		{
			Feedback obj1 = new Feedback();
			obj1.Name = "Vishnu";
			obj1.Message = "ffyifyo";
			obj1.Date = "1/2/2020";

			Feedback obj2 = new Feedback();
			obj2.Name = "Anu";
			obj2.Message = "ffyifyo";
			obj2.Date = "5/3/2020";

			Feedback obj3 = new Feedback();
			obj3.Name = "Liya";
			obj3.Message = "ffyifyo";
			obj3.Date = "5/5/2020";

			Feedback obj4 = new Feedback();
			obj4.Name = "Amru";
			obj4.Message = "ffyifyo";
			obj4.Date = "1/5/2020";

			Feedback obj5 = new Feedback();
			obj5.Name = "Vishnu";
			obj5.Message = "dhahfafhlk";
			obj5.Date = "1/2/2020";



			List<Feedback> feedbackList = new List<Feedback>();
			
			feedbackList.Add(obj1);
			feedbackList.Add(obj2);
			feedbackList.Add(obj3);
			feedbackList.Add(obj4);
			feedbackList.Add(obj5);

			return View(feedbackList);

		}
	}
}
