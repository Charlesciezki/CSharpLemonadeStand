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
        public Day day = new Day();
        public Weather weather = new Weather();
        
        public UserInterface()
        {
            weather.WeatherStarter();
        }

        public void WelcomeMenu()
        {
        }
        public void MainMenu()
        {

        Console.WriteLine("Enter 1 to go to the store!");
        Console.WriteLine("Enter 2 to show the weather!");
        Console.WriteLine("Enter 3 to exit");

            int MainMenuChoice = Convert.ToInt32(Console.ReadLine());
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
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
