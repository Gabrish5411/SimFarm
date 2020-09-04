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
            Map m1 = new Map();
            MapAdmin printer = new MapAdmin();
            printer.Show(m1.map);
            
            //Con terrain number podemos acceder a que terreno corresponde cada casilla Tile
            //Console.WriteLine(m1.map[99, 99].Get_terrainNumber());

            Console.ReadLine();
        }


        
    }
}
