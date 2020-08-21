using System;
using System.Collections;
namespace ConsoleApp
{
    class Terrain
    {
        public Tile[,] cell = new Tile[10, 10];
        private Random randNum = new Random();
        public Terrain()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cell[i, j] = new Tile(randNum);
                }

            }

        }

    }
}
