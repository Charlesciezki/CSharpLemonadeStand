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
        public List<AngryCustomer> AngryCustomerList = new List<AngryCustomer>(); 
        public AngryCustomer(int n)
        {
            AngryCustomerBaseChance = n;
        }
    }
}
