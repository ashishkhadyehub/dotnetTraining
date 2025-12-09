using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LA.UI.Controllers
{
    public class BasicsController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "data in viewbag";
            //ViewData["Message"] = "data in viewdata";
            TempData["Message"] = "data in tempdata";
            return View();
        }

        public IActionResult NextPage()
        {
            return View();
        }


    }
}
