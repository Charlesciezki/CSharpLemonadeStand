using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Store : Wallet
    {
        public Wallet myWallet = new Wallet();
        public string lemon = "Lemon";
        public string ice = "Ice";
        public string cup = "Cup";
        public string sugar = "Sugar";
        public double pricePerLemon;
        public double pricePerCup;
        public double pricePerSugar;
        public double priceForIceCubes;
        public double MyWallet;
        public int TotalLemonsToBuy;
        public int TotalCupsToBuy;
        public int TotalSugarToBuy;
        public int TotalIceToBuy;
        public Store()
        {
            MyWallet = myWallet.FirstDayWallet();
            Console.WriteLine(MyWallet);
        }

        public void BuyLemons()
        {
            
            pricePerLemon = .07;
            Console.WriteLine("Price per lemon is $.07");
            Console.WriteLine("How many do you wish to buy?");
            TotalLemonsToBuy = Convert.ToInt32(Console.ReadLine());
            if (MyWallet < (pricePerLemon*TotalLemonsToBuy))
            {
                Console.WriteLine("Not enough cash!");
                BuyLemons();
            } else if (MyWallet > (pricePerLemon*TotalLemonsToBuy))
            {
                AddLemons();
            }
        }

        public void AddLemons()
        {
              for (int i = 0; i<TotalLemonsToBuy; i++)
                {
                    lemonsList.Add(lemon);
                }
                MyWallet = MyWallet - (pricePerLemon* TotalLemonsToBuy);
                Console.WriteLine("You have $" + MyWallet + " left!");
                Console.WriteLine("you have " + lemonsList.Count + " lemons left!");
        }

        public void BuyCups()
        {
            pricePerCup = .03;
            Console.WriteLine("Price per cup is $.03");
            Console.WriteLine("How many do you wish to buy?");
            TotalCupsToBuy = Convert.ToInt32(Console.ReadLine());
            if (MyWallet < (pricePerCup * TotalCupsToBuy))
            {
                Console.WriteLine("Not enough cash!");
                BuyCups();
            }
            else if (MyWallet > (pricePerCup * TotalCupsToBuy))
            {
                AddCups();
            }
        }

        public void AddCups()
        {
            for (int i = 0; i < TotalCupsToBuy; i++)
            {
                cupList.Add(cup);
            }
            MyWallet = MyWallet - (pricePerCup * TotalCupsToBuy);
            Console.WriteLine("You have $" + MyWallet + " left!");
            Console.WriteLine("you have " + cupList.Count + " cups left!");
        }

        public void BuySugar()
        {
            pricePerSugar = .07;
            Console.WriteLine("The price per pile of sugar is $.07");
            Console.WriteLine("How many do you wish to buy?");
            TotalSugarToBuy = Convert.ToInt32(Console.ReadLine());
            if (MyWallet < (pricePerSugar * TotalSugarToBuy))
            {
                Console.WriteLine("Not enough cash!");
                BuySugar();
            }
            else if (MyWallet > (pricePerSugar * TotalSugarToBuy))
            {
                AddSugar();
            }
        }

        public void AddSugar()
        {
            for (int i = 0; i < TotalSugarToBuy; i++)
            {
                sugarList.Add(sugar);
            }
            MyWallet = MyWallet - (pricePerSugar * TotalSugarToBuy);
            Console.WriteLine("You have $" + MyWallet + " left!");
            Console.WriteLine("you have " + sugarList.Count + " sugars left!");
        }

        public void BuyIce()
        {
            priceForIceCubes = .80;
            Console.WriteLine("You buy ice by the 100");
            Console.WriteLine("Price per 100 ice cubes is $.80");
            Console.WriteLine("How many do you wish to buy? NOTE: whatever you enter you will get that x 100 icecubes.");
            TotalIceToBuy = Convert.ToInt32(Console.ReadLine());
            if (MyWallet < (priceForIceCubes * TotalIceToBuy))
            {
                Console.WriteLine("Not enough cash!");
                BuyIce();
            }
            else if (MyWallet > (priceForIceCubes * TotalIceToBuy))
            {
                AddIce();
            }
        }

        public void AddIce()
        {
            for (int i = 0; i < (TotalIceToBuy * 100); i++)
            {
                iceList.Add(ice);
            }
            MyWallet = MyWallet - (pricePerSugar * TotalSugarToBuy);
            Console.WriteLine("You have $" + MyWallet + " left!");
            Console.WriteLine("you have " + iceList.Count + " icecubes left!");
        }
    }
}
