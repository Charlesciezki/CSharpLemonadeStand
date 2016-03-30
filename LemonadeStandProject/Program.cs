using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LemonadeStandProject
{
//* Basic Lemonade Stand gameplay must be present(play a lemonade stand online for a bit to get familiar with the gameplay). 
//* A weather system that includes a forecast and actual weather.For example, this could mean a predicted forecast 
//    for a day or week and then what the actual weather is on the given day. 
//*Price of product should affect demand. For example, if the price is too high, sales will decrease.
//* Weather should affect demand.For example, if it is sunny and 90 degrees, sales would likely skyrocket. 
//*Each customer should be a separate object with its own chance of buying a glass of lemonade.
//    This means how much lemonade is purchased and how much they are willing to pay will vary from customer to customer.
//* Game must be a minimum of seven days
//* Bonus Points: Persistent data (file reading/writing) to keep track of game data. For example, how much lemonade is sold and how much profit 
//        is made on each day. This will be written and read from a text file.

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to Lemonade Stand! The goal of the game is to make as much money as possible during gameplay!");
            Console.WriteLine("You may choose 7, 14, or 21 days to play, each day customers will walk by,"); 
            Console.WriteLine("and depending on your price per cup and the weather they may buy a cup from you.");
            Console.WriteLine("----------------------------------------------------");

            UserInterface interFace = new UserInterface();
            bool RunGame = true;
            while (RunGame)
            {

                interFace.MainMenu();
                Console.WriteLine();
            }


        }
     }
 }

