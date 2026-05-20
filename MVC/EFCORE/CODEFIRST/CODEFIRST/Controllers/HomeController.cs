using CODEFIRST.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CODEFIRST.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _DbContext;
        public HomeController(AppDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public IActionResult Index()
        {
            var studentsData = _DbContext.Students.ToList();
            return View(studentsData);
        }

        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                _DbContext.Students.Add(student);
                _DbContext.SaveChanges();
                return RedirectToAction("Index","Home");
            }
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
    }
}
