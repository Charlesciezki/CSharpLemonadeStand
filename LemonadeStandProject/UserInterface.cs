using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        Console.WriteLine("Enter 3 to exit");
            bool MainMenuMistakeCatcher = Int32.TryParse(Console.ReadLine(), out MainMenuChoice);
            if (MainMenuMistakeCatcher == false)
            {
                return MainMenu();
            }
            switch (MainMenuChoice)
            {
                case 1:
                    goToStore.BuyLemons();
                    goToStore.BuyCups();
                    goToStore.BuySugar();
                    goToStore.BuyIce();
                    break;
                case 2:
                    weather.ShowTheWeather();                    
                    break;
                case 3:
                    Console.WriteLine("I guess this is goodbye...");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                case 4:
                    day.BeginTheDay();
                   break;
            }
            return 1;

        }
    }
}
