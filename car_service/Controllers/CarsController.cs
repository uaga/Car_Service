using car_service.BL.Interfaces;
using car_service.DAL.Model;
using car_service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace car_service.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarBL carBL;
        public CarsController(ICarBL carBL)
        {
            this.carBL = carBL;
        }
        // GET: CarsController
        public ActionResult Index()
        {
            return View(new CarsViewModel { Cars = carBL.GetAll()});
        }

        // GET: CarsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarsController/Create
        [HttpPost]
        public ActionResult Create(AddCarViewModel model)
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
                    return RedirectToAction(nameof(Index));
                }
            }
            return View();
        }

        // GET: CarsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
