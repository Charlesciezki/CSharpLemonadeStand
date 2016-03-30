using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LemonadeStandProject
{
    public class Weather
    {
        
        public Random random = new Random();
        public int randomWeather;
        public int numberOfGamePlayDays;
        int i = 0;
        public string SunnyAndHumid = "Sunny and Humid";
        public string Sunny = "Sunny";
        public string StormingAndHumid = "Storming and Humid";
        public string Storming = "Storming";
        public string OverCast = "Overcast";
        public string Foggy = "Foggy";
        public List<string> weatherPredictionList = new List<string>();

        public Weather()
        {

        }

        public void WeatherStarter(Day day)
        {
            numberOfGamePlayDays = day.amountOfDaysToPlay();
            Console.WriteLine("You've selected " + numberOfGamePlayDays + " days!");
            Console.WriteLine("Here's the weather prediction for the next " + numberOfGamePlayDays + " days:");
            weatherPredictionList = assembleWeatherList();
        }

        public List<string> assembleWeatherList()
        {
            for (int i = 0; i < numberOfGamePlayDays; i++)
            {
                randomWeather = random.Next(1, 7);

                if (randomWeather == 1)
                {
                    weatherPredictionList.Add(SunnyAndHumid);
                }
                else if (randomWeather == 2)
                {
                    weatherPredictionList.Add(Sunny);
                }
                else if (randomWeather == 3)
                {
                    weatherPredictionList.Add(StormingAndHumid);
                }
                else if (randomWeather == 4)
                {
                    weatherPredictionList.Add(Storming);
                }
                else if (randomWeather == 5)
                {
                    weatherPredictionList.Add(OverCast);
                }
                else if (randomWeather == 6)
                {
                    weatherPredictionList.Add(Foggy);
                }

            }

            foreach (string weather in weatherPredictionList)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                i = i + 1;
                Console.WriteLine("Day " + i + " " + weather);
                Thread.Sleep(50);

            }

            return weatherPredictionList;
        }

        public void ShowTheWeather()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (string weather in weatherPredictionList)
            {
                
                Console.WriteLine(weather);
                Thread.Sleep(50);

            }
        }
        
    }
}
