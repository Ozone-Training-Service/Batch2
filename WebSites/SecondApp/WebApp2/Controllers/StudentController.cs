using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

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

        public IActionResult StudentDetails()//Action Method
        {

         
            Student s1 = new Student();
            s1.Name = "Vishnu";
            s1.RollNo = 30;
            s1.M1 = 20;
            s1.M2 = 88;


            return View( s1);
        }

    }
}