using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        public UserInterface()
        {

        }
        public void Title()
        {
            Console.WriteLine("Welcome to...\n\n(Press any key to continue.)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("           *******************           ");
            Console.WriteLine("       ***************************       ");
            Console.WriteLine("      *****************************      ");
            Console.WriteLine("    *******                  ********    ");
            Console.WriteLine("    ******   LEMONADE STAND!  *******    ");
            Console.WriteLine("    *******                  ********    ");
            Console.WriteLine("      *****************************      ");
            Console.WriteLine("       ***************************       ");
            Console.WriteLine("           *******************           ");
            Console.ReadKey();
        }
        public void DisplayInventory()
        {

        }
    }
}
