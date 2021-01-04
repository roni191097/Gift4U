using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gift4U.Models;

namespace Gift4U.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult contactsent()
        {
            return View();
        }

        public IActionResult Regulations()
        {
            return View();
        }
        public IActionResult loginRegister()
        {
            return View();
        }
        
        public IActionResult HowItWork()
        {
            return View();
        }
        public IActionResult lookingforgift()
        {
            return View();
        }
        public IActionResult cybersecurity()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
