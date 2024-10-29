using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongebobFanClub.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) 
        { }
        public DbSet<Employees> Employee {  get; set; }
        
        public DbSet<Customer> Customer { get; set; }

        public DbSet<CustomerCity> CustomerCity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerCity>().HasData(
                new CustomerCity { CustomerCityId = 1, City = "Bikini Bottom" }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, CustomerCityId = 1, Name = "Patrick Star" },
                new Customer { CustomerId = 2, CustomerCityId = 1, Name = "Sandy Cheeks" },
                new Customer { CustomerId = 3, CustomerCityId = 1, Name = "Bubble Bass" },
                new Customer { CustomerId = 4, CustomerCityId = 1, Name = "Ms. Puff" }
                );

            modelBuilder.Entity<Employees>().HasData(
                new Employees
                {
                    ID = 1,
                    FirstName = "Spongebob",
                    LastName = "SquarePants",
                    Position = "FryCook",
                    Salary = "$1.45",
                    Age = 27,
                    Email = "spongebob.sq@bikinibottom.com"
                },
                new Employees
                {
                    ID = 2,
                    FirstName = "Squidward",
                    LastName = "Tentacles",
                    Position = "Cashier",
                    Salary = "$30,000",
                    Age = 26,
                    Email = "squidward.tent@bikinibottom.com"
                },
                new Employees
                {
                    ID = 3,
                    FirstName = "Eugene",
                    LastName = "Krabs",
                    Position = "Boss",
                    Salary = "$2,000,000",
                    Age = 72,
                    Email = "captain.krabs@bikinibottom.com"
                }
            );
        }
    }
}
