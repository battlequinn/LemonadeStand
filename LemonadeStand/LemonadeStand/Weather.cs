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

        private string dayOvercast;
        private string dayTemperature;

        public string DayOvercast { get { return dayOvercast; } set { dayOvercast = value; } }
        public string DayTemperature { get { return dayTemperature; } set { dayTemperature = value; } }

        public Weather()
        {
        }

        public void SetDayOvercast(Random random)
        {
            int overcastType = random.Next(0, overcast.Length);
            DayOvercast = overcast[overcastType];
        }
        public void SetDayTemperature(Random random)
        {
            int temperatureType = random.Next(0, temperature.Length);
            DayTemperature = temperature[temperatureType];
        }

    }
}
