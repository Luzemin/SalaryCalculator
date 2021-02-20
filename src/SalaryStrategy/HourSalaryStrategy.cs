using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class HourSalaryStrategy : ISalaryStrategy
    {
        public double WorkingHours { get; set; }
        public int HourMoney { get; set; } = 35;
        public int BasicHours { get; set; } = 160;
        public double AwardTimes { get; set; } = 1.5;

        public HourSalaryStrategy(double workingHours)
        {
            WorkingHours = workingHours;
        }
        public decimal Calculate()
        {
            double result = WorkingHours > BasicHours ? BasicHours * HourMoney + (WorkingHours - BasicHours) * HourMoney * AwardTimes : WorkingHours * HourMoney;
            return Convert.ToDecimal(result);
        }
    }
}
