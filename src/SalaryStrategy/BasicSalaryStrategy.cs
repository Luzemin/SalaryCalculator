using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class BasicSalaryStrategy : ISalaryStrategy
    {
        public decimal BasicMoney { get; set; } = 6000;

        public decimal Calculate()
        {
            return Convert.ToDecimal(BasicMoney);
        }
    }
}
