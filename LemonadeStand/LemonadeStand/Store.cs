using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public void RunStore(Player player)
        {
            int choice;
            do
            {
                double playerMoney = player.inventory.Money;
                player.inventory.DisplayInventory();
                choice = DisplayStore(player.inventory.supplies);
                if (choice != 5)
                {
                    int amount = player.SetAmount();
                    double expense = GetExpense(choice, amount, player.inventory);
                    bool enoughMoney = DetermineEnoughMoney(expense, playerMoney);
                    if (enoughMoney == true)
                    {
                        int confirmation = ConfirmTransaction(expense, playerMoney);
                        if (confirmation == 1)
                        {
                            player.BuyIngredients(choice, amount, expense);
                            Console.WriteLine("Thank you for your shopping at The Dollar Lemon!");
                        }
                        else
                        {
                            Console.WriteLine("Okay, is there anything else you would like to buy?");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, you don't have enough money.\nThat costs ${expense}, and you only have ${playerMoney}.\nPlease lower your amount next time.");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            } while (choice != 5);
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Thank you for shopping at The Dollar Lemon. Come back soon!");
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey();
            Console.Clear();
        }
        private int DisplayStore(List<Supplies> supplies)
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Welcome to The Dollar Lemon! \n\nWhat would you like to buy?\n");
            Console.WriteLine("=====================================================================================================");
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine($"1) Lemons ${supplies[0].Price}");
                Console.WriteLine($"2) Sugar ${supplies[1].Price}");
                Console.WriteLine($"3) Ice ${supplies[2].Price}");
                Console.WriteLine($"4) Cups ${supplies[3].Price}" );
                Console.WriteLine($"5) Pitchers ${supplies[4].Price}");
                Console.WriteLine("6) Leave");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2 || answer == 3 || answer == 4 || answer == 5 || answer == 6))
                {
                    answer -= 1;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\nERROR: Unable to read input. Please type the number corresponding to your selection of choice.\n");
                    loop = true;
                }
            } while (loop == true);
            return answer;
        }
        private double GetExpense(int item, int amount, Inventory inventory)
        {
            double expense;
            double itemPrice = inventory.supplies[item].Price;
            expense = amount * itemPrice;
            return expense;
        }
        public bool DetermineEnoughMoney(double expense, double playerMoney)
        {
            bool enoughMoney = false;
            if(expense > playerMoney)
            {
                enoughMoney = false;
            }else
            {
                enoughMoney = true;
            }
            return enoughMoney;
        }
        private int ConfirmTransaction(double expense, double playerMoney)
        {
            int answer;
            bool result;
            Console.WriteLine($"\nTotal: ${expense}\nYour Money: ${playerMoney}\n");
            Console.WriteLine("Are you sure you want to make this transaction?");
            do
            {
                Console.WriteLine("\n1) Yes 2) No");
                result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2))
                {
                    result = true;
                }else
                {
                    Console.WriteLine("\nError: Incorrect entry. Please type in the numbers '1' or '2'.\n");
                    result = false;
                }
            } while (result == false);
            return answer;
        }
    }
}