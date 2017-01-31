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

        private string currentDay;
        private string todaysHeadline;
        private string daysWeather;
        private string weeksWeather;
        private string taste;

        public string CurrentDay { get { return currentDay; } set { currentDay = value; } }
        public string TodaysHeadline { get { return todaysHeadline; } set { todaysHeadline = value; } }
        public string DaysWeather { get { return daysWeather; } set { daysWeather = value; } }
        public string WeeksWeather { get { return weeksWeather; } set { weeksWeather = value; } }
        public string Taste { get { return taste; } set { taste = value; } }



        public News()
        {
        }
        public void GetNews(Day day, List<Day> days, Random random)
        {
            CurrentDay = GetDay(day);
            TodaysHeadline = GetHeadline(random);
            DaysWeather = GetDailyWeather(day, random);
            WeeksWeather = GetWeeklyWeather(day, days, random);
            Taste = GetTasteOfTheDay(random);
            DisplayNews();
        }
        private void DisplayNews()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine($"{CurrentDay}                               The Daily Lemon");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine((TodaysHeadline));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Weather: {DaysWeather}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Weekly forcast\n");
            Console.WriteLine(WeeksWeather);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(Taste);
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
            day.weather.SetDayOvercast(random);
            day.weather.SetDayTemperature(random);
            string overcast = day.weather.DayOvercast;
            string temperature = day.weather.DayTemperature;
            string weatherReport = $"Today's Temperature will be {temperature} and {overcast}.";
            return weatherReport;
        }
        private string GetWeeklyWeather(Day day, List<Day> days, Random random)
        {
            string weatherReport = "";
            for ( int i = 0; i < 7; i++)
            {
                days[i].weather.SetDayOvercast(random);
                days[i].weather.SetDayTemperature(random);
                string overcast = days[i].weather.DayOvercast;
                string temperature = days[i].weather.DayTemperature;
                if (days[i].number != day.number)
                {
                    weatherReport += $"{days[i].Name}: {temperature} and {overcast}\n";
                }
            }
            return weatherReport;
        }
    }
}
