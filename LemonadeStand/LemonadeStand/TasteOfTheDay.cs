using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class TasteOfTheDay
    {

        private string[] taste = new string[2] { "sweet", "sour" };
        private string[] temp = new string[3] { "cool", "ice-cold","warm" };

        private string dayTaste;
        private string dayTemp;

        public string DayTaste { get { return dayTaste; } set { dayTaste = value; } }
        public string DayTemp { get { return dayTemp; } set { dayTemp = value; } }

        public void WriteTaste(Random random)
        {
            int tasteSelection = random.Next(0, taste.Length);
            DayTaste = taste[tasteSelection];
        }
        public void WriteTemp(Random random)
        {
            int tempSelection = random.Next(0, temp.Length);
            DayTemp = temp[tempSelection];
        }
    }
}
