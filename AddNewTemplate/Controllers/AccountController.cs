using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddNewTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddNewTemplate.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Register(Register newRegistration)
		{
			return View(newRegistration);
		}
	}
}
