using ASP.NETLab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETLab2.Controllers
{
    public class FilmController : Controller
    {
        private static int idCounter = 5;

        private static IList<Movie> movies = new List<Movie>
        {
            new Movie() {Id = 1, Name = "Straszny Film", Description = "Komedia", Grade = 4},
            new Movie() {Id = 2, Name = "Śmieszny Film", Description = "Dramat", Grade = 2},
            new Movie() {Id = 3, Name = "Smutny Film", Description = "Dramat", Grade = 2},
            new Movie() {Id = 4, Name = "Nudny Film", Description = "Romans", Grade = 4},
            new Movie() {Id = 5, Name = "Głośny Film", Description = "Akcja", Grade = 1}
        };

        // GET: FilmController
        public ActionResult Index()
        {
            return View(movies);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            var movie = movies.Single(x => x.Id == id);
            return View(movie);
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie newMovie)
        {
            newMovie.Id = ++idCounter;
            movies.Add(newMovie);
            return RedirectToAction("Index"); //Przejdź do akcji a nie z powrtotem do widoku
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            var movie = movies.Single(x => x.Id == id);
            return View(movie);
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Movie editedMovie)
        {
            Movie editedItem = movies.Single(x => x.Id == editedMovie.Id);

            editedItem.Id = editedMovie.Id;
            editedItem.Name = editedMovie.Name;
            editedItem.Description = editedMovie.Description;
            editedItem.Grade = editedMovie.Grade;

            return RedirectToAction("Index");
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(int id)
        {
            ////Displays view with details and button to perfom delete operation:
            //var movie = movies.Single(x => x.Id == id);
            //return View(movie);

            //Deletes item directly and return to Index page:
            var movieToDelete = movies.Single(x => x.Id == id);
            movies.Remove(movieToDelete);
            return RedirectToAction("Index");
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Movie deletedMovie)
        {
            var movieToDelete = movies.Single(x => x.Id == deletedMovie.Id);
            movies.Remove(movieToDelete);
            return RedirectToAction("Index");
        }
    }
}
