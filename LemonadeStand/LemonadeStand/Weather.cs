using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {

        private string[] overcast = new string[5] { "sunny", "cloudy", "partly cloudy", "raining", "thunder-storming" };
        private string[] temperature = new string[4] { "warm", "hot", "cool", "frigid" };

        public Weather()
        {
        }

        public string SetDayOvercast(Random random)
        {
            int overcastType = random.Next(0, overcast.Length);
            string dayOvercast = overcast[overcastType];
            return dayOvercast;
        }
        public string SetDayTemperature(Random random)
        {
            int temperatureType = random.Next(0, temperature.Length);
            string dayTemperature = temperature[temperatureType];
            return dayTemperature;
        }

    }
}
