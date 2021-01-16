using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Gift4U.Models;
using Gift4U.Data;

namespace Gift4U.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Gift4UContext _context;
        public HomeController(ILogger<HomeController> logger, Gift4UContext context)
        {
            _logger = logger;
            _context = context;
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
        public async Task<IActionResult> lookingforgift(String Name)
        {

            SearchResult searchResult = new SearchResult();

            if (!String.IsNullOrEmpty(Name))
            {
                searchResult.Categories =(from c in _context.Category
                                          where c.Name.Contains(Name)
                                          select c).ToList();
                searchResult.Stores = (from s in _context.Stores
                                       where s.Name.Contains(Name)
                                       select s).ToList();
                return View("~/Views/Home/SearchResult.cshtml", searchResult);
            }
            else
                return View();
        }
    }
}
