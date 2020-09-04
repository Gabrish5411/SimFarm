using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Tiles;

namespace ConsoleApp
{
    public class MapAdmin
    {
        //Para cambiar colores:
        private ConsoleColor colorAgua = ConsoleColor.Blue;
        private ConsoleColor colorTierra = ConsoleColor.DarkGreen;
        public void Show(Tile[,] map)
        {
            for (int k = 0; k < 100; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (map[k, l].Get_tileName() == "T")
                    {
                        Console.BackgroundColor = colorTierra;
                        Console.Write(" ");
                    }
                    else if (map[k, l].Get_tileName() == "G")
                    {
                        if (map[k, l].Get_farmable())
                        {
                            Console.BackgroundColor = colorTierra;
                            Console.Write("G");
                        }
                        else
                        {
                            Console.BackgroundColor = colorAgua;
                            Console.Write("G");
                        }
                        
                    }
                    else if (map[k, l].Get_tileName() == "L" | map[k, l].Get_tileName() == "R")
                    {
                        Console.BackgroundColor = colorAgua;
                        Console.Write(" ");
                        
                    }
                    //Console.Write(map[k, l].quality);
                }
                Console.Write("\n");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
