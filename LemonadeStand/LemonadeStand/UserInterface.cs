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
            Console.WriteLine("Welcome to...\n\n(Press any key to continue)");
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

            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("\n-RULES-");
            Console.WriteLine("__________");
            Console.WriteLine("\nYou will have one week, a total of 7 days, to make as much money as you can by selling lemonade.");
            Console.WriteLine("\nAt the beginning of each day, the news will be displayed.");
            Console.WriteLine("     -It is in your best interest to pay attention to this so you can maximize your sales.");
            Console.WriteLine("\nYou will then have the chance to buy supplies at the store, make lemonade, and sell lemonade.");
            Console.WriteLine("     -In order to sell lemonade, you will need to make lemonade with bought supplies.");
            Console.WriteLine("\nYou have $20 to your name. Good luck!");
            Console.WriteLine("=====================================================================================================");
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
