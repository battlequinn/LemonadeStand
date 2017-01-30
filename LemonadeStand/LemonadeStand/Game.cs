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
        List<Day> day = new List<Day>();
        Player player = new Player();
        Store store = new Store();
        News news = new News();
        
        public Game()
        {
        }
        public void RunGame()
        {
            ui.Title(player.inventory.Money);
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
            RunHome(day);
        }
        private void SetInitialSupplies()
        {
            player.inventory.supplies.Add(new Supplies("lemons", 0.50, 0));
            player.inventory.supplies.Add(new Supplies("sugar", 0.10, 0));
            player.inventory.supplies.Add(new Supplies("ice", 0.05, 0));
            player.inventory.supplies.Add(new Supplies("cups", 0.20, 0));
            player.inventory.supplies.Add(new Supplies("pitchers", 3.00, 0));
        }
        public void RunHome(Day day)
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
                        day.GetNews();
                        break;
                    case 3:
                        store.RunStore(player);
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
            } while (!(playerOption == 5 || playerOption == 6));
        }
        
    }
}
