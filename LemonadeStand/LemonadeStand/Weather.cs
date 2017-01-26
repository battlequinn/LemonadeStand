using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        Random random = new Random();


        private string[] overcast = new string[5] { "sunny", "cloudy", "partly cloudy", "raining", "thunder-storming" };
        private string[] temperature = new string[4] { "warm", "hot", "cool", "frigid" };

        public Weather()
        {
        }

        public string CreateDayOvercast()
        {
            int overcastType = random.Next(0, overcast.Length);
            string dayOvercast = overcast[overcastType];
            return dayOvercast;
        }
        public string CreateDayTemperature()
        {
            int temperatureType = random.Next(0, temperature.Length);
            string dayTemperature = temperature[temperatureType];
            return dayTemperature;
        }

    }
}
