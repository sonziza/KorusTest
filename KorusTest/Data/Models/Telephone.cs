using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorusTest.Model
{
    public class Telephone
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int? EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
