using BasicApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace BasicApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewData["name"] = "Pateliya Ashish Vasharambhai";
            ViewData["age"] = 21;
            ViewData["friends"] = new List<string>()
            {
                "Mayur","Mihir","Dhruvil","Nitya","Jaydeep"
            };

            string[] sports = { "cricket", "chess", "badminton" };
            ViewData["sports"] = sports;

           

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Demo()
        {
            ViewBag.fullName = "Pateliya Ashish Vasharambhai";
            ViewBag.friends = new List<string>()
            {
                "Mayur","Mihir","Dhruvil","Nitya","Jaydeep"
            };
            return View();
        }

        public ViewResult Hi()
        {
            return View();
        }
    }
}
