using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class BirthdayBenefits : IBenefits
    {
        private DateTime birthday;

        public BirthdayBenefits(DateTime birthday)
        {
            this.birthday = birthday;
        }

        public decimal GetBenefits()
        {
            return (birthday.Month == DateTime.Today.Month && birthday.Day == DateTime.Today.Day) ? 100 : 0;
        }
    }
}
