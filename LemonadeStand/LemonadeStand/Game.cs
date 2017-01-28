using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        UserInterface ui = new UserInterface();
        Player player = new Player();
        News news = new News();
        List<Day> day = new List<Day>();
        public Game()
        {
        }
        public void RunGame()
        {
            ui.Title();
            for(int i = 0; i<7; i++)
            {
                day.Add(new Day(i));
                RunDay(day[i]);
            }
        }
        private void RunDay(Day day)
        {
            Console.Clear();
            
            day.GetNews();
            Console.Clear();
            SetInitialSupplies();
            GetInventory();
            RunHome();
        }

        private void SetInitialSupplies()
        {
            player.inventory.supplies.Add(new Supplies("lemons", 0.50, 0));
            player.inventory.supplies.Add(new Supplies("sugar", 0, 0));
            player.inventory.supplies.Add(new Supplies("ice", 0, 0));
            player.inventory.supplies.Add(new Supplies("cups", 0, 0));
            player.inventory.supplies.Add(new Supplies("pitchers", 0, 0));
        }
        private void GetInventory()
        {
            double money = player.inventory.Money;
            int lemons = player.inventory.supplies[0].Quantity;
            int sugar = player.inventory.supplies[1].Quantity;
            int ice = player.inventory.supplies[2].Quantity;
            int cups = player.inventory.supplies[3].Quantity;
            int pitchers = player.inventory.supplies[4].Quantity;
            ui.DisplayInventory(money, lemons, sugar, ice, cups, pitchers);
        }
        public void RunHome()
        {
            int playerOption = ui.DisplayHome();
            switch (playerOption)
            {
                case 1:
                    GetInventory();
                    break;
                case 2:
                    
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:
                    
                    break;
                default:
                    Console.WriteLine("There was an error in processing your request.");
                    break;
            }
        }
        
    }
}
