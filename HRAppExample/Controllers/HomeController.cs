using HRAppExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HRAppExample.Controllers
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
        [HttpGet]
        public ViewResult AllEmployees()
        {
            var employees = Repository.GetEmployees().Where(e => e.IsActive);
            return View(employees);
        }

        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Repository.AddEmployee(employee);
                return View("ConfirmationPage", employee);
            }
            else
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}