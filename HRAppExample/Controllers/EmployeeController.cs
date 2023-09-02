using HRAppExample.Data;
using HRAppExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRAppExample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.Include(x => x.Department).OrderBy(x => x.FirstName);
            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = _context.Departments.OrderByDescending(x => x.Id).ToList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Store(Employee model)
        {
            // Not Saved
            if (!ModelState.IsValid) Create();

            UploadImage(model);

            // Saved Data
            _context.Employees.Add(model);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        

        public IActionResult Edit(int? Id)
        {
            var result = _context.Employees.Find(Id);

            if (Id == null || result == null)
                return RedirectToAction("Index");

            ViewBag.Departments = _context.Departments.OrderByDescending(x => x.Id).ToList();
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee model) 
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = _context.Departments.OrderByDescending(x => x.Id).ToList();
                return RedirectToAction("Edit");
            }

            UploadImage(model);

            _context.Employees.Update(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int? Id)
        {
            var result = _context.Employees.Find(Id);

            if (result != null)
            {
                _context.Employees.Remove(result);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }



        private void UploadImage(Employee model)
        {
            // Upload Image
            var file = HttpContext.Request.Form.Files;
            if (file.Count() > 0)
            {
                // Upload Image
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(file[0].FileName);
                var FileStream = new FileStream(Path.Combine(@"wwwroot/", "Images", ImageName), FileMode.Create);
                file[0].CopyTo(FileStream);
                model.ImageUser = ImageName;

            }
            else if (model.ImageUser == null && model.Id == null)
            {
                // Not Upload Image
                model.ImageUser = "User-Defult.png";
            }
            else
            {
                // Edit
                model.ImageUser = model.ImageUser;
            }
        }

    }
}
