using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //SOLID Principle: Single-Responsibility Principle
        //This recipe class is a good example of this principle because it exists to 

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
            Console.WriteLine("\n           -Standard Lemonade Recipe-");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Lemons: 5\nSugar: 16 tbsp = 1 cup\nIce: 25 cubes\n\nThis makes 1 pitcher of standard lemonade.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("\n           -Your Lemonade Recipe-");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Lemons: {Lemons}\nSugar: {Sugar}\nIce: {Ice}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }
    }
}
