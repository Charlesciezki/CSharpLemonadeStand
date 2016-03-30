using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class NormalCustomer
    {
        public List<string> NormalCustomerNames = new List<string>() { "Billy", "Bobby", "Susie", "Sarah", "Robert" };
        public string NormalCustomerName;
        public double NormalCustomerBaseChance;

        public NormalCustomer(double n, int name)
        {
            NormalCustomerBaseChance = n;
            NormalCustomerName = NormalCustomerNames[name];
        }
    }
}
