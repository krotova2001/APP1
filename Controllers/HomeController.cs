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

        public IActionResult Index(string? regNumber)
        {
            if (regNumber!=null)
            {
                if (regNumber.Length >= 10)
                {
                    var p = db.Packages.FirstOrDefault(p => p.RegNumber == regNumber);
                    if (p != null)
                        return View(p);
                    else
                    {
                        ViewBag.Message = "Не найдено";
                    }
                }
                
                else
                {
                    ViewBag.Message = "Введите минимум 10 цифр";
                }
                
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
