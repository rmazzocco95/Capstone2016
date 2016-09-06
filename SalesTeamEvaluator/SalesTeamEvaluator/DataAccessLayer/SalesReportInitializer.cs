using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SalesTeamEvaluator.Models;

namespace SalesTeamEvaluator.DataAccessLayer
{
    public class SalesReportInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SalesReportContext>
    {
        protected override void Seed(SalesReportContext context)
        {
            var employees = new List<Employee>
            {
                new Employee {FirstName="Bill", LastName="Murphy" },
                new Employee {FirstName="Haley", LastName="Kearney" },
                new Employee {FirstName="Tim", LastName="Woods" },
                new Employee {FirstName="Dave", LastName="Brown" },
                new Employee {FirstName="Nancy", LastName="Lewis" },
                new Employee {FirstName="Reese", LastName="Hangler" },
                new Employee {FirstName="Teresa", LastName="Navas" }
            };

            employees.ForEach(s => context.Employee.Add(s));
            context.SaveChanges();

            var sales = new List<Sale>
            {
                new Sale { TotalSaleAmount=220000, Commission=18000, EmployeeID=2, Date=DateTime.Parse("2015-09-01")},
                new Sale { TotalSaleAmount=230000, Commission=20000, EmployeeID=3, Date=DateTime.Parse("2015-08-02")},
                new Sale { TotalSaleAmount=290000, Commission=24000, EmployeeID=1, Date=DateTime.Parse("2015-07-03")},
                new Sale { TotalSaleAmount=270000, Commission=23000, EmployeeID=4, Date=DateTime.Parse("2016-02-03")},
                new Sale { TotalSaleAmount=320000, Commission=26000, EmployeeID=5, Date=DateTime.Parse("2016-01-05")},
                new Sale { TotalSaleAmount=350000, Commission=28000, EmployeeID=6, Date=DateTime.Parse("2015-10-02")},
                new Sale { TotalSaleAmount=190000, Commission=16000, EmployeeID=8, Date=DateTime.Parse("2015-07-02")},
                new Sale { TotalSaleAmount=220000, Commission=17000, EmployeeID=7, Date=DateTime.Parse("2015-03-09")}
            };

            sales.ForEach(s => context.Sale.Add(s));
            context.SaveChanges();
        }
    }
}
