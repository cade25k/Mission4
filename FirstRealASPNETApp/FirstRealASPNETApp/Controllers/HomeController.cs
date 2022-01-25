using FirstRealASPNETApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRealASPNETApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext mc)
        {
            _logger = logger;
            context = mc;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(Movie m)
        {
            context.Add(m);
            context.SaveChanges();

            return View("Confirmation", m);
        }
        public IActionResult Podcasts()
        {
            return View();
        }
        public IActionResult Privacy()
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
