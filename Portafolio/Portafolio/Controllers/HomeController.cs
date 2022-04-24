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
            // ViewBag NO es fuertemente tipado por lo que se tiene que tener cuidado con posibles errores o confusiones.
            // ViewBag.Name = "Cristian Isac Vargas"; || ViewBag.Age = 21;

            // return View("AnyView");

            //var Person = new Person()
            //{
            //    Name = "Roberto Pastoriza",
            //    Age = 30
            //};
            //return View("Index", Person);
            var projects = GetProjets().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Projects = projects };
            return View(modelo);
        }

        private List<ProjectViewModel> GetProjets()
        {
            return new List<ProjectViewModel>() { new ProjectViewModel {
                Title = "Amazon",
                Description = "E-commerce builded with ASP.NET Core",
                Link = "http://amazon.com",
                ImageURL = "/img/amazon.png"
            },
            new ProjectViewModel {
                Title = "New York Times",
                Description = "Digital News Paper with React",
                Link = "http://nytimes.com",
                ImageURL = "/img/nyt.png"
            },
            new ProjectViewModel {
                Title = "Reddit",
                Description = "Social media for comunities shares",
                Link = "http://reddit.com",
                ImageURL = "/img/reddit.png"
            },
            new ProjectViewModel {
                Title = "Steam",
                Description = "Video games Stores",
                Link = "http://store.streampowered.com",
                ImageURL = "/img/steam.png"
            },
            };
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