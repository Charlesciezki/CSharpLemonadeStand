using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class UserInterface
    {
        public Store goToStore = new Store();
        public UserInterface()
        {
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome to Lemonade Stand! The goal of the game is to make as much money as possible during gameplay!");
            Console.WriteLine("You may choose 7, 14, or 21 days to play, each day customers will walk by,");
            Console.WriteLine("and depending on your price per cup and the weather they may buy a cup from you.");

            Console.WriteLine("Enter 1 to go to the store!");
            int MainMenuChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (MainMenuChoice)
            {
                case 1:
                    goToStore.BuyLemons();
                    goToStore.BuyCups();
                    goToStore.BuySugar();
                    goToStore.BuyIce();
                    break;
            }

        }
    }
}
