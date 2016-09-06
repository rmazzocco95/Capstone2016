using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTeamEvaluator.Models
{
    public class Sale
    {
        public int ID { get; set; }
        public int TotalSaleAmount { get; set; }
        public int Commission { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
