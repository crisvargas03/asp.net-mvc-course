using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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

            //Uisng the view bag: 
            ViewBag.name = "Cristian Isaac Vargas";

            return View();
            //In case that i want to redirect to a specific view: 
            // return View("OtherView");

            /*
            Experimento: 
            
            public class Person{
                public int age { get; set; } = 10;
                public string name { get; set; } = "Isaias";
            }
            Person obj = new Person();
            ViewBag.persona = obj;
            */
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