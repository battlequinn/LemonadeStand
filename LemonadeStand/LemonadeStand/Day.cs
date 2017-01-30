using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
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
    }
}
