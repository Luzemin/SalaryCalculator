using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
        public EmployeeType EmployeeType { get; set; }

        private List<IBenefits> benefits;
        public List<IBenefits> Benefits
        {
            get
            {
                //默认添加生日福利
                if (benefits == null && Birthday != null)
                {
                    benefits = new List<IBenefits>() {
                        new BirthdayBenefits(Birthday.Value)
                    };
                }
                return benefits;
            }
            set { benefits = value; }
        }
    }
}
