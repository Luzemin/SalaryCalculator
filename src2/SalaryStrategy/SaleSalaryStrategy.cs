using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SaleSalaryStrategy : ISalaryStrategy
    {
        public double SaleAmount { get; set; }
        public double BasicMoney { get; set; } = 20000;
        public double AwardMinAmount { get; set; } = 20000;
        public double AwardMinTimes { get; set; } = 0.05;
        public double AwardMaxAmount { get; set; } = 30000;
        public double AwardMaxTimes { get; set; } = 0.08;

        public SaleSalaryStrategy(double saleAmount)
        {
            SaleAmount = saleAmount;
        }

        public decimal Calculate()
        {
            double result = 0d;
            if (SaleAmount > AwardMaxAmount)
            {
                result = BasicMoney + (SaleAmount - AwardMaxAmount) * AwardMaxTimes;
                return Convert.ToDecimal(result);
            }

            if (SaleAmount > AwardMinAmount)
            {
                result = BasicMoney + (SaleAmount - AwardMinAmount) * AwardMinTimes;
                return Convert.ToDecimal(result);
            }

            result = BasicMoney;
            return Convert.ToDecimal(result);
        }
    }
}
