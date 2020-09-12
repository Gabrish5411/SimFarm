using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MapAdmin printer = new MapAdmin();
            //MenuManager menuAd = new MenuManager();

            List<string> main_options = new List<string>(new string[] { "New Game","Load Game" });
            int selected;

            Console.WriteLine("SimFarm Menu");
            selected = MenuManager.PrintMenu(main_options);

            if (selected == 0)
            {
                Map m1 = new Map();
                printer.Show(m1.map);
            }
            else
            {
                Console.WriteLine("Loading not yet implemented, exiting...");
            }
            //Console.WriteLine("");
            
            
            //Con terrain number podemos acceder a que terreno corresponde cada casilla Tile
            //Console.WriteLine(m1.map[99, 99].Get_terrainNumber());

            Console.ReadLine();
        }


        
    }
}
