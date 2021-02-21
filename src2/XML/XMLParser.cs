using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp
{
    public static class XMLParser
    {
        public static List<EmployeeInfos> Parse(string xmlPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            var root = doc.SelectSingleNode("department");
            XmlNodeList monthList = root.SelectNodes("month");
            List<EmployeeInfos> res = new List<EmployeeInfos>();
            foreach (XmlNode monthNode in monthList)
            {
                XmlNodeList employeeList = monthNode.SelectNodes("employee");
                List<Employee> employees = new List<Employee>();
                foreach (XmlNode employeeNode in employeeList)
                {
                    string type = employeeNode.Attributes["type"].Value;
                    string name = employeeNode.Attributes["name"].Value;
                    DateTime birthday = Convert.ToDateTime(employeeNode.Attributes["birthday"].Value);
                    EmployeeType employeeType = null;
                    switch (type)
                    {
                        case "salary":
                            employeeType = new SalaryEmployeeType()
                            {
                                TypeName = type
                            };
                            break;
                        case "hour":
                            employeeType = new HourEmployeeType()
                            {
                                TypeName = type,
                                WorkingHours = Convert.ToDouble(employeeNode.Attributes["workingHours"].Value)
                            };
                            break;
                        case "sale":
                            employeeType = new SaleEmployeeType()
                            {
                                TypeName = type,
                                SaleAmount = Convert.ToDouble(employeeNode.Attributes["amount"].Value)
                            };
                            break;
                    }
                    Employee employee = new Employee()
                    {
                        Name = name,
                        Birthday = birthday,
                        EmployeeType = employeeType
                    };
                    employees.Add(employee);
                }

                res.Add(new EmployeeInfos()
                {
                    Month = Convert.ToInt32(monthNode.Attributes["value"].Value),
                    Employees = employees
                });
            }
            return res;
        }
    }
}
