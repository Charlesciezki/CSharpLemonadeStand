﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace LemonadeStandProject
{
    public class Store
    {
        public Inventory inventory = new Inventory();
        public Wallet playerWallet = new Wallet();
        public string lemon = "Lemon";
        public string ice = "Ice";
        public string cup = "Cup";
        public string sugar = "Sugar";
        public double pricePerLemon;
        public double pricePerCup;
        public double pricePerSugar;
        public double priceForIceCubes;        
        public int TotalLemonsToBuy;
        public int TotalCupsToBuy;
        public int TotalSugarToBuy;
        public int TotalIceToBuy;
        public int continueToBuy;
        public double MyWallet;
        public double MyTotalWallet;
        public int StoreSwitchChoice;

        public Store()
        {
            MyWallet = playerWallet.FirstDayWallet();
            MyTotalWallet = MyWallet;
        }

        public int StoreSwitchCase()
        {
            bool IsShopping = true;

            while (IsShopping == true)
            {

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Welcome to the store! What would you like to buy?");
                Console.WriteLine("Enter 1 to go through and buy all Lemonade ingredients");
                Console.WriteLine("Enter 2 to buy Lemons");
                Console.WriteLine("Enter 3 to buy cups");
                Console.WriteLine("Enter 4 to buy sugar");
                Console.WriteLine("Enter 5 to buy ice");
                Console.WriteLine("Enter 6 to exit store");
                bool WhatWillYouBuy = Int32.TryParse(Console.ReadLine(), out StoreSwitchChoice);
                if (WhatWillYouBuy == false)
                {
                    return StoreSwitchChoice;
                }
                switch (StoreSwitchChoice)
                {
                    case 1:
                        BuyLemons();
                        BuyCups();
                        BuySugar();
                        BuyIce();
                        break;
                    case 2:
                        BuyLemons();
                        break;
                    case 3:
                        BuyCups();
                        break;
                    case 4:
                        BuySugar();
                        break;
                    case 5:
                        BuyIce();
                        break;
                    case 6:
                        IsShopping = false;
                        break;
                    default:
                        break;
                }
            }
            return 1;
        }
        public int BuyLemons()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            pricePerLemon = .03;
            Console.WriteLine("You have " + MyTotalWallet.ToString("C2"));
            Console.WriteLine("you have " + inventory.lemonsList.Count + " lemons left!");
            Console.WriteLine("Price per lemon is $.03");
            Console.WriteLine("How many do you wish to buy?");
            bool success = Int32.TryParse(Console.ReadLine() ,out TotalLemonsToBuy);
            if (success == false)
            {
               return BuyLemons();
            }
            if (MyTotalWallet < (pricePerLemon*TotalLemonsToBuy))
            {
                Console.WriteLine("Not enough cash!");
                Console.WriteLine("Continue buying lemons? Enter 1 for yes 2 for no.");
                bool willYouContinueToBuy = Int32.TryParse(Console.ReadLine(), out continueToBuy);
                if (willYouContinueToBuy == false)
                {
                    return BuyLemons();
                }
            }
            else if (MyTotalWallet > (pricePerLemon*TotalLemonsToBuy))
            {
                AddLemons();
            }
            return 1;
        }

        public void AddLemons()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < TotalLemonsToBuy; i++)
            {
                inventory.lemonsList.Add(lemon);
            }
            MyTotalWallet = MyTotalWallet - (pricePerLemon*TotalLemonsToBuy);
            Console.WriteLine("You have " + MyTotalWallet.ToString("C2") + " left!");
            Console.WriteLine("you have " + inventory.lemonsList.Count + " lemons left!");
            Console.ReadLine();
        }

        public int BuyCups()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            pricePerCup = .01;
            Console.WriteLine("You have " + MyTotalWallet.ToString("C2"));
            Console.WriteLine("you have " + inventory.cupList.Count + " cups left!");
            Console.WriteLine("Price per cup is $.01");
            Console.WriteLine("How many do you wish to buy?");
            bool success = Int32.TryParse(Console.ReadLine(), out TotalCupsToBuy);
            if (success == false)
            {
             return BuyCups();
            }
            if (MyTotalWallet < (pricePerCup*TotalCupsToBuy))
            {
                Console.WriteLine("Not enough cash!");
                Console.WriteLine("Continue buying cups? Enter 1 for yes 2 for no.");
                bool willYouContinueToBuy = Int32.TryParse(Console.ReadLine(), out continueToBuy);
                if (willYouContinueToBuy == false)
                {
                   return BuyCups();
                }

            }
            else if (MyTotalWallet > (pricePerCup*TotalCupsToBuy))
            {

                AddCups();
            }
            return 1;
        }

        public void AddCups()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < TotalCupsToBuy; i++)
            {
                inventory.cupList.Add(cup);
            }
            MyTotalWallet = MyTotalWallet - (pricePerCup*TotalCupsToBuy);
            Console.WriteLine("You have " + MyTotalWallet.ToString("C2") + " left!");
            Console.WriteLine("you have " + inventory.cupList.Count + " cups left!");
            Console.ReadLine();
        }
        public int BuySugar()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            pricePerSugar = .04;
            Console.WriteLine("You have " + MyTotalWallet.ToString("C2"));
            Console.WriteLine("you have " + inventory.sugarList.Count + " sugars left!");
            Console.WriteLine("The price per pile of sugar is $.04");
            Console.WriteLine("How many do you wish to buy?");
            bool success = Int32.TryParse(Console.ReadLine(), out TotalSugarToBuy);
            if (success == false)
            {
                return BuySugar();
            }
            if (MyTotalWallet < (pricePerSugar * TotalSugarToBuy))
            {
                Console.WriteLine("Not enough cash!");
                Console.WriteLine("Continue buying sugar? Enter 1 for yes 2 for no.");
                bool willYouContinueToBuy = Int32.TryParse(Console.ReadLine(), out continueToBuy);
                if (willYouContinueToBuy == false)
                {
                   return BuySugar();
                }

            }
            else if (MyTotalWallet > (pricePerSugar * TotalSugarToBuy))
            {
                  AddSugar();
            }
            return 1;
        }

        public void AddSugar()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < TotalSugarToBuy; i++)
            {
                inventory.sugarList.Add(sugar);
            }
            MyTotalWallet = MyTotalWallet - (pricePerSugar * TotalSugarToBuy);
            Console.WriteLine("You have $" + MyTotalWallet.ToString("C2") + " left!");
            Console.WriteLine("you have " + inventory.sugarList.Count + " sugars left!");
            Console.ReadLine();
        }

        public int BuyIce()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            priceForIceCubes = .5;
            Console.WriteLine("You have " + MyTotalWallet.ToString("C2"));
            Console.WriteLine("you have " + inventory.iceList.Count + " icecubes left!");
            Console.WriteLine("You buy ice by the 100");
            Console.WriteLine("Price per 100 ice cubes is $.50");
            Console.WriteLine("How many do you wish to buy? NOTE: whatever you enter you will get that x 100 icecubes.");
            bool success = Int32.TryParse(Console.ReadLine(), out TotalIceToBuy);
            if (success == false)
            {
                return BuyIce();
            }
            if (MyTotalWallet < (priceForIceCubes * TotalIceToBuy))
            {
                Console.WriteLine("Not enough cash!");
                Console.WriteLine("Continue buying ice? Enter 1 for yes 2 for no.");
                bool willYouContinueToBuy = Int32.TryParse(Console.ReadLine(), out continueToBuy);
                if (willYouContinueToBuy == false)
                {
                   return BuyIce();
                }

            }
            else if (MyTotalWallet > (priceForIceCubes * TotalIceToBuy))
            {
                AddIce();
            }
            return 1;
        }

        public void AddIce()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < (TotalIceToBuy * 100); i++)
            {
                inventory.iceList.Add(ice);
            }
            MyTotalWallet = MyTotalWallet - (priceForIceCubes * TotalIceToBuy);
            Console.WriteLine("You have " + MyTotalWallet.ToString("C2") + " left!");
            Console.WriteLine("you have " + inventory.iceList.Count + " icecubes left!");
            Console.ReadLine();
        }
    }
}
