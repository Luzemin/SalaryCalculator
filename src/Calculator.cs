using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Calculator
    {
        public static decimal Calculate(Employee employee)
        {
            ISalaryStrategy strategy = GetStrategy(employee);
            IBenefits benefits = new BirthdayBenefits(employee.Birthday);
            decimal result = strategy.Calculate() + benefits.GetBenefits();
            return Math.Round(result, 2);
        }

        private static ISalaryStrategy GetStrategy(Employee employee)
        {
            ISalaryStrategy strategy = new BasicSalaryStrategy();
            switch (employee.GetType().Name)
            {
                case nameof(SalaryEmployee):
                    strategy = new BasicSalaryStrategy();
                    break;
                case nameof(HourEmployee):
                    var workingHours = (employee as HourEmployee).WorkingHours;
                    strategy = new HourSalaryStrategy(workingHours);
                    break;
                case nameof(SaleEmployee):
                    var saleAmount = (employee as SaleEmployee).SaleAmount;
                    strategy = new SaleSalaryStrategy(saleAmount);
                    break;
            }
            return strategy;
        }

    }
}
