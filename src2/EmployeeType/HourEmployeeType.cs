using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class HourEmployeeType : EmployeeType
    {
        public double WorkingHours { get; set; }
        public override ISalaryStrategy SalaryStrategy
        {
            get
            {
                return new HourSalaryStrategy(WorkingHours);
            }
        }
    }
}
