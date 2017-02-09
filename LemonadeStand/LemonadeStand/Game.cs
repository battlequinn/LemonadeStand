using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        UserInterface ui = new UserInterface();
        List<Day> day = new List<Day>();
        public Player player = new Player();
        Store store = new Store();
        Random random = new Random();
        
        public Game()
        {
        }
        public void RunGame()
        {
            GenerateWeek();
            SetInitialSupplies();
            ui.DisplayTitle(player.inventory.Money);
            for(int i = 0; i<7; i++)
            {
                RunDay(day[i]);
            }
            Console.Clear();
            Console.WriteLine("And your total profits of the week are...");
            ui.GetTotalMoneyCount(25, player.inventory.Money);
        }
        private void RunDay(Day day)
        {
            Console.Clear();
            double initMoney = player.inventory.Money;
            day.news.GetNews(day, this.day, random);
            Console.Clear();
            RunHome(day);
            double finalMoney = player.inventory.Money;
            Console.Clear();
            Console.WriteLine("And your total profits today are...");
            ui.GetTotalMoneyCount(initMoney, finalMoney);
            Console.Clear();
            ResetForNextDay();
        }
        private void GenerateWeek()
        {
            for (int i = 0; i < 7; i++)
            {
                day.Add(new Day(i));
            }
        }
        public void SetInitialSupplies()
        {
            player.inventory.supplies.Add(new Supplies("Lemons", 0.30, 0));
            player.inventory.supplies.Add(new Supplies("Sugar(tbsp)", 0.10, 0));
            player.inventory.supplies.Add(new Supplies("Ice(cubes)", 0.05, 0));
            player.inventory.supplies.Add(new Supplies("Cups", 0.20, 0));
            player.inventory.supplies.Add(new Supplies("Pitchers", 3.00, 0));
            player.inventory.supplies.Add(new Supplies("Pitchers of Lemonade", 0, 0));
        }
        private void RunHome(Day day)
        {
            int playerOption;
            do
            {
                Console.Clear();
                playerOption = ui.DisplayHome();
                Console.Clear();
                switch (playerOption)
                {
                    case 1:
                        player.inventory.DisplayInventory();
                        Console.ReadKey();
                        break;
                    case 2:
                        day.news.GetNews(day, this.day, random);
                        break;
                    case 3:
                        store.RunStore(player);
                        break;
                    case 4:
                        ui.RunMakeLemonadeMenu(player);
                        break;
                    case 5:
                        player.SetStand(day, random);
                        break;
                    default:
                        Console.WriteLine("There was an error in processing your request.");
                        break;
                }
            } while (!(playerOption == 5 || playerOption == 6));
        }
        private void ResetForNextDay()
        {
            player.inventory.recipe.Submit = false;
            player.inventory.supplies[5].Quantity = 0;
        }
    }
}
