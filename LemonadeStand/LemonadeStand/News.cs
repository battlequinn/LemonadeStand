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
        public void GetNews(Day day, List<Day> days, Random random)
        {
            string currentDay = GetDay(day);
            string headline = GetHeadline(random);
            string daysWeather = GetDailyWeather(day, random);
            string weeksWeather = GetWeeklyWeather(day, days, random);
            string taste = GetTasteOfTheDay(random);
            DisplayNews(currentDay, headline, daysWeather, weeksWeather, taste);
        }
        private void DisplayNews(string currentDay, string headline, string daysWeather, string weeksWeather, string taste)
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine($"{currentDay}                               The Daily Lemon");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine((headline));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Weather: {daysWeather}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Weekly forcast\n");
            Console.WriteLine(weeksWeather);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(taste);
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey();
        }
        private string GetDay(Day day)
        {
            string currentDay = $"Day {day.number}: {day.Name}";
            return currentDay;
        }
        private string GetHeadline(Random random)
        {
            string todaysHeadline = headline.WriteHeadline(random);
            return todaysHeadline;
        }
        private string GetTasteOfTheDay(Random random)
        {
            string currentTaste = tasteOfTheDay.WriteTaste(random);
            string currentTemp = tasteOfTheDay.WriteTemp(random);
            string taste = $"Taste Of The Day: {currentTaste}, {currentTemp} lemonade!";
            return taste;
        }
        private string GetDailyWeather(Day day, Random random)
        {
            string overcast = day.weather.SetDayOvercast(random);
            string temperature = day.weather.SetDayTemperature(random);
            string weatherReport = $"Today's Temperature will be {temperature} and {overcast}.";
            return weatherReport;
        }
        private string GetWeeklyWeather(Day day, List<Day> days, Random random)
        {
            string weatherReport = "";
            for ( int i = 0; i < 7; i++)
            {
                string overcast = days[i].weather.SetDayOvercast(random);
                string temperature = days[i].weather.SetDayTemperature(random);
                if (days[i].number != day.number)
                {
                    weatherReport += $"{days[i].Name}: {temperature} and {overcast}\n";
                }
            }
            return weatherReport;
        }
    }
}
