using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace LemonadeStandProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(500);
            Console.WriteLine(@"╦  ┌─┐┌┬┐┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┌┬┐┌─┐┌┐┌┌┬┐
║  ├┤ ││││ ││││├─┤ ││├┤   ╚═╗ │ ├─┤│││ ││
╩═╝└─┘┴ ┴└─┘┘└┘┴ ┴─┴┘└─┘  ╚═╝ ┴ ┴ ┴┘└┘─┴┘");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to Lemonade Stand! The goal of the game is to make as much money as possible during gameplay!");
            Console.WriteLine("You may choose 7, 14, or 21 days to play, each day customers will walk by,"); 
            Console.WriteLine("and depending on your price per cup and the weather they may buy a cup from you.");

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

