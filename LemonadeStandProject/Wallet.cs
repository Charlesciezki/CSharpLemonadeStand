using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Wallet : Inventory
    {
        public double currentAmountInWallet;
        public Wallet()
        {           
        }

        public double FirstDayWallet()
        {
            currentAmountInWallet = 20;
            return currentAmountInWallet;
        }
        public double GetWalletAmount()
        {
            return currentAmountInWallet;
        }
    }
}
