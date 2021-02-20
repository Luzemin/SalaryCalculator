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
        public static Dictionary<int, List<Employee>> Parse(string xmlPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            var root = doc.SelectSingleNode("department");
            XmlNodeList monthList = root.SelectNodes("month");
            Dictionary<int, List<Employee>> res = new Dictionary<int, List<Employee>>();
            foreach (XmlNode monthNode in monthList)
            {
                XmlNodeList employeeList = monthNode.SelectNodes("employee");
                List<Employee> employees = new List<Employee>();
                foreach (XmlNode employeeNode in employeeList)
                {
                    Employee employee = null;
                    string type = employeeNode.Attributes["type"].Value;
                    string name = employeeNode.Attributes["name"].Value;
                    DateTime birthday = Convert.ToDateTime(employeeNode.Attributes["birthday"].Value);
                    switch (type)
                    {
                        case "salary":
                            employee = new SalaryEmployee()
                            {
                                Name = name,
                                Birthday = birthday
                            };
                            break;
                        case "hour":
                            employee = new HourEmployee()
                            {
                                Name = name,
                                Birthday = birthday,
                                WorkingHours = Convert.ToDouble(employeeNode.Attributes["workingHours"].Value)
                            };
                            break;
                        case "sale":
                            employee = new SaleEmployee()
                            {
                                Name = name,
                                Birthday = birthday,
                                SaleAmount = Convert.ToDouble(employeeNode.Attributes["amount"].Value)
                            };
                            break;
                    }
                    if (employee != null)
                    {
                        employees.Add(employee);
                    }
                }

                res.Add(Convert.ToInt32(monthNode.Attributes["value"].Value), employees);
            }
            return res;
        }
    }
}
