using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LotusTransformation.Models;

namespace LotusTransformation.Controllers
{
    public class CreateAccountController : Controller
    {
        [HttpGet][RequireHttps]
        public ActionResult AccountCreation()
        {
            return View();
        }

        [HttpPost][RequireHttps]
        public IActionResult AccountCreation(UserInformation user)
        {
            if (ModelState.IsValid)
            {
                return View("CreationSuccess");
            }
            else return View();
        }


    }
}
