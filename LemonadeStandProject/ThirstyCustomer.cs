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
        public int ThirstyCustomerBaseChance;
        public string ThirstyCustomerName;
        public ThirstyCustomer(int n, int name)
        {            
            ThirstyCustomerBaseChance = n;
            ThirstyCustomerName = ThirstyCustomerNames[name];

        }
    }
}
