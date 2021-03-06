﻿using System;
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
        public void DisplayTitle(double money)
        {
            Console.WriteLine("Welcome to...\n\n(Press any key to continue)");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                          *  *        ");
            Console.WriteLine("                       *       *          ");
            Console.WriteLine("                     *            *   **      ");
            Console.WriteLine("                        *  *  *    ***         ");
            Console.WriteLine("                              ***** * *     ");
            Console.WriteLine("                 ***************    *   *  ");
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
            Console.WriteLine("\nYou will then have the chance to check your inventory, read the news, buy supplies at the store, make lemonade, and sell lemonade.");
            Console.WriteLine("     -In order to sell lemonade, you will need to make lemonade with bought supplies.");
            Console.WriteLine($"\nYou have ${money} to your name. Good luck!");
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey();
        }
        public int DisplayHome()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Home");
            Console.WriteLine("\nHere you can check your inventory, read the news, make a trip to the store, and make lemonade.");
            Console.WriteLine("\nOnce you're finished, select the 'Set Up Stand' option to sell your lemonade and finish the day.");
            Console.WriteLine("=====================================================================================================");
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine("\n1) Check inventory 2) Read News 3) Go to store 4) Make Lemonade 5) Set Up Stand");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2 || answer == 3 || answer == 4 || answer == 5))
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
        public int DisplayMakeLemonadeMenu(Player player)
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("                                           LEMONADE MENU                                             ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Here you can create your recipe, submit your recipe, and make your lemonade for the day.");
            player.inventory.recipe.DisplayRecipe();
            Console.WriteLine("(1 pitcher sells 10 cups)");
            Console.WriteLine("(You must submit a recipe for the day before you make a pitcher of lemonade.)");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("=====================================================================================================\n");
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine("\n1) Write Recipe \n2) Submit Recipe \n3) Make Lemonade \n4) Leave");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2 || answer == 3 || answer == 4))
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
        public void RunMakeLemonadeMenu(Player player)
        {
            int choice;
            do
            {
                Console.Clear();
                choice = DisplayMakeLemonadeMenu(player);
                switch (choice)
                {
                    case 1:
                        if(player.inventory.recipe.Submit == false)
                        {
                            player.SetRecipe();
                        }else
                        {
                            Console.WriteLine("Sorry, you've already submitted your recipe for the day.");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        if (player.inventory.recipe.Submit == false)
                        {
                            player.SubmitRecipe();
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you've already submitted your recipe for the day.");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        if (player.inventory.recipe.Submit == true)
                        {
                            player.MakeLemonade();
                        }
                        else
                        {
                            Console.WriteLine("You must submit your recipe before you make lemonade.");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("There was an error in processing your request.");
                        Console.ReadKey();
                        break;
                }
            } while (choice != 4);
        }
        public void GetTotalMoneyCount(double initMoney, double finalMoney)
        {
            double totalMoney = finalMoney - initMoney;
            Console.ReadKey();
            Console.WriteLine($"${totalMoney}!");
            Console.ReadKey();
        }
    }
}
