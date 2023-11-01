using CarRentalPlatform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalPlatform.Controllers
{
    public class CarController : Controller
    {
        private static List<Car> items = new()
        {
            new Car { Id = 1, Location = "Kraków", Manufacturer = "FIAT", Model = "Bravo"},
            new Car { Id = 2, Location = "Kraków", Manufacturer = "Lancia", Model = "Kappa"},
            new Car { Id = 3, Location = "Wrocław", Manufacturer = "Lancia", Model = "Delta"},
            new Car { Id = 4, Location = "Modlin", Manufacturer = "Alfa Romeo", Model = "Brera"},
            new Car { Id = 5, Location = "Kraków", Manufacturer = "FIAT", Model = "Bravo"}
        };

        private static int IdCounter = 5;

        // GET: CarController
        public ActionResult Index()
        {
            return View(items);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            return View(items.Single(x => x.Id == id));
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car newItem)
        {
            try
            {
                newItem.Id = ++IdCounter;
                items.Add(newItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(items.Single(x => x.Id == id));
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car editedItem)
        {
            try
            {
                Car itemToBeChanged = items.Single(x => x.Id == id);

                itemToBeChanged.Location = editedItem.Location;
                itemToBeChanged.Manufacturer = editedItem.Manufacturer;
                itemToBeChanged.Model = editedItem.Model;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(items.Single(x => x.Id == id));
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Car deletedItem)
        {
            try
            {
                Car itemToBeDeleted = items.Single(x => x.Id == id);
                items.Remove(itemToBeDeleted);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
