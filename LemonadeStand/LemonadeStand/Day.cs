using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        private string name;
        private int number = 1;

        public int Number { get { return number; } set { number = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Day()
        {
        }
        public void GetDayName()
        {
            switch (Number)
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
            }

        }
    }
}
