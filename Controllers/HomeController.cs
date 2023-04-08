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

        public async Task<IActionResult> GetPackages()
        {
            if (db.Database.CanConnect())
            {
                //if (RegNumber.ToString().Length != 10)
                  //  return BadRequest();
                //else
                {
                    //Model = await db.Packages.FirstOrDefaultAsync(m => m.RegNumber == RegNumber);
                }
                return View(await db.Packages.ToListAsync());
            }
            else
            {
                return View();
            }
        }

        public IActionResult Index()
        {
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