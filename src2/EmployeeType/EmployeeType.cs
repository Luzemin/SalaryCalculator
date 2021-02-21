using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class EmployeeType
    {
        public string TypeName { get; set; }
        public virtual ISalaryStrategy SalaryStrategy { get; }
    }
}
