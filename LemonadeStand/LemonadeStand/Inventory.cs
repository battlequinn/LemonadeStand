using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public double money;
        public List<Ingredients> ingredients;
        public Inventory(double money)
        {
            this.money = money;
            ingredients = new List<Ingredients>();
        }

    }
}
