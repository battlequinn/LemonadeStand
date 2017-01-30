using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        private double money;
        public List<Supplies> supplies;

        public double Money { get { return money; } set { money = value; } }
        public Inventory()
        {
            money = 25;
            supplies = new List<Supplies>();
        }
        public void DisplayInventory()
        {
            Console.WriteLine("=============");
            Console.WriteLine("  Inventory  ");
            Console.WriteLine("_____________");
            Console.WriteLine($"\nMoney: ${Money}");
            Console.WriteLine($"Lemons: {supplies[0].Quantity}");
            Console.WriteLine($"Sugar: {supplies[1].Quantity} tbsp");
            Console.WriteLine($"Ice: {supplies[2].Quantity} cubes");
            Console.WriteLine($"Cups: {supplies[3].Quantity}");
            Console.WriteLine($"Pitchers: {supplies[4].Quantity}");
            Console.WriteLine("=============");
        }
    }
}
