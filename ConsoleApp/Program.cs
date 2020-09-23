using ConsoleApp.Products;
using ConsoleApp.Buildings;
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
                    //Console.WriteLine(m1.map[0,99].Get_terrainNumber());
                    Console.WriteLine("¿Accept generated map?");
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
            /*
            foreach (Terrain elem in m1.terrains)
            {
                if (elem.Get_bought())
                {
                    Console.WriteLine(elem.earthNumber);
                }
            }
            */
            List<string> turn_options = new List<string>(new string[] { "Manage Farm", "Go to Market", "Pass turn", "Save Game" });
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
                        List<string> shop_options = new List<string>(new string[] { "Building Shop", "Consumable Shop", "Property Shop", "Price History", "Previous Menu" });
                        int selected_shop;
                        bool finished_1 = false;
                        while (!finished_1)
                        {
                            selected_shop = MenuManager.PrintMenu(shop_options);
                            if (selected_shop == 0)
                            {
                                List<string> building_shop_options = new List<string>(new string[] { "Buy Field", "Buy Cattle", "Buy Storage", "Sell/Destroy Building", "Previous Menu" });
                                int selected_building_shop;
                                bool finished_1_0 = false;
                                while (!finished_1_0)
                                {
                                    selected_building_shop = MenuManager.PrintMenu(building_shop_options);
                                    if (selected_building_shop == 4) //Menu Anterior
                                    {
                                        break;
                                    }
                                    else if (selected_building_shop == 0)
                                    {
                                        List<string> buying_field_options = new List<string>(new string[] { "Tomato", "Potato", "Rice", "Previous Menu"});
                                        int selected_field;
                                        bool finished_1_0_0 = false;
                                        while (!finished_1_0_0)
                                        {
                                            selected_field = MenuManager.PrintMenu(buying_field_options);
                                            if (selected_field == 3)
                                            {
                                                break;
                                            }
                                            else if (selected_field == 0)
                                            {
                                                
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);


                                                if (m1.terrains[sel_terrain].Get_bought())
                                                {
                                                    
                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    Seed selected_seed = new Seed();
                                                    selected_seed.Set_productName("Tomato");
                                                    m1.terrains[sel_terrain].Set_Building(new Field(m1.terrains, selected_seed));
                                                    Console.WriteLine(m1.terrains[sel_terrain].Get_Building().Get_product().Get_productName());
                                                    //m1.terrains[Convert.ToInt32(selected_terrain)].Get_Building().Get_product().Get_productName();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }
                                                
                                                //Game productPrice = new Game();
                                                //Console.WriteLine(selected_seed.Get_productName());
                                                //Console.WriteLine("The price for your selected item is: " + productPrice.Price());
                                                
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
                                    else if (selected_building_shop == 2)
                                    {
                                        List<string> buying_storage_options = new List<string>(new string[] { "Cattle Storage", "Seeds Storage" });
                                        int selected_storage;
                                        bool finished_1_0_2 = false;
                                        while (!finished_1_0_2)
                                        {
                                            selected_storage = MenuManager.PrintMenu(buying_storage_options);
                                        }

                                    }
                                    else if (selected_building_shop == 3)
                                    {
                                        Console.WriteLine("You can sell/destroy the following buildings:");
                                        Console.ReadLine();
                                    }
                                    

                                }
                            }
                            else if (selected_shop == 1)
                            {
                                bool finished_1_1 = false;
                                while (!finished_1_1)
                                {
                                    Console.WriteLine("You can buy the following consumables:");
                                    Console.ReadLine();
                                }
                            }
                            else if (selected_shop == 2)
                            {
                                bool finished_1_2 = false;
                                while (!finished_1_2)
                                {
                                    Console.WriteLine("You can buy the following properties:");
                                    
                                }
                            }
                            else if (selected_shop == 3)
                            {
                                bool finished_1_3 = false;
                                while (!finished_1_3)
                                {
                                    Console.WriteLine("The price history is the following:");
                                    Console.ReadLine();
                                }
                            }
                            else if (selected_shop == 4) //Menu Anterior
                            {
                                break;
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
