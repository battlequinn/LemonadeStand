using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        private double money = 20;
        private List<Supplies> supplies;

        public double Money { get { return money; } set { money = value; } }
        public Inventory(double money)
        {
            this.money = money;
            supplies = new List<Supplies>(new Supplies[] { lemons, sugar, ice, cups, pitchers });
        }
    }
}
