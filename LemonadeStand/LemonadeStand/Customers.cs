using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customers
    {
        private int demand;
        
        public int Demand { get { return demand; } set { demand = value; } }
        public Customers()
        {
            demand = 0;
        }
    }
}
