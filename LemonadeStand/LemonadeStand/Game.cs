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
        Player player = new Player();
        Store store = new Store();
        Random random = new Random();
        
        public Game()
        {
        }
        public void RunGame()
        {
            GenerateWeek();
            ui.Title(player.inventory.Money);
            for(int i = 0; i<7; i++)
            {
                RunDay(day[i]);
            }
        }
        private void RunDay(Day day)
        {
            Console.Clear();
            day.news.GetNews(day, this.day, random);
            Console.Clear();
            SetInitialSupplies();
            RunHome(day);
        }
        private void GenerateWeek()
        {
            for (int i = 0; i < 7; i++)
            {
                day.Add(new Day(i));

            }
        }
        private void SetInitialSupplies()
        {
            player.inventory.supplies.Add(new Supplies("lemons", 0.50, 0));
            player.inventory.supplies.Add(new Supplies("sugar(tbsp)", 0.10, 0));
            player.inventory.supplies.Add(new Supplies("ice(cubes)", 0.05, 0));
            player.inventory.supplies.Add(new Supplies("cups", 0.20, 0));
            player.inventory.supplies.Add(new Supplies("pitchers", 3.00, 0));
            player.inventory.supplies.Add(new Supplies("pitchers of lemonade", 0, 0));
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
                        day.news.GetNews(day, this.day, random);
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
