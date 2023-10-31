using ASP.NETLab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ASP.NETLab3.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(Form input)
        {
            if (ModelState.IsValid)
            {
                if (input.City is not null)
                    input.City = Enum.GetName(typeof(Form.Cities), int.Parse(input.City));
                return View("Result", input);
            }
            else 
                return View();
        }
        public IActionResult Result(Form input)
        {
            return View(input);
        }
    }
}
