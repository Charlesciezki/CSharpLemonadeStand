using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
        public double weatherModifier;
        public double priceModifier;
        public double priceForTheDay;
        public int daysToPlay;
        public double totalModifier;
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
            priceForTheDay = Convert.ToDouble(Console.ReadLine());
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
                weatherModifier = 35;
            } else if (TheWeather.weatherPredictionList[0] == "Overcast")
            {
                weatherModifier = 30;
            } else if (TheWeather.weatherPredictionList[0] == "Foggy")
            {
                weatherModifier = 25;
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

        public double TotalBuyingModifier(double weatherValue, double priceValue)
        {
            weatherModifier = weatherValue;
            priceModifier = priceValue;
            totalModifier = (priceModifier + weatherModifier);
            return totalModifier;
        }

        public void interfaceshit()
        {
            Console.WriteLine(totalModifier);
            
        }

        public void BeginTheDay()
        {
            double price = SetPriceForDay();
            double priceModify = ThePriceModifier(price);
            double weatherModify = TheWeatherModifier();
            double totalModify = (priceModify + weatherModify);

            Customer customer = new Customer();
            Console.WriteLine("Total modifier is " + totalModify);
            customer.customers(totalModify);

        }

    }
    }

