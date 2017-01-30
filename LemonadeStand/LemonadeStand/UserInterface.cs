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
        public void Title(double money)
        {
            Console.WriteLine("Welcome to...\n\n(Press any key to continue)");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ResetColor();

            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("\n-RULES-");
            Console.WriteLine("__________");
            Console.WriteLine("\nYou will have one week, a total of 7 days, to make as much money as you can by selling lemonade.");
            Console.WriteLine("\nAt the beginning of each day, the news will be displayed.");
            Console.WriteLine("     -It is in your best interest to pay attention to this so you can maximize your sales.");
            Console.WriteLine("\nYou will then have the chance to buy supplies at the store, change your recipe, make lemonade, and sell lemonade.");
            Console.WriteLine("     -In order to sell lemonade, you will need to make lemonade with bought supplies.");
            Console.WriteLine($"\nYou have ${money} to your name. Good luck!");
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey();
        }
        public int DisplayHome()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Home");
            Console.WriteLine("\nHere you can check your inventory, make a trip to the store, prepare your recipe, and make lemonade.");
            Console.WriteLine("\nOnce you're finished, select the 'Set Up Stand' option to sell your lemonade and finish the day.");
            Console.WriteLine("\nIf you wish you may select the retire button to quit.");
            Console.WriteLine("=====================================================================================================");
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine("\n1) Check inventory 2) Read News 3) Go to store 4) Make Lemonade 5) Set Up Stand 6) Retire");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2 || answer == 3 || answer == 4 || answer == 5 || answer == 6))
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("ERROR: Unable to read input. Please type the number corresponding to your selection of choice.");
                    loop = true;
                }
            } while (loop == true);
            return answer;
        }
    }
}
