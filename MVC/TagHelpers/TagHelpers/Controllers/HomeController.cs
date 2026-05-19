using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelpers.Models;

namespace TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy(int id, string userName )
        {
            ViewBag.id = id;
            ViewBag.username = userName;
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(Student student)
        {
            return View(student);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
