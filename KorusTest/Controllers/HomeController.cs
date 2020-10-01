using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KorusTest.Model; // пространство имен моделей и контекста данных

namespace EFDataApp.Controllers
{
    public class HomeController : Controller
    {
        private KorusContext db;
        public HomeController(KorusContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Employees.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            db.Employees.Add(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}