using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LotusTransformation.Models;

namespace LotusTransformation.Controllers
{
    public class LotusGeneralController: Controller
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
        public IActionResult Inspiration()
        {
            return View();
        }

    }


}
