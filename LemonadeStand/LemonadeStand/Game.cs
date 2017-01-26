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
        public Player player = new Player();
        public Day day = new Day();
        public Game()
        {
        }
        public void RunGame()
        {
            ui.Title();
            RunDay();
        }
        public void RunDay()
        {
            Console.Clear();
            GetDay();
            //GetNews();
            SetInitialSupplies();
            GetInventory();

        }
        private void SetInitialSupplies()
        {
            player.inventory.supplies.Add(new Supplies("lemons", 0, 0));
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
        private void GetDay()
        {
            int currentDay = day.Number;
            ui.DisplayDay(currentDay);
        }
        /*private void GetNews()
        {
            string overcast = weather.Overcast();
            int temp = weather.Temperature();
            string taste = taste.Taste();
            string randomEffect = randomEffect.RandomEffect();
            DisplayNews();
        }*/
    }
}
