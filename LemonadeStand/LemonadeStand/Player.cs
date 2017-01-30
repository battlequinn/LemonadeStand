using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Inventory inventory;
        public Store store;
        public Player()
        {
            inventory = new Inventory();
        }
        public void BuyIngredients(int item, int amount, double expense)
        {
            inventory.supplies[item].Quantity += amount;
            inventory.Money -= expense;
            Console.WriteLine("Thank you for your shopping at The Dolor Lemon!");
        }
    }
}
