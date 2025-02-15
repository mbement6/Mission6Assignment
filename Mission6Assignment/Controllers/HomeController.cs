using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6Assignment.Models;

namespace Mission6Assignment.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieApplication(Application response)
        {
            return View("Confirmation");
        }

    }
}
