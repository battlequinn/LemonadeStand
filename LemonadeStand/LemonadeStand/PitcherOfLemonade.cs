using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class PitcherOfLemonade
    {
        private int lemons;
        private int sugar;
        private int ice;
        private int cups;
        private int pitchers;

        public int Lemons { get { return lemons; } set { lemons = value; } }
        public int Sugar { get { return sugar; } set { sugar = value; } }
        public int Ice { get { return ice; } set { ice = value; } }
        public int Cups { get { return cups; } set { cups = value; } }
        public int Pitchers { get { return pitchers; } set { pitchers = value; } }

        public PitcherOfLemonade(int lemons, int sugar, int ice, int pitchers)
        {
            Lemons = lemons;
            Sugar = sugar;
            Ice = ice;
            Pitchers = pitchers;
        }
    }
}
