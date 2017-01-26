using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class News
    {
        Weather weather = new Weather();
        Headline headline = new Headline();
        TasteOfTheDay tasteOfTheDay = new TasteOfTheDay();
        Day day = new Day();
        

        private string currentDay;
        private string todaysHeadline;
        private string weatherReport;
        private string taste;
        

        public News()
        {
            currentDay = GetDay();
            todaysHeadline = GetHeadline();
            weatherReport = GetWeatherReport();
            taste = GetTasteOfTheDay();
        }
        public void DisplayNews()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine($"{currentDay}                                       The Daily Lemon");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(todaysHeadline);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(weatherReport);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(taste);
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey();
        }
        private string GetDay()
        {
            int dayNumber = day.Number;
            string currentDay = $"Day {dayNumber}";
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
            taste = $"Taste Of The Day: {currentTaste}, {currentTemp} lemonade!";
            return taste;
        }
        private string GetWeatherReport()
        {
            string overcast = weather.SetDayOvercast();
            string temperature = weather.SetDayTemperature();
            weatherReport = $"Today's Temperature will be {temperature} and {overcast}.";
            return weatherReport;
        }
    }
}
