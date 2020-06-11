using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add(Employee employee)
        {
            //db code


            ViewBag.Name = employee.FirstName;
            ViewBag.LastName = employee.LastName;
           
            return View(employee);
        
        
        }

        



    }
}