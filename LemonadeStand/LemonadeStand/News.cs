using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class News
    {
        Headline headline = new Headline();
        TasteOfTheDay tasteOfTheDay = new TasteOfTheDay();

        public News()
        {
        }
        public void DisplayNews(int day, string dayName, Weather weather)
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine($"{GetDay(day, dayName)}                                The Daily Lemon");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(GetHeadline());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(GetWeatherReport(weather));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(GetTasteOfTheDay());
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey();
        }
        public string GetDay(int day,string name)
        {
            string currentDay = $"Day {day}: {name}";
            return currentDay;
        }
        private string GetHeadline()
        {
            string todaysHeadline = headline.WriteHeadline();
            return todaysHeadline;
        }
        private string GetTasteOfTheDay()
        {
            string currentTaste = tasteOfTheDay.WriteTaste();
            string currentTemp = tasteOfTheDay.WriteTemp();
            string taste = $"Taste Of The Day: {currentTaste}, {currentTemp} lemonade!";
            return taste;
        }
        private string GetWeatherReport(Weather weather)
        {
            string overcast = weather.SetDayOvercast();
            string temperature = weather.SetDayTemperature();
            string weatherReport = $"Today's Temperature will be {temperature} and {overcast}.";
            return weatherReport;
        }
    }
}
