using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace LemonadeStandProject
{
    public class UserInterface
    {
        public Store goToStore = new Store();
        public Day day;
        public Weather weather = new Weather();
        public Inventory inventory;
        public int MainMenuChoice;



        public UserInterface()
        {
            day = new Day(goToStore, weather, goToStore.playerWallet);
            weather.WeatherStarter(day);
        }

        public int MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Welcome to the Lemonade Stand Menu!");

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("Enter 1 to go to the store!");
        Console.WriteLine("Enter 2 to show the weather!");
        Console.WriteLine("Enter 3 to start the day!");
        Console.WriteLine("Enter 4 to exit");
            bool MainMenuMistakeCatcher = Int32.TryParse(Console.ReadLine(), out MainMenuChoice);
            if (MainMenuMistakeCatcher == false)
            {
                return MainMenu();
            }
            switch (MainMenuChoice)
            {
                case 1:
                    goToStore.StoreSwitchCase();
                    break;
                case 2:
                    Console.WriteLine("You have " + weather.weatherPredictionList.Count + " days left!");
                    weather.ShowTheWeather();                    
                    break;
                case 3:
                    day.BeginTheDay();
                    day.DayCycle();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("I guess this is goodbye...");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
            return 1;

        }
    }
}