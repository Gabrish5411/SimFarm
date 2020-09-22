using ConsoleApp.Products;
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
                        List<string> shop_options = new List<string>(new string[] { "Building Shop", "Consumable Shop", "Property Shop", "Price History" });
                        int selected_shop;
                        bool finished_1 = false;
                        while (!finished_1)
                        {
                            selected_shop = MenuManager.PrintMenu(shop_options);
                            if (selected_shop == 0)
                            {
                                List<string> building_shop_options = new List<string>(new string[] { "Buy Field", "Buy Cattle", "Buy Storage", "Sell/Destroy Building" });
                                int selected_building_shop;
                                bool finished_1_0 = false;
                                while (!finished_1_0)
                                {
                                    selected_building_shop = MenuManager.PrintMenu(building_shop_options);
                                    if (selected_building_shop == 0)
                                    {
                                        List<string> buying_field_options = new List<string>(new string[] { "Tomato", "Potato", "Rice" });
                                        int selected_field;
                                        bool finished_1_0_0 = false;
                                        while (!finished_1_0_0)
                                        {
                                            selected_field = MenuManager.PrintMenu(buying_field_options);
                                            if (selected_field == 0)
                                            {
                                                Product selected_seed = new Product();
                                                selected_seed.Set_productName("Tomato");
                                                Game productPrice = new Game();
                                                Console.WriteLine(selected_seed.Get_productName());
                                                Console.WriteLine("The price for your selected item is: " + productPrice.Price());
                                                
                                            }
                                        }



                                    }
                                    if (selected_building_shop == 1)
                                    {
                                        List<string> buying_cattle_options = new List<string>(new string[] { "Cow", "Sheep", "Pig" });
                                        int selected_cattle;
                                        bool finished_1_0_1 = false;
                                        while (!finished_1_0_1)
                                        {
                                            selected_cattle = MenuManager.PrintMenu(buying_cattle_options);
                                        }

                                    }
                                    if (selected_building_shop == 2)
                                    {
                                        List<string> buying_storage_options = new List<string>(new string[] { "Cattle Storage", "Seeds Storage" });
                                        int selected_storage;
                                        bool finished_1_0_2 = false;
                                        while (!finished_1_0_2)
                                        {
                                            selected_storage = MenuManager.PrintMenu(buying_storage_options);
                                        }

                                    }
                                    if (selected_building_shop == 3)
                                    {
                                        Console.WriteLine("You can sell/destroy the following buildings:");
                                        Console.ReadLine();
                                    }

                                }
                            }
                            if (selected_shop == 1)
                            {
                                bool finished_1_1 = false;
                                while (!finished_1_1)
                                {
                                    Console.WriteLine("You can buy the following consumables:");
                                    Console.ReadLine();
                                }
                            }
                            if (selected_shop == 2)
                            {
                                bool finished_1_2 = false;
                                while (!finished_1_2)
                                {
                                    Console.WriteLine("You can buy the following properties:");
                                    
                                }
                            }
                            if (selected_shop == 3)
                            {
                                bool finished_1_3 = false;
                                while (!finished_1_3)
                                {
                                    Console.WriteLine("The price history is the following:");
                                    Console.ReadLine();
                                }
                            }
                        }
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
