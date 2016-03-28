using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
        //CALL THE CUSTOMER CLASS HERE AND ALSO THE WEATHER
        //THEN TAKE IN PRICE + WEATHER MODIFIERS
        //THROW IN A LOOP WITH IF ELSE STATEMENTS. BOOM!
        public double priceForTheDay;
        public int daysToPlay;
        public Day()
        {
            
        }
        public int amountOfDaysToPlay()
        {
            Console.WriteLine("Choose how long you would like to play 7, 14, or 21 days.");
            daysToPlay = Convert.ToInt32(Console.ReadLine());
            if (daysToPlay != 7 && daysToPlay != 14 && daysToPlay != 21)
            {
                Console.WriteLine("You entered the wrong amount!!");
                amountOfDaysToPlay();
            }

            return daysToPlay;
        }
        public double SetPriceForDay()
        {
            Console.WriteLine("How much would you like to sell each cup for?");
            priceForTheDay = Convert.ToDouble(Console.ReadLine());
            return priceForTheDay;
        }


    }
}
