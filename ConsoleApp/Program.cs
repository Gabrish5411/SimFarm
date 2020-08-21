using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Map m1 = new Map();
            m1.ShowMap1();

            //Con terrain number podemos acceder a que terreno corresponde cada casilla Tile
            // Console.WriteLine(m1.map[9, 9].terrainNumber);


            Console.ReadLine();
        }


        
    }
}
