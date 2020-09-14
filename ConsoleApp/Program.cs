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
            MapAdmin printer = new MapAdmin();
            Game game;
            Map m1;
            //MenuManager menuAd = new MenuManager();

            List<string> main_options = new List<string>(new string[] { "New Game", "Load Game" });
            List<string> yes_no = new List<string>(new string[] { "Yes", "No" });
            int selected, selected2;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("SimFarm Menu");
                selected = MenuManager.PrintMenu(main_options);
                if (selected == 0)
                {
                    Console.Clear();
                    m1 = new Map();
                    printer.Show(m1.map);
                    Console.WriteLine("¿Aceptar mapa generado?");
                    selected2 = MenuManager.PrintMenu(yes_no);
                    if (selected2 == 0)
                    {
                        game = new Game();
                        break;
                    }
                    else
                    {
                        
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Loading not yet implemented...");
                    Console.ReadLine();

                }
            }

            List<string> turn_options = new List<string>(new string[] { "Administrar granja", "Ir a mercado", "Pasar turno", "Grabar partida" });
            int selected_turn;
            bool finished = false;
            while (!finished)
            {
                selected_turn = MenuManager.PrintMenu(turn_options);
                switch (selected_turn)
                {
                    case 0: //No es necesario para esta entrega
                        break;
                    case 1: //Mercado
                        break;
                    case 2:
                        Console.WriteLine("Turno pasado...");
                        Console.ReadKey();
                        Console.Clear();
                        printer.Show(m1.map);
                        break;
                    case 3: //No hay cargar partida asique creo que tampoco hay que guardar (Por ahora sirve para cerrar el juego)
                        finished = true;
                        break;

                }
                
            }
            Console.WriteLine("Fin del juego...");
            
            //Con terrain number podemos acceder a que terreno corresponde cada casilla Tile
            //Console.WriteLine(m1.map[99, 99].Get_terrainNumber());

            Console.ReadLine();
        }


        
    }
}
