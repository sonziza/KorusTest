using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorusTestModel
{
    class KorusContext:DbContext
    {
        public KorusContext() : base("KorusConnection")
        {}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Telephone> Telephone { get; set; }
        public DbSet<WorkRecord> WorkRecord { get; set; }


    }
}
