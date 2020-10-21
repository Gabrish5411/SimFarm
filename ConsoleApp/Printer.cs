using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Tiles;

namespace ConsoleApp
{
    public class Printer
    {
        //Para cambiar colores:
        private ConsoleColor colorAgua = ConsoleColor.Blue;
        private ConsoleColor colorTierra = ConsoleColor.DarkGreen;

        public void Show(Tile[,] map)
        {
            int i = 0;
            foreach (Tile casilla in map)
            {
                if (i == 100)
                {
                    Console.WriteLine("");
                    i = 0;
                }
                if (casilla.Get_tileName() == "T")
                {
                    Console.BackgroundColor = colorTierra;
                    Console.Write(" ");
                }
                else if (casilla.Get_tileName() == "G")
                {

                    if (casilla.Get_farmable())
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
                else if (casilla.Get_tileName() == "L" | casilla.Get_tileName() == "R")
                {
                    Console.BackgroundColor = colorAgua;
                    Console.Write(" ");

                }
                i++;
                //Console.Write(map[k, l].quality);
            }
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}