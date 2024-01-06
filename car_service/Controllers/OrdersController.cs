using car_service.BL.Implementations;
using car_service.BL.Interfaces;
using car_service.DAL.Implementations;
using car_service.DAL.Interfaces;
using car_service.DAL.Model;
using car_service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace car_service.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderBL orderBL;
        public OrdersController(IOrderBL orderBL)
        {
            this.orderBL = orderBL;
        }
        // GET: OrdersController
        public ActionResult Index()
        {
            return View(new OrdersViewModel { Orders = orderBL.GetAll()});
        }

        // GET: OrdersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrdersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrdersController/Create
        [HttpPost]
        public ActionResult Create(AddOrderViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (orderBL.AddNew(model.Customer, model.Car, model.Services))
                {
                    return RedirectToAction("Index");
                }
                
            }
            return View();
        }

        // GET: OrdersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrdersController/Edit/5
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

        // GET: OrdersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrdersController/Delete/5
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
