using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Headline
    {
        private string[] headline = new string[4] {"New Lemonade Stand On The Block Claims Best Taste AND Price! Watch out lemonade business...",
            "Developer Nick Claims He Hates Kids! \nEspecially the ones that sell lemonade...\nFind Out Why!",
        "Instructor Andrew Reviews Local Lemonade Stand And Rates 100/100!", "Uncovered Ghandi Quote: Lemonade Is Key To Soul Enlightenment!" };

        public Headline()
        {
        }
        public string WriteHeadline(Random random)
        {
            int headlineSelection = random.Next(0, headline.Length);
            string currentHeadline = headline[headlineSelection];
            return currentHeadline;
        }
    }
}
