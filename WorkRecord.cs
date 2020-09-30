using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorusTestModel
{
    class WorkRecord
    {
        public int WorkBookId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
