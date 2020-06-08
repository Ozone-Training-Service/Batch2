using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Ans(string n1, string n2)
        {

            int a = Convert.ToInt32(n1);
            int b = Convert.ToInt32(n2);
            int c = a + b;

            ViewBag.Ans = c;
            return View();
        }
    }
}