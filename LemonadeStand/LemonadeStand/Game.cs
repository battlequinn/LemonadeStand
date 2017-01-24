using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Game()
        {

        }
        UserInterface ui = new UserInterface();
        public void RunGame()
        {
            ui.Title();
        }
    }
}
