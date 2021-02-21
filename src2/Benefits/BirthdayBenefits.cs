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
            if (birthday == null)
            {
                throw new Exception("birthday is null, can not create birthday benefits");
            }
            this.birthday = birthday;
        }

        public decimal GetBenefits()
        {
            return (birthday.Month == DateTime.Today.Month && birthday.Day == DateTime.Today.Day) ? 100 : 0;
        }
    }
}
