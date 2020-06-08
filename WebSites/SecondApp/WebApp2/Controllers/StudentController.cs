using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{

    //localhost:22002/Student/StudentList
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Name1 = "Anu";
            ViewBag.Name2 = "Liya";

            ViewData["Name"] = "Vishnu";
            ViewData["age"] = "090";

            return View();
        }


        public IActionResult StudentList()//Action Method
        {


            return View();
        }

    }
}