using APP1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace APP1.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context; 
        }

        public IActionResult Index(int? regNumber)
        {
            if (regNumber != null)
            {
                var p = db.Packages.FirstOrDefault(p => p.RegNumber == regNumber);
                if (p != null)
                    return View(p);
                else
                {
                    ViewBag.Message = "Не найдено";
                }
            }
            return View();
        }

        public IActionResult GetP(int? regNumber)
        {
            if (regNumber != null)
            {
                return Content(db.Packages.FirstOrDefault(p => p.RegNumber == regNumber).TransferDate.ToString());
            }
            else
                return Content("Не найдено");
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