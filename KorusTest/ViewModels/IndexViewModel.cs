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
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Workrecord> Workrecords { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}
