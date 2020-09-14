using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class MenuManager
    {
        static string selected;
        static int number;
        static int i = 0;
        public static int PrintMenu(List<string> options)
        {
            foreach (string elem in options)
            {
                Console.Write("[{0}] {1}\n", i, elem);
                i++;
            }
            Console.Write("\nChoose an option...");
            selected = Console.ReadLine();
            number = -1;
            if (Int32.TryParse(selected, out number))
            {
                number = Convert.ToInt32(selected);
            }
            else
            {
                number = -1;
                //Mientras no se acepte el numero (Loop infinito):
                while (!Enumerable.Range(0, i).Contains(number)) 
                {
                    Console.Write("Please select a valid option: ");
                    selected = Console.ReadLine();
                    if (Int32.TryParse(selected, out number))
                    {
                        //Se entrego un numero dentro del menu (Tampoco es una letra)
                        number = Convert.ToInt32(selected);
                    }
                    else
                    {
                        //Intentar denuevo
                        number = -1;
                        continue;
                    }
                }
            }
            //Console.Clear();

            i = 0;
            return number;
        }
    }
}
