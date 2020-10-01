using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KorusTest.Model; // пространство имен моделей и контекста данных
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;

namespace EFDataApp.Controllers
{
    public class HomeController : Controller
    {

        List<Telephone>  telephones;
        public HomeController()
        {
            Employee emp1 = new Employee { Id = 1, FIO = "Иванов Иван Иванович", Salary = 800000, Birthday= new System.DateTime(1998,10,10) };
            Employee emp2 = new Employee { Id = 2, FIO = "Петров Павел Иванович", Salary = 800000, Birthday = new System.DateTime(2000, 10, 10) };

            telephones = new List<Telephone>
            {
                new Telephone { Id=1, Number="89559959595", Employee=emp1 },
                new Telephone { Id=2, Number="4235346334543", Employee=emp1 },
                new Telephone { Id=3, Number="33322", Employee=emp2 },
                new Telephone { Id=4, Number="222", Employee=emp1 },
                new Telephone { Id=5, Number="99999", Employee=emp2 },
            };
        }
        public IActionResult Index()
        {
            return View(telephones);
        }

        /*private KorusContext db;
        public HomeController(KorusContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.Telephones.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Telephone telephone)
        {
            db.Telephones.Add(telephone);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }*/
    }
}