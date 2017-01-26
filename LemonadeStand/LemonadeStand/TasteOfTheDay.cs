using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class TasteOfTheDay
    {
        Random random = new Random();

        private string[] taste = new string[2] { "sweet", "sour" };
        private string[] temp = new string[3] { "cool", "ice-cold","warm" };

        public string WriteTaste()
        {
            int tasteSelection = random.Next(0, taste.Length);
            string currentTaste = taste[tasteSelection];
            return currentTaste;
        }
        public string WriteTemp()
        {
            int tempSelection = random.Next(0, temp.Length);
            string currentTemp = temp[tempSelection];
            return currentTemp;
        }
    }
}
