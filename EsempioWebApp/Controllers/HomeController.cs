using EsempioWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EsempioWebApp.Controllers
{
    public class HomeController : Controller        //gestisce /Home/*
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()        //gestisce la richiesta /Home/Index  oppure /Home
        {
            return View();
        }

        public IActionResult Privacy()      //gestisce la richiesta /Home/Privacy
        {
            return View();
        }


        public IActionResult Contatti()      //gestisce la richiesta /Home/Contatti
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