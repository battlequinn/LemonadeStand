using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ingredients
    {
        public double price;
        public int quantity;
        public Ingredients(double price, int quantity)
        {
            this.price = price;
            this.quantity = quantity;
        }
    }
}
