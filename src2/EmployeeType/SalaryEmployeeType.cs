using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SalaryEmployeeType : EmployeeType
    {
        public override ISalaryStrategy SalaryStrategy
        {
            get
            {
                return new BasicSalaryStrategy();
            }
        }
    }
}
