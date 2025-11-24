using dotnetcoreSessions.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnetcoreSessions.Controllers
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
            //int a = 70;
            //string a = "dotnetcore";
            //return View("Index",a);

            Student student = new Student();
            student.Id = 101;
            student.Name = "Shree";
            student.City = "Kolhapur";


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
