using car_service.BL.Interfaces;
using car_service.DAL.Model;
using car_service.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace car_service.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarBL carBL;

        public HomeController(ILogger<HomeController> logger, ICarBL carBL)
        {
            _logger = logger;
            this.carBL = carBL;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AddCarViewModel model)
        {
            if (ModelState.IsValid)
            {
                Car car = new Car();
                car.Brand = model.Brand;
                car.Models = model.Models;
                car.Gen = model.Gen;
                car.RegNumber = model.RegNumber;
                car.TechPassport = model.TechPassport;
                car.ReleaseDate = model.ReleaseDate;
                car.Color = model.Color;
                car.EngineNumber = model.EngineNumber;
                car.BodyNumber = model.BodyNumber;
                if (carBL.AddNew(car))
                {

                }
            }
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
