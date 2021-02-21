using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Calculator
    {
        public static void Calculate(List<EmployeeInfos> employeeInfos)
        {
            employeeInfos.ForEach(item =>
            {
                Console.WriteLine($"{item.Month}月份工资");
                item.Employees.ForEach(employee =>
                {
                    var salary = employee.EmployeeType.SalaryStrategy.Calculate();

                    decimal benifits = 0;
                    employee.Benefits.ForEach(benifit =>
                    {
                        benifits += benifit.GetBenefits();
                    });

                    var total = salary + benifits;
                    Console.WriteLine($"{employee.Name}({employee.EmployeeType.TypeName}): salary-{salary}，benifits-{benifits}， total-{Math.Round(total, 2)}");
                });
                Console.WriteLine(Environment.NewLine);
            });
        }
    }
}
