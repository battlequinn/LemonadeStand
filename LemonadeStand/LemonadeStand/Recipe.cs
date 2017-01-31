using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        private int lemons;
        private int sugar;
        private int ice;

        public int Lemons { get { return lemons; } set { lemons = value; } }
        public int Sugar { get { return sugar; } set { sugar = value; } }
        public int Ice { get { return ice; } set { ice = value; } }

        public Recipe()
        {
            lemons = 5;
            sugar = 16;
            ice = 25;
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("=============");
            Console.WriteLine("  Recipe  ");
            Console.WriteLine("_____________");
            Console.WriteLine($"Lemons: {Lemons} \nSugar: {sugar} \nIce: {Ice}");
        }
    }
}
