using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Weather
    {
        public Day day = new Day();
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

        public void WeatherStarter()
        {
            numberOfGamePlayDays = day.amountOfDaysToPlay();
            Console.WriteLine(numberOfGamePlayDays);
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
                i = i + 1;
                Console.WriteLine("Day " + i + " " + weather);

            }

            return weatherPredictionList;
        }

        public void ShowTheWeather()
        {
            foreach (string weather in weatherPredictionList)
            {
                
                Console.WriteLine(weather);

            }
        }
        
    }
}
