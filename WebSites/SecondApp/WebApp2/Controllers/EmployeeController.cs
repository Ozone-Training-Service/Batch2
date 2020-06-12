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


        public IActionResult List()
        {




            return View();
        }

        public IActionResult EmployeeDetails()
        {
            Employee emp1 = new Employee();
            emp1.FirstName = "Vishnu";
            emp1.LastName = "Kumar";
            emp1.Address = "Kollam";
            emp1.Salary = 1000;

            Employee emp2 = new Employee();
            emp2.FirstName = "Anu";
            emp2.LastName = "Kumar";
            emp2.Address = "tvm";
            emp2.Salary = 1000;

            Employee emp3 = new Employee();
            emp3.FirstName = "liya";
            emp3.LastName = "sss";
            emp3.Address = "tvm";
            emp3.Salary = 1000;

            Employee emp4 = new Employee();
            emp4.FirstName = "Vishnu";
            emp4.LastName = "Kumar";
            emp4.Address = "Kollam";
            emp4.Salary = 1000;

            Employee emp5 = new Employee();
            emp5.FirstName = "Anu";
            emp5.LastName = "Kumar";
            emp5.Address = "tvm";
            emp5.Salary = 1000;

            Employee emp6 = new Employee();
            emp6.FirstName = "liya";
            emp6.LastName = "sss";
            emp6.Address = "tvm";
            emp6.Salary = 1000;



            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);
            employeeList.Add(emp6);



            return View(employeeList);
        }







    }
}