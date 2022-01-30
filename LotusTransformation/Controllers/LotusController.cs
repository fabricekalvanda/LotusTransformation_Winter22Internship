using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotusTransformation.Controllers
{
    public class LotusController: Controller
    {
        [HttpGet]   
        public IActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Services()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Meditations()
        {
            return View();
        }
        [HttpGet]
        public IActionResult BookAnAppointment()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp_UserInformation()
        {
            return View();
        }
    }


}
