﻿using System;

namespace ConsoleApp
{
    class Map
    {
        
        private Terrain[] cells = new Terrain[100];
        private Tile[,] map = new Tile[100, 100];
        public Map()
        {
            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Terrain();
            }
            Console.WriteLine("Mapa generado con exito.");

            //Aqui deberia ir el codigo para crear la matriz de 100x100 casillas (Tiles)

            
            
        }
        public void ShowMap1()
        {
            for(int F = 0; F < 100; F += 10)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write(cells[i+F].cell[z, j].tileName);
                        }
                    }
                    Console.Write("\n");
                }
            }
            
            
            
            
        }
    }
}
