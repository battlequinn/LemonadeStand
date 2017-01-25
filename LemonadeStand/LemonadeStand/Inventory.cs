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
            money = 20;
            supplies = new List<Supplies>();
        }
    }
}
