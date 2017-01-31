using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        Recipe recipe = new Recipe();
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
            Console.WriteLine($"Money: ${Money}");
            foreach(Supplies supplies in supplies)
            {
                Console.WriteLine($"{supplies.Name}: {supplies.Quantity}");
            }
            Console.WriteLine("=============");
        }
    }
}
