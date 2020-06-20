using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web_Vivek.Controllers
{
    public class StudentController : Controller
    {


        public IActionResult Index()
        {
            ViewBag.Name = "Vishu Kumar ps";
            ViewBag.mob = "909090";


            ViewData["M1"] = 88;

            return View();
        }



        public IActionResult List()
        {
            return View();
        }


        //public string Index()
        //{
        //    return "Vivek";
        //}

    }
}