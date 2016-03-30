using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class ThirstyCustomer
    {
        public List<string> ThirstyCustomerNames = new List<string>() { "Andrew", "Mike", "Adam", "Nick", "Dave" };
        public double ThirstyCustomerBaseChance;
        public string ThirstyCustomerName;
        public ThirstyCustomer(double n, int name)
        {            
            ThirstyCustomerBaseChance = n;
            ThirstyCustomerName = ThirstyCustomerNames[name];

        }
    }
}
