using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorusTest.Model
{
    public class KorusContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Workrecord> Workrecord { get; set; }
        public KorusContext(DbContextOptions<KorusContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
