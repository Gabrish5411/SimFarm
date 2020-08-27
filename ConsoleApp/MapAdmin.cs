using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class MapAdmin
    {
        public void Show(Tile[,] map)
        {
            for (int k = 0; k < 100; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (map[k, l].Get_tileName() == "T")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (map[k, l].Get_tileName() == "G")
                    {
                        if (map[k, l].farmable)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write("G");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("G");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        
                    }
                    else if (map[k, l].Get_tileName() == "L" | map[k, l].Get_tileName() == "R")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    //Console.Write(map[k, l].quality);
                }
                Console.Write("\n");
            }



        }
    }
}
