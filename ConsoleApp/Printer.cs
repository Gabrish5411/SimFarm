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
        private readonly ConsoleColor colorAgua = ConsoleColor.Blue;
        private readonly ConsoleColor colorTierra = ConsoleColor.DarkGreen;
        private readonly ConsoleColor colorGranja = ConsoleColor.Green;
        private readonly ConsoleColor colorField = ConsoleColor.DarkMagenta;
        private readonly ConsoleColor colorCattle = ConsoleColor.DarkYellow;
        private readonly ConsoleColor colorStorage = ConsoleColor.DarkGray;

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
                        Console.BackgroundColor = colorGranja;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.BackgroundColor = colorAgua;
                        Console.Write("~");
                    }

                }
                else if (casilla.Get_tileName() == "Field")
                {
                    if (casilla.Get_farmable())
                    {
                        Console.BackgroundColor = colorField;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.BackgroundColor = colorAgua;
                        Console.Write("~");
                    }
                }
                else if (casilla.Get_tileName() == "Cattle")
                {
                    if (casilla.Get_farmable())
                    {
                        Console.BackgroundColor = colorCattle;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.BackgroundColor = colorAgua;
                        Console.Write("~");
                    }
                }
                else if (casilla.Get_tileName() == "Storage")
                {
                    if (casilla.Get_farmable())
                    {
                        Console.BackgroundColor = colorStorage;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.BackgroundColor = colorAgua;
                        Console.Write("~");
                    }
                }
                else if (casilla.Get_tileName() == "L" | casilla.Get_tileName() == "R")
                {
                    Console.BackgroundColor = colorAgua;
                    Console.Write("~");

                }
                i++;
                //Console.Write(map[k, l].quality);
            }
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}