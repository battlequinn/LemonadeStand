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
        public Player()
        {
            inventory = new Inventory();
        }


        public void BuyIngredients(int item, int amount, double expense)
        {
            inventory.supplies[item].Quantity += amount;
            inventory.Money -= expense;
        }
        public void SetRecipe()
        {
            int item;
            do
            {
                Console.Clear();
                item = ChooseRecipeItem();
                if (item != 4)
                {
                    int amountUsed = SetAmount();
                    AddIngredientToRecipe(item, amountUsed);
                }
            } while (item != 4);
        }
        public void MakeLemonade()
        {
            bool enoughSupplies = CheckSupplies();
            if (enoughSupplies == true)
            {
                int choice;
                do
                {
                    Console.Clear();
                    inventory.recipe.DisplayRecipe();
                    inventory.DisplayInventory();
                    choice = ChooseMakeLemonade();
                    if (choice != 2)
                    {
                        int confirmation = ConfirmPitcherAddition();
                        if (confirmation == 1)
                        {
                            MakePitcher();
                        }
                    }
                } while (choice != 2);
            }
            else
            {
                Console.WriteLine("You don't have enough supplies for that.");
                Console.ReadKey();
            }
        }
        private int ChooseRecipeItem()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Which ingredient would you like to add?");
            Console.WriteLine("\n-Adding Lemons increases sourness.");
            Console.WriteLine("-Adding Sugar increases sweetness.");
            Console.WriteLine("-Adding Ice decreases temperature.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
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
        private void AddIngredientToRecipe(int item, int amountUsed)
        {
            switch (item)
            {
                case 1:
                    inventory.recipe.Lemons = amountUsed;
                    break;
                case 2:
                    inventory.recipe.Sugar = amountUsed;
                    break;
                case 3:
                    inventory.recipe.Ice = amountUsed;
                    break;
                default:
                    Console.WriteLine("There was an error in processing your request.");
                    break;
            }
        }
        private bool CheckSupplies()
        {
            bool enoughSupplies = false;
            if (inventory.supplies[0].Quantity >= inventory.recipe.Lemons && inventory.supplies[1].Quantity >= inventory.recipe.Sugar &&
                inventory.supplies[2].Quantity >= inventory.recipe.Ice && inventory.supplies[4].Quantity >= 1)
            {
                enoughSupplies = true;
            }
            return enoughSupplies;
        }
        private int ChooseMakeLemonade()
        {
            Console.WriteLine("Make pitcher of lemonade?");
            bool loop = false;
            int answer;
            do
            {
                Console.WriteLine($"1) Yes");
                Console.WriteLine($"2) No");
                bool result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2))
                {
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
        private int ConfirmPitcherAddition()
        {
            int answer;
            bool result;
            Console.WriteLine("You are about to permanently submit these ingredients.\nAre you sure you want to complete this action?");
            do
            {
                Console.WriteLine("\n1) Yes 2) No");
                result = Int32.TryParse(Console.ReadLine(), out answer);
                if (result && (answer == 1 || answer == 2))
                {
                    result = true;
                }
                else
                {
                    Console.WriteLine("\nError: Incorrect entry. Please type in the numbers '1' or '2'.\n");
                    result = false;
                }
            } while (result == false);
            return answer;
        }
        private void MakePitcher()
        {
            inventory.supplies[0].Quantity -= inventory.recipe.Lemons;
            inventory.supplies[1].Quantity -= inventory.recipe.Sugar;
            inventory.supplies[2].Quantity -= inventory.recipe.Ice;
            inventory.supplies[4].Quantity -= 1;
            inventory.supplies[5].Quantity++;
        }
        public void SetStand()
        {
            double cupPrice = SetSellPrice();
        }
        private double SetSellPrice()
        {
            bool loop = true;
            double amount;
            do
            {
                Console.WriteLine("\nBefore we start, please set the price you would like to sell your cups of lemonade at.");
                bool result = Double.TryParse(Console.ReadLine(), out amount);
                if (result && amount >= 0 && amount <= 1000)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\nERROR: Unable to read input. Please enter a positive number.\n");
                }
            } while (loop == true);

            return amount;
        }
    }
}
