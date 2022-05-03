using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectsRepository projectsRepository;
        private readonly IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IProjectsRepository projectsRepository, IConfiguration configuration)
        {
            // ver otra vez lo relacionado con la inyeccion de dependencias...
            _logger = logger;
            this.projectsRepository = projectsRepository;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var projects = projectsRepository.GetProjets().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Projects = projects };
            return View(modelo);

            // ViewBag NO es fuertemente tipado por lo que se tiene que tener cuidado con posibles errores o confusiones.
            // ViewBag.Name = "Cristian Isac Vargas"; || ViewBag.Age = 21;
            // return View("AnyView");
            //var Person = new Person()
            //{
            //    Name = "Roberto Pastoriza",
            //    Age = 30
            //};
            //return View("Index", Person);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Projects()
        {
            var projects = projectsRepository.GetProjets();

            return View(projects);
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactViewModel)
        {
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
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