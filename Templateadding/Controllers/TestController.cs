using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TemplateAdding.Models;
using System.Net.Mail;
using TemplateAdding.Utills;

namespace Templateadding.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Register newRegistration)
        {
            Random r= new Random();
            int otp = r.Next(10000, 99999);
            string otpnumber = otp.ToString();
            EmailSending obj = new EmailSending();
            obj.mail(newRegistration.Email, otpnumber, "your otp number");

            return View(newRegistration);
        }
    }
}
