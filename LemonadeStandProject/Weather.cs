using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Weather
    {

        public string SunnyAndHumid = "Sunny and Humid";
        public string Sunny = "Sunny";
        public string StormingAndHumid = "Storming and Humid";
        public string Storming = "Storming";
        public string OverCast = "Overcast";
        public string Foggy = "Foggy";
        public string Snowing = "Snowing";        
        public List<string> DaysOfTheWeek = new List<string>() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}; 
        public List<string> weatherPredictionList = new List<string>();
        
    }
}
