using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTeamEvaluator.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SalesTeamEvaluator.DataAccessLayer
{
    public class SalesReportContext : DbContext
    {
        public SalesReportContext() : base("SaleReportContext")
        {
        }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
