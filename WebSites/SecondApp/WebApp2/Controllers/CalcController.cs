using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Vishnu";
            return View();
        }


        public IActionResult Ans(string n1, string n2)
        {

            Employee emp = new Employee();
            emp.FirstName = n1;




            int a = Convert.ToInt32(n1);
            int b = Convert.ToInt32(n2);
            int c = a + b;

            ViewBag.Ans = c;
            return View();
        }
    }
}