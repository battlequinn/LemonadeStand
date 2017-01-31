using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Inventory inventory;
        public Store store;
        public Player()
        {
            inventory = new Inventory();
        }
        public void BuyIngredients(int item, int amount, double expense)
        {
            inventory.supplies[item].Quantity += amount;
            inventory.Money -= expense;
        }
        public void RunLemonadeMenu(UserInterface ui)
        {
            ui.DisplayLemonadeMenu();
            int item = ChooseRecipeItem();
            int amountUsed = SetAmount();
            bool enoughItem = CheckAmount(inventory.supplies[item], amountUsed);
            if (enoughItem == true)
            {
                AddIngredient();
            }
        }
        private int ChooseRecipeItem()
        {
            Console.WriteLine("Which ingredient would you like to add?");
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine($"1) Lemons: {inventory.supplies[0].Quantity}");
                Console.WriteLine($"2) Sugar: {inventory.supplies[1].Quantity}");
                Console.WriteLine($"3) Ice: {inventory.supplies[2].Quantity}");
                Console.WriteLine("4) Leave");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2 || answer == 3 || answer == 4))
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
        public int SetAmount()
        {
            bool loop = true;
            int amount;
            do
            {
                Console.WriteLine("\nHow many? \n(Positive whole numbers only)");
                bool result = Int32.TryParse(Console.ReadLine(), out amount);
                if (result && amount >= 0 && amount <= 1000)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\nERROR: Unable to read input. Please enter a positive whole number.\n");
                }
            } while (loop == true);

            return amount;
        }
        private bool CheckAmount(Supplies item, int amountUsed)
        {
            bool enoughItem = false;
            if (item.Quantity >= amountUsed)
            {
                enoughItem = true;
            }
            return enoughItem;
        }
        private void AddIngredient()
        {

        }
    }
}
