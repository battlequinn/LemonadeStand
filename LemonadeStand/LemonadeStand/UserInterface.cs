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
            Console.WriteLine("                          *  *        ");
            Console.WriteLine("                       *       *          ");
            Console.WriteLine("                     *            *   **      ");
            Console.WriteLine("                        *  *  *    ***         ");
            Console.WriteLine("                                 ** * *     ");
            Console.WriteLine("                 ****************   *   *  ");
            Console.WriteLine("          *********************    *     *    ");
            Console.WriteLine("      ************************   *       *   ");
            Console.WriteLine("    ****                  ****   *      *  ");
            Console.WriteLine("  *****  LEMONADE STAND!  ****    *   *   ");
            Console.WriteLine("  *****                  ****       *    ");
            Console.WriteLine("  **************************            ");
            Console.WriteLine("   *********************                ");
            Console.WriteLine("      *************                   ");
            Console.ReadKey();
        }
        public void DisplayInventory(double money, int lemons, int sugar, int ice, int cups, int pitchers)
        {
            Console.Clear();
            Console.WriteLine("=============");
            Console.WriteLine("  Inventory  ");
            Console.WriteLine("_____________");
            Console.WriteLine($"\nMoney: ${money}");
            Console.WriteLine($"Lemons: {lemons}");
            Console.WriteLine($"Sugar: {sugar}");
            Console.WriteLine($"Ice: {ice}");
            Console.WriteLine($"Cups: {cups}");
            Console.WriteLine($"Pitchers: {pitchers}");
            Console.WriteLine("=============");
        }
    }
}
