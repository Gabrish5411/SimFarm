using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class MenuManager
    {
        static int selected;
        static int i = 0;
        public static int PrintMenu(List<string> options)
        {
            foreach (string elem in options)
            {
                Console.Write("[{0}] {1}\n", i, elem);
                i++;
            }
            Console.Write("\nChoose an option...");
            selected = Convert.ToInt32(Console.ReadLine());
            while (!Enumerable.Range(0, i).Contains(selected))
            {
                Console.Write("Please select a valid option: ");
                selected = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            return selected;
        }
    }
}
