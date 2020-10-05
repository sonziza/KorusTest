using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorusTest.Model
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Workrecord> WorkRecords { get; set; }
        public Position()
        {
            WorkRecords = new List<Workrecord>();
        }
    }
}
