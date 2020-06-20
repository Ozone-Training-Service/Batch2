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

   

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(string n1,string n2,string n3)
        {

            ViewBag.Name = n1;
            ViewBag.Age = n2;
            ViewBag.Mark = n3;
            return View();
        }


        //
        //public string Index()
        //{
        //    return "Vivek";
        //}

    }
}