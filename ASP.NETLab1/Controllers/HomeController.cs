using ASP.NETLab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NETLab1.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Imie = "Krzyś";
            ViewBag.Godzina = DateTime.Now.Hour;
            ViewBag.Powitanie = ViewBag.Godzina < 16 ? "Dzień dobry" : "Dobry wieczór";

            Dane[] osoby =
            {
                new Dane{Name = "Jan", Surname = "Kołacz" },
                new Dane{Name = "Maciej", Surname = "Połen" },
                new Dane{Name = "Krzyś", Surname = "Kuryne" }

            };

            return View(osoby);
        }

        public IActionResult Urodziny(Urodziny urodziny) 
        {
            ViewBag.powitanie = $"Witaj {urodziny.Imie}, Masz {DateTime.Now.Year - urodziny.Rok} lat!";
            return View();
        }

        public IActionResult Calculator(Calculator calc)
        {
            ViewBag.wynik = "Wpisz dane";

            switch (calc.znak)
            {
                case "+":
                    ViewBag.wynik = $" Wynik to: {calc.liczba1 + calc.liczba2}";
                    break;
                case "-":
                    ViewBag.wynik = $" Wynik to: {calc.liczba1 - calc.liczba2}";
                    break;
                case "*":
                    ViewBag.wynik = $" Wynik to: {calc.liczba1 * calc.liczba2}";
                    break;
                case "/":
                    ViewBag.wynik = $" Wynik to: {calc.liczba1 / calc.liczba2}";
                    break;
                default:
                    ViewBag.wynik = $" Nieprawidłowy znak!";
                    break;
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}