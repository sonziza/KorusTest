using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorusTest.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<Workrecord> WorkRecords { get; set; }
        public virtual ICollection<Telephone> Telephones { get; set; }

        //public override string ToString()
        //{
        //    return FIO;
        //}
    }
}
