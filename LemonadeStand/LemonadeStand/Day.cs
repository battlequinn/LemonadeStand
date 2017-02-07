using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public List<Customers> customers = new List<Customers>();
        public Weather weather = new Weather();
        public News news = new News();
        private string name;
        public int number;

        public string Name { get { return name; } set { name = value; } }
        
        public Day(int number)
        {
            this.number = number + 1;
            this.Name = SetDayName();
        }
        private string SetDayName()
        {
            switch (number)
            {
                case 1:
                    Name = "Sunday";
                    break;
                case 2:
                    Name = "Monday";
                    break;
                case 3:
                    Name = "Tuesday";
                    break;
                case 4:
                    Name = "Wednesday";
                    break;
                case 5:
                    Name = "Thursday";
                    break;
                case 6:
                    Name = "Friday";
                    break;
                case 7:
                    Name = "Saturday";
                    break;
                default:
                    Name = "There was an error in processing your request";
                    break;
            }
            return Name;
        }
        public void SetCustomers(Random random)
        {
            int overcastValue = SetOvercastValue(random);
            int temperatureValue = SetTemperatureValue(random);
            int headlineValue = SetHeadlineValue(random);
            int totalCustomers = overcastValue + temperatureValue + headlineValue + random.Next(0, 26);
            for(int i =0; i < totalCustomers; i++)
            {
                customers.Add(customers[i]);
            }
        }
        private int SetOvercastValue(Random random)
        {
            string overcast = weather.DayOvercast;
            int overcastValue = 0;
            switch(overcast){
                case "sunny":
                    overcastValue = random.Next(0, 26);
                    break;
                case "partly cloudy":
                    overcastValue = random.Next(0, 21);
                    break;
                case "cloudy":
                    overcastValue = random.Next(0, 16);
                    break;
                case "raining":
                    overcastValue = random.Next(0, 11);
                    break;
                case "thunder storming":
                    overcastValue = random.Next(0, 6);
                    break;
                default:
                    overcastValue = 0;
                    break;
            }
            return overcastValue;
        }
        private int SetTemperatureValue(Random random)
        {
            string temperature = weather.DayTemperature;
            int temperatureValue = 0;
            switch (temperature)
            {
                case "hot":
                    temperatureValue = random.Next(0, 26);
                    break;
                case "warm":
                    temperatureValue = random.Next(0, 21);
                    break;
                case "cool":
                    temperatureValue = random.Next(0, 11);
                    break;
                case "frigid":
                    temperatureValue = random.Next(0, 6);
                    break;
                default:
                    temperatureValue = 0;
                    break;
            }
            return temperatureValue;
        }
        private int SetHeadlineValue(Random random)
        {
            string headline = news.TodaysHeadline;
            int headlineValue = 0;
            switch (headline)
            {
                case "Uncovered Ghandi Quote: Lemonade Is Key To Soul Enlightenment!":
                    headlineValue = random.Next(0, 26);
                    break;
                case "Instructor Andrew Reviews Local Lemonade Stand And Rates 100/100!":
                    headlineValue = random.Next(0, 26);
                    break;
                case "New Lemonade Stand On The Block Claims Best Taste AND Price! Watch out lemonade business...":   
                    headlineValue = random.Next(0, 11);
                    break;
                case "Developer Nick Claims He Hates Kids! \nEspecially the ones that sell lemonade...\nFind Out Why!":
                    headlineValue = random.Next(0, 11);
                    break;
                default:
                    headlineValue = 0;
                    break;
            }
            return headlineValue;
        }
    }
}
