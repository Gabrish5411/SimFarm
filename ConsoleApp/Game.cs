using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Game
    {
        private int current_turn;
        private int current_money;
        public Game()
        {
            current_turn = 1;
            current_money = 50000;
        }

        public void UpdateGame() //Aqui actualizamos los precios y el current_money
        {
            current_turn += 1;
        }
    }
}
