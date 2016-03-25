using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class AngryCustomer
    {
        public int AngryCustomerBaseChance;
        public string AngryCustomerName;

        public List<string> AngryCustomerNames = new List<string>() {"Charles", "Tyler", "Justin", "Greg", "Kevin"};

        public AngryCustomer(int n, int name)
        {
            AngryCustomerBaseChance = n;
            AngryCustomerName = AngryCustomerNames[name];

        }
    }
}
