using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Employee.xml");
            var data = XMLParser.Parse(path);
            foreach (int month in data.Keys)
            {
                var employees = data[month];
                Console.WriteLine($"{month}月份工资");
                employees.ForEach(employee =>
                {
                    Console.WriteLine(employee.Name + ":" + Calculator.Calculate(employee));
                });
                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();
        }
    }

}
