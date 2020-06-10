using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class CalculationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ans(string n1, string n2)
        {

            int a = Convert.ToInt32(n1);
            int b= Convert.ToInt32(n1);

            int Sum = a + b;
            int dif = a - b;
            int q = a / b;
            int p = a * b;

            ViewBag.Sum = Sum;
            ViewBag.dif = dif;
            ViewBag.q = q;
            ViewBag.p = p;
            return View();
        }
    }
}