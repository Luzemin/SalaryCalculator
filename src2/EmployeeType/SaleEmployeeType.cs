using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SaleEmployeeType : EmployeeType
    {
        public double SaleAmount { get; set; }
        public override ISalaryStrategy SalaryStrategy
        {
            get
            {
                return new SaleSalaryStrategy(SaleAmount);
            }
        }
    }
}
