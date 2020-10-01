using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KorusTest.Model;

namespace KorusTest.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Telephone> Telephones { get; set; }
        public IEnumerable<EmployeesModel> Employees { get; set; }
    }
}
