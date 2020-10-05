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
        public DbSet<Workrecord> Workrecords { get; set; }
        public KorusContext(DbContextOptions<KorusContext> options) : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workrecord>()
                .HasKey(t => new { t.EmployeeId, t.PositionId });

            modelBuilder.Entity<Workrecord>()
                .HasOne(sc => sc.Employee)
                .WithMany(s => s.WorkRecords)
                .HasForeignKey(sc => sc.EmployeeId);

            modelBuilder.Entity<Workrecord>()
                .HasOne(sc => sc.Position)
                .WithMany(c => c.WorkRecords)
                .HasForeignKey(sc => sc.PositionId);
        }
    }
}
