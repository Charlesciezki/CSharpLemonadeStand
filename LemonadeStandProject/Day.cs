using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace LemonadeStandProject
{
    public class Day
    {
        public double weatherModifier;
        public double priceModifier;
        public double priceForTheDay;
        public int daysToPlay;
        public double price;
        public double priceModify;
        public double weatherModify;
        public double totalModify;
        public int TotalCupsSold = 0;
        public Customer TheCustomer;
        public Store theStore;
        public Weather TheWeather;
        public Wallet TheWallet;
        public UserInterface TheInterface;
        public Day(Store goToTheStore, Weather theWeather, Wallet thePlayerWallet)
        {

            theStore = goToTheStore;
            TheWeather = theWeather;
            TheWallet = thePlayerWallet;
        }
        public int amountOfDaysToPlay()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Choose how long you would like to play 7, 14, or 21 days.");
            bool dayPickBool = Int32.TryParse(Console.ReadLine(), out daysToPlay);
            if (dayPickBool == false)
            {
                return amountOfDaysToPlay();
            }
            if (daysToPlay != 7 && daysToPlay != 14 && daysToPlay != 21)
            {
                Console.WriteLine("You entered the wrong amount!!");
                return amountOfDaysToPlay();
            }

            return daysToPlay;
        }
        public double SetPriceForDay()
        {
            Console.WriteLine("How much would you like to sell each cup for?");
            Console.WriteLine("NOTE: the higher the price the lower the chance to buy is");
            bool success = double.TryParse(Console.ReadLine(), out priceForTheDay);
            if (success == false)
            {
               return SetPriceForDay();
            }
            if (priceForTheDay > .5)
            {
                Console.WriteLine("Don't be greedy!!");
                SetPriceForDay();
            }
            return priceForTheDay;
        }

        public double TheWeatherModifier()
        {
            if (TheWeather.weatherPredictionList[0] == "Sunny and Humid")
            {
                weatherModifier = 60;
            } else if (TheWeather.weatherPredictionList[0] == "Sunny")
            {
                weatherModifier = 50;
            } else if (TheWeather.weatherPredictionList[0] == "Storming and Humid")
            {
                weatherModifier = 40;
            } else if (TheWeather.weatherPredictionList[0] == "Storming")
            {
                weatherModifier = 30;
            } else if (TheWeather.weatherPredictionList[0] == "Overcast")
            {
                weatherModifier = 25;
            } else if (TheWeather.weatherPredictionList[0] == "Foggy")
            {
                weatherModifier = 20;
            }
            
            return weatherModifier;
        }

        public double ThePriceModifier(double todayPrice)
        {
            priceForTheDay = todayPrice;
            if (priceForTheDay > .25)
            {
                priceModifier = 0;
            } else if (priceForTheDay < .25 && priceForTheDay > .19)
            {
                priceModifier = 5;
            } else if (priceForTheDay < .20 && priceForTheDay > .14)
            {
                priceModifier = 10;
            }else if (priceForTheDay < .15)
            {
                priceModifier = 15;
            }
            return priceModifier;
        }

        public void interfaceshit()
        {
            foreach (string lemons in theStore.inventory.lemonsList)
            {
                Console.WriteLine(lemons);
            }
            foreach (string sugar in theStore.inventory.sugarList)
            {
                Console.WriteLine(sugar);
            }
            foreach (string cups in theStore.inventory.cupList)
            {
                Console.WriteLine(cups);
            }
            Console.WriteLine("You have " + theStore.inventory.iceList.Count + " icecubes left.");
        }

        public Customer BeginTheDay()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("It's looking like it's going to be " + TheWeather.weatherPredictionList[0]);

            Console.ForegroundColor = ConsoleColor.Magenta;
            price = SetPriceForDay();
            priceModify = ThePriceModifier(price);
            weatherModify = TheWeatherModifier();
            totalModify = (priceModify + weatherModify);
            

            Customer customer = new Customer();
            Console.WriteLine("Total modifier is " + totalModify);
            customer.customers(totalModify);
            TheCustomer = customer;
            return customer;

        }

        public int DayCycle()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            for (int i = 0; i < TheCustomer.AngryCustomerList.Count; i++)
            {
                Thread.Sleep(50);
                if (TheCustomer.AngryCustomerList[i].AngryCustomerBaseChance >= 65)
                {
                    if (theStore.inventory.lemonsList.Count > 0 && theStore.inventory.cupList.Count > 0 &&
                        theStore.inventory.sugarList.Count > 0 && theStore.inventory.iceList.Count > 3)
                    {
                        theStore.MyTotalWallet = theStore.MyTotalWallet + priceForTheDay;
                        Console.WriteLine("Cup Sold!! You have " + theStore.MyTotalWallet.ToString("C2"));
                        TotalCupsSold = TotalCupsSold + 1;

                        theStore.inventory.lemonsList.RemoveAt(0);
                        theStore.inventory.cupList.RemoveAt(0);
                        theStore.inventory.sugarList.RemoveAt(0);
                        for (int ice = 0; ice < 4; ice++)
                        {
                            theStore.inventory.iceList.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO INVENTORY LEFT");
                        Console.WriteLine("YOUR MISTAKE ENDED YOUR DAY!");
                    
                        return EndDay();
                        
                    }
                }
                else
                {
                    Console.WriteLine("No sale...");
                }

            }
            for (int i = 0; i < TheCustomer.NormalCustomerList.Count; i++)
            {
                Thread.Sleep(50);
                if (TheCustomer.NormalCustomerList[i].NormalCustomerBaseChance >= 65)
                {
                    if (theStore.inventory.lemonsList.Count > 0 && theStore.inventory.cupList.Count > 0 &&
                        theStore.inventory.sugarList.Count > 0 && theStore.inventory.iceList.Count > 3)
                    {
                        theStore.MyTotalWallet = theStore.MyTotalWallet + priceForTheDay;
                        Console.WriteLine("Cup Sold!! You have " + theStore.MyTotalWallet.ToString("C2"));
                        TotalCupsSold = TotalCupsSold + 1;

                        theStore.inventory.lemonsList.RemoveAt(0);
                        theStore.inventory.cupList.RemoveAt(0);
                        theStore.inventory.sugarList.RemoveAt(0);
                        for (int ice = 0; ice < 4; ice++)
                        {
                            theStore.inventory.iceList.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO INVENTORY LEFT");
                        Console.WriteLine("YOUR MISTAKE ENDED YOUR DAY!");

                        return EndDay();
                        
                    }
                }
                else
                {
                    Console.WriteLine("No sale...");
                }

            }
            for (int i = 0; i < TheCustomer.ThirstyCustomerList.Count; i++)
            {
                Thread.Sleep(50);
                if (TheCustomer.ThirstyCustomerList[i].ThirstyCustomerBaseChance >= 65)
                {
                    if (theStore.inventory.lemonsList.Count > 0 && theStore.inventory.cupList.Count > 0 &&
                        theStore.inventory.sugarList.Count > 0 && theStore.inventory.iceList.Count > 3)
                    {
                        theStore.MyTotalWallet = theStore.MyTotalWallet + priceForTheDay;
                        Console.WriteLine("Cup Sold!! You have " + theStore.MyTotalWallet.ToString("C2"));
                        TotalCupsSold = TotalCupsSold + 1;

                        theStore.inventory.lemonsList.RemoveAt(0);
                        theStore.inventory.cupList.RemoveAt(0);
                        theStore.inventory.sugarList.RemoveAt(0);
                        for (int ice = 0; ice < 4; ice++)
                        {
                            theStore.inventory.iceList.RemoveAt(0);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("NO INVENTORY LEFT");
                        Console.WriteLine("YOUR MISTAKE ENDED YOUR DAY!");

                        return EndDay();
                        
                    }
                }
                else
                {
                    Console.WriteLine("No sale...");
                }

            }
            EndDay();
            return 1;
        }

        public int EndDay()
        {
            Thread.Sleep(50);
            if (TheWeather.weatherPredictionList.Count <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Your game has ended!");
                Console.WriteLine("You played for " + daysToPlay);
                Console.WriteLine("You started out with $20, and now you have " + theStore.MyTotalWallet.ToString("C2"));
                Console.ReadLine();
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            TheWeather.weatherPredictionList.RemoveAt(0);
            Console.WriteLine("Your ice has melted!");
            theStore.inventory.iceList.Clear();
            int totalCustomers = (TheCustomer.AngryCustomerList.Count + TheCustomer.NormalCustomerList.Count + TheCustomer.ThirstyCustomerList.Count);
            Console.WriteLine("You had " + totalCustomers + " walk by today! And you sold " + TotalCupsSold);
            double totalIncome = TotalCupsSold*priceForTheDay;
            Console.WriteLine("You made " + totalIncome.ToString("C2"));
            Console.WriteLine("Ice = " + theStore.inventory.iceList.Count);
            Console.WriteLine("Hit enter to continue!");            
            TotalCupsSold = 0;
            Console.ReadLine();
            Console.Clear();
            return 1;
        }
    }
    }

