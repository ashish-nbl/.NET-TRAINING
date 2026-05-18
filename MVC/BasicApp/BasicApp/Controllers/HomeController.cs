using BasicApp.Models;
using BasicApp.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace BasicApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudent _studentRepo;

        public  HomeController(IStudent studentRepo)
        {
            _studentRepo = studentRepo;
        }
        [Route("")]
        public IActionResult Index()
        {
            TempData["tempData"] = "this is tempdata";

            TempData["tempData2"] = "this is temp data using keep";
            TempData["tempData3"] = "this is temp data using peek";


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
        public List<Student> getAllStudents()
        {
            return  _studentRepo.getAllStudents();
        }

        public Student getStudentById(int id)
        {
            return _studentRepo.getStudentById(id);
        }

        public List<Student> getStudentsByGender(string gender)
        {
            return _studentRepo.getStudentsByGender(gender);
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

        public IActionResult BagData()
        {


            ViewData["data1"] = "Value in controller using viewData but access using viewBag in view";
            ViewBag.data2 = "Value in controller using viewBag but access using viewData in view";
            return View();
        }

        public IActionResult StronglyTyped()
        {
            Student s1 = new Student()
            {
                Name = "Manan",
                Standard = 1,
                State = "Gujarat",
                Gender = "Male"
            };
            //return View(s1);

            List<Student> sl= _studentRepo.getAllStudents();

            return View(sl);
        }
    }
}
