using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RentNowApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace RentNowApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
