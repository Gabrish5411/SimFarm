using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class MapAdmin
    {
        public void Show(Tile[,] map)
        {
            for (int k = 0; k < 100; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    Console.Write(map[k, l].tileName);
                    //Console.Write(map[k, l].quality);
                }
                Console.Write("\n");
            }



        }
    }
}
