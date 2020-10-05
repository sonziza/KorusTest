using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KorusTest.Model; // пространство имен моделей и контекста данных
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using KorusTest.ViewModels; //пространство имен моделей представлений

namespace EFDataApp.Controllers
{
    public class HomeController : Controller
    {
        #region
        //List<Employee> employees;
        //List<Telephone>  telephones;
        //public HomeController()
        //{
        //    employees = new List<Employee>
        //    {
        //        new Employee {Id = 1, FIO = "Иванов Иван Иванович", Salary = 800000, Birthday= new System.DateTime(1998,10,10)},
        //        new Employee {Id = 2, FIO = "Петров Павел Иванович", Salary = 800000, Birthday = new System.DateTime(2000, 10, 10) }
        //    };

        //    //Employee emp1 = new Employee { Id = 1, FIO = "Иванов Иван Иванович", Salary = 800000, Birthday= new System.DateTime(1998,10,10) };
        //    //Employee emp2 = new Employee { Id = 2, FIO = "Петров Павел Иванович", Salary = 800000, Birthday = new System.DateTime(2000, 10, 10) };


        //    telephones = new List<Telephone>
        //    {
        //        new Telephone { Id=1, Number="89559959595", Employee=employees.ElementAt(0) },
        //        new Telephone { Id=2, Number="4235346334543", Employee=employees.ElementAt(0) },
        //        new Telephone { Id=3, Number="33322", Employee=employees.ElementAt(1) },
        //        new Telephone { Id=4, Number="222", Employee=employees.ElementAt(0) },
        //        new Telephone { Id=5, Number="99999", Employee=employees.ElementAt(1) },
        //    };
        //}
        //public IActionResult Index(int? employeeId)
        //{
        //    //формируем список абонентов для передачи в представление
        //    List<EmployeesModel> EmpModels = employees
        //        .Select(e => new EmployeesModel { Id = e.Id, FIO = e.FIO })
        //        .ToList();

        //    //добавляем на первое место "ВСЕ"
        //    EmpModels.Insert(0, new EmployeesModel { Id = 0, FIO = "Все" });

        //    //формируем модель представления
        //    IndexViewModel ivm = new IndexViewModel { Employees = EmpModels, Telephones = telephones };

        //    //Если передан Id сотрудника, фильтруем список
        //    if (employeeId != null && employeeId > 0)
        //    {
        //        ivm.Telephones = telephones.Where(p => p.Employee.Id == employeeId);
        //    }

        //    return View(ivm);
        //}
        #endregion

        private KorusContext db;
        public HomeController(KorusContext context)
        {
            db = context;
        }
        public ActionResult Index()
        {
            //var employees = db.Employees.Include(p => p.Telephones);
            //return View(employees.ToList());
            //return View(await db.Telephones.ToListAsync()); //prev version


            //формируем модель представления
            IndexViewModel ivm = new IndexViewModel { 
                Employees = db.Employees.Include(p => p.Telephones),
                Telephones = db.Telephones, 
                Workrecords = db.Workrecords,
                Positions=db.Positions.Include(w => w.WorkRecords)
            };
            return View(ivm);
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
        }
    }
}