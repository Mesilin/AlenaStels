using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlenaStels.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            //    Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Device> Devices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=D:\\AlenaStels.sqlite");

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee { EmployeeId = 1, FIO = "Иванов ИИ" },
        //        new Employee { EmployeeId = 2, FIO = "Петров ПП" },
        //        new Employee { EmployeeId = 3, FIO = "Силоров СС" });

        //    modelBuilder.Entity<Employee>().HasData(
        //        new Device { DeviceId = 1, Name = "Прибор 1" },
        //        new Device { DeviceId = 2, Name = "Прибор 2" },
        //        new Device { DeviceId = 3, Name = "Прибор 3" });
        //}
    }
}
