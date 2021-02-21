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
            var infos = XMLParser.Parse(Path.Combine(Environment.CurrentDirectory, "Employee.xml"));
            Calculator.Calculate(infos);

            Console.ReadLine();
        }
    }
}
