using CODEFIRST.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
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
        public async  Task<IActionResult> Index()
        {
            var studentsData = await _DbContext.Students.ToListAsync();
            return View(studentsData);
        }

        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public async  Task<IActionResult> Create(Student student)
        {
            if(ModelState.IsValid)
            {
                await _DbContext.Students.AddAsync(student);
                await _DbContext.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }
            return View();
        }


        public async Task<IActionResult> Details(int id)
        {

            if (id == null || _DbContext.Students == null) return NotFound();
            var student=await _DbContext.Students.FirstOrDefaultAsync(x=>x.Id==id);

            if (student == null) return NotFound();
            return View(student);
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            if(id == null || _DbContext.Students == null) return NotFound();
            var student = await _DbContext.Students.FindAsync(id);
            if(student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id,Student student)
        {
            if (id != student.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _DbContext.Students.Update(student);
                await _DbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(student);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || _DbContext.Students == null) return NotFound();
            var student = await _DbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (student == null) return NotFound();


            return View(student);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int ? id)
        {
            var student = await _DbContext.Students.FindAsync(id);
            if (student != null)
            {
                _DbContext.Students.Remove(student);
                await _DbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
                
            }

            return View(student);
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
