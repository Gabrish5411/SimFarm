using ConsoleApp.Products;
using ConsoleApp.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Consumables;
using ConsoleApp.Tiles;
using ConsoleApp.Products.Seeds;
using ConsoleApp.Products.Animals;
using System.Net.Http.Headers;

namespace ConsoleApp
{
    class Program
    {


        static void Main(string[] args)
        {
            Random randNum = new Random();
            Building building;
            string building_name;
            Printer printer = new Printer();
            Game game;
            Map map; 
            //MenuManager menuAd = new MenuManager();

            
            List<string> main_options = new List<string>(new string[] { "New Game", "Load Game" });
            List<string> yes_no = new List<string>(new string[] { "Yes", "No" });
            int selected, selected2;

            while (true)
            {
                Console.Clear();

                /*  //Bloque para testear Storage
                Storage store = new Storage();
                store.AddProduct(new FinishedProduct("Cows"));
                store.ReportStorageStatus();
                */

                Console.WriteLine("SimFarm Menu");
                selected = MenuManager.PrintMenu(main_options);
                if (selected == 0)
                {
                    map = new Map();
                    printer.Show(map.map);
                    Console.WriteLine("¿Accept generated map?");
                    selected2 = MenuManager.PrintMenu(yes_no);
                    if (selected2 == 0)
                    {
                        game = new Game();
                        game.Map = map;
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

            List<string> turn_options = new List<string>(new string[] { "Manage Farm", "Go to Market", "Pass turn", "Save Game" });
            int selected_turn;
            bool finished = false;
            while (!finished)                        //Inicio Juego
            {
                Console.Clear();
                printer.Show(game.Map.map);
                selected_turn = MenuManager.PrintMenu(turn_options);
                switch (selected_turn)
                {
                    case 0: //Administrar granja
                        
                        List<string> farm_options = new List<string>(new string[] { "Manage Production", "Manage Storage", "Previous Menu" });
                        int selected_option;
                        bool finished_2 = false;
                        while (!finished_2)
                        {
                            Console.Clear();
                            game.GetPlayer().ReportInventory();
                            selected_option = MenuManager.PrintMenu(farm_options);
                            if (selected_option == 0) //Administrar Produccion
                            {
                                List<string> production_options = new List<string>(new string[] { "Supply Water/Food", "Apply Heal", "Get Finished Products", "Previous Menu" });
                                int selected_production;
                                bool finished_21 = false;
                                while (!finished_21)
                                {
                                    game.Map.Print_Farm_and_type();
                                    Console.WriteLine("Select what terrain you want to manage");
                                    string selected_terrain = Console.ReadLine();
                                    int sel_terrain = Convert.ToInt32(selected_terrain);
                                    if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "fld" || game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "cttl")
                                    {
                                        game.Map.terrains[sel_terrain - 1].Get_Building().Report();
                                        selected_production = MenuManager.PrintMenu(production_options);
                                        if (selected_production == 0) //Agregar agua o comida
                                        {
                                            List<string> feedwater_options = new List<string>(new string[] { "Supply Water", "Supply Food", "Previous Menu" });
                                            int selected_feedwater;
                                            bool finished_22 = false;
                                            while (!finished_22)
                                            {
                                                if (game.Map.terrains[sel_terrain - 1].Get_bought() && game.Map.terrains[sel_terrain - 1].Get_Building() != null)
                                                {
                                                    if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "fld")
                                                    {
                                                        selected_feedwater = MenuManager.PrintMenu(feedwater_options);
                                                        if (selected_feedwater == 0)
                                                        {
                                                            game.GetPlayer().irrigation.Use((Field)game.Map.terrains[sel_terrain - 1].Get_Building());
                                                            Console.WriteLine("Irrigation applied to terrain number " + selected_terrain);
                                                        }
                                                        else if (selected_feedwater == 1)
                                                        {
                                                            game.GetPlayer().fertilizer.Use((Field)game.Map.terrains[sel_terrain - 1].Get_Building());
                                                            Console.WriteLine("Fertilizer applied to terrain number " + selected_terrain);
                                                        }
                                                        else continue;
                                                    }
                                                    else if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "cttl")
                                                    {
                                                        selected_feedwater = MenuManager.PrintMenu(feedwater_options);
                                                        if (selected_feedwater == 0)
                                                        {
                                                            game.GetPlayer().animalWater.Use((Cattle)game.Map.terrains[sel_terrain - 1].Get_Building());
                                                            Console.WriteLine("Animal Water applied to terrain number " + selected_terrain);
                                                        }
                                                        else if (selected_feedwater == 1)
                                                        {
                                                            game.GetPlayer().animalFood.Use((Cattle)game.Map.terrains[sel_terrain - 1].Get_Building());
                                                            Console.WriteLine("Animal Food applied to terrain number " + selected_terrain);
                                                        }
                                                        else continue;
                                                    }
                                                }
                                            }
                                        }
                                        else if (selected_production == 1) // Aplicar cura
                                        {
                                            List<string> cure_options_field = new List<string>(new string[] { "Supply Pesticide", "Supply Herbicide", "Supply Fungicide", "Previous Menu" });
                                            List<string> cure_options_cattle = new List<string>(new string[] { "Supply Vaccine", "Previous Menu" });
                                            int selected_cure;
                                            bool finished_23 = false;
                                            while (!finished_23)
                                            {
                                                if (game.Map.terrains[sel_terrain - 1].Get_bought() && game.Map.terrains[sel_terrain - 1].Get_Building() != null)
                                                {
                                                    if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "fld")
                                                    {
                                                        Field field = (Field)game.Map.terrains[sel_terrain - 1].Get_Building();
                                                        field.Report();
                                                        selected_cure = MenuManager.PrintMenu(cure_options_field);
                                                        if (selected_cure == 0)
                                                        {
                                                            game.GetPlayer().pesticide.Use(field, randNum);
                                                            Console.WriteLine("Pesticide applied to terrain number " + selected_terrain);
                                                        }
                                                        else if (selected_cure == 1)
                                                        {
                                                            game.GetPlayer().herbicide.Use(field, randNum);
                                                            Console.WriteLine("Herbicide applied to terrain number " + selected_terrain);

                                                        }
                                                        else if (selected_cure == 2)
                                                        {
                                                            game.GetPlayer().fungicide.Use(field, randNum);
                                                            Console.WriteLine("Fungicide applied to terrain number " + selected_terrain);

                                                        }
                                                        else if (selected_cure == 3)
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    else if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "cttl")
                                                    {
                                                        Cattle cattle = (Cattle)game.Map.terrains[sel_terrain - 1].Get_Building();
                                                        cattle.Report();
                                                        selected_cure = MenuManager.PrintMenu(cure_options_cattle);
                                                        if (selected_cure == 0)
                                                        {
                                                            game.GetPlayer().vaccine.Use(cattle, randNum);
                                                            Console.WriteLine("Vaccine applied to terrain number " + selected_terrain);
                                                        }
                                                        else if (selected_cure == 1)
                                                        {
                                                            break;
                                                        }
                                                    }
                                                }

                                            }
                                        }
                                        else if (selected_production == 2)
                                        {
                                            
                                            if (game.Map.terrains[sel_terrain - 1].Get_bought() && game.Map.terrains[sel_terrain - 1].Get_Building() != null) //agregar que almacentamientos no estan llenos
                                            {
                                                if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "fld")
                                                {
                                                    Field field = (Field)game.Map.terrains[sel_terrain - 1].Get_Building();
                                                    if (field.IsReady()) //Producto esta maduro
                                                    {
                                                        string obj_name = field.Get_product().Get_productName();
                                                        foreach (Terrain terr in game.Map.terrains)//Buscar un almacen
                                                        {
                                                            if (terr.Get_Building() != null) //Donde haya un edificio
                                                            {
                                                                if (terr.Get_Building().Get_type() == "strg" && terr.Get_Building().Get_product().Get_productName() == obj_name)
                                                                {
                                                                    Storage store = (Storage)terr.Get_Building();
                                                                    if (!store.IsFull())
                                                                    {
                                                                        store.AddProduct(new FinishedProduct(obj_name)); //Agregar el producto al almacen 
                                                                        Console.WriteLine("The product has been added to a storage.");
                                                                        break;
                                                                    }
                                                                }
                                                                else if (terr.Get_Building().Get_type() == "strg")
                                                                {
                                                                    Storage store = (Storage)terr.Get_Building();
                                                                    if (store.GetCurrentProduct() == "Empty")//Agregar el producto al almacen vacio
                                                                    {
                                                                        store.AddProduct(new FinishedProduct(obj_name));
                                                                        Console.WriteLine("The product has been added to an empty storage.");
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        break;
                                                        
                                                    }
                                                    else //Producto no esta maduro
                                                    {
                                                        Console.WriteLine("The selected field is not ready for harvest");
                                                    }
                                                }
                                                else if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "cttl")
                                                {
                                                    Cattle cattle = (Cattle)game.Map.terrains[sel_terrain - 1].Get_Building();
                                                    if (cattle.IsReady()) //Producto esta maduro
                                                    {
                                                        string obj_name = cattle.Get_product().Get_productName();
                                                        foreach (Terrain terr in game.Map.terrains)//Buscar un almacen
                                                        {
                                                            if (terr.Get_Building() != null) //Donde haya un edificio
                                                            {
                                                                if (terr.Get_Building().Get_type() == "strg" && terr.Get_Building().Get_product().Get_productName() == obj_name)
                                                                {
                                                                    Storage store = (Storage)terr.Get_Building();
                                                                    if (!store.IsFull())
                                                                    {
                                                                        store.AddProduct(new FinishedProduct(obj_name)); //Agregar el producto al almacen 
                                                                        Console.WriteLine("The product has been added to a storage.");
                                                                        break;
                                                                    }
                                                                }
                                                                else if (terr.Get_Building().Get_type() == "strg")
                                                                {
                                                                    Storage store = (Storage)terr.Get_Building();
                                                                    if (store.GetCurrentProduct() == "Empty")//Agregar el producto al almacen vacio
                                                                    {
                                                                        store.AddProduct(new FinishedProduct(obj_name));
                                                                        Console.WriteLine("The product has been added to an empty storage.");
                                                                        break;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                        break;
                                                    }
                                                    else //Producto no esta maduro
                                                    {
                                                        Console.WriteLine("The selected field is not ready for harvest");
                                                        break;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Selected building is invalid.");
                                            }
                                            
                                        }
                                        else if (selected_production == 3)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                            else if (selected_option == 1) //Administrar Almacenamiento
                            {
                                Console.WriteLine("Products in storage ");
                                game.Map.Print_Farm_and_type();
                                string selected_terrain = Console.ReadLine();
                                int sel_terrain = Convert.ToInt32(selected_terrain);
                                bool finished_25 = false;
                                while (!finished_25)
                                {
                                    if (game.Map.terrains[sel_terrain - 1].Get_bought() && game.Map.terrains[sel_terrain - 1].Get_Building() != null)
                                    {
                                        if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "strg")
                                        {
                                            Storage stora = (Storage)game.Map.terrains[sel_terrain - 1].Get_Building();
                                            stora.Report(); //Muestra la informacion del almacen
                                            List<string> sell_options = new List<string>(new string[] { "Sell Products", "Previous Menu" }); //Da la opcion de vender
                                            int selected_sell = MenuManager.PrintMenu(sell_options);
                                            if (selected_sell == 0)
                                            {
                                                stora.SellProducts(game);
                                            }
                                            else
                                            {
                                                break;
                                            }  
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else //Menu anterior
                            {
                                break;
                            }
                        }
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
                                    
                                    if (selected_building_shop == 0)
                                    {
                                        
                                        List<string> buying_field_options = new List<string>(new string[] { "Tomato", "Potato", "Rice", "Previous Menu" });
                                        int selected_field;
                                        bool finished_1_0_0 = false;
                                        //building.buyPrice = 20000;
                                        while (!finished_1_0_0)
                                        {
                                            selected_field = MenuManager.PrintMenu(buying_field_options);
                                            if (selected_field == 3)
                                            {
                                                break;
                                            }
                                            else if (selected_field == 0)
                                            {
                                                
                                                building_name = "Tomato Field";
                                                Tomato tomato = new Tomato();
                                                building = new Field(game.Map.terrains, tomato);
                                                Console.WriteLine("The price of a " + building_name + " is " + building.buyPrice + tomato.Get_buyPrice());
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= building.buyPrice + tomato.Get_buyPrice())
                                                {
                                                    game.GetPlayer().Current_money -= building.buyPrice + tomato.Get_buyPrice();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy a " + building_name );
                                                    break;
                                                }

                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {

                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine("Thanks for buying a " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }

                                            }
                                            else if (selected_field == 1)
                                            {

                                                building_name = "Potato Field";
                                                Potato potato = new Potato();
                                                building = new Field(game.Map.terrains, potato);
                                                Console.WriteLine("The price of a " + building_name + " is " + building.buyPrice + potato.Get_buyPrice());
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= building.buyPrice + potato.Get_buyPrice())
                                                {
                                                   
                                                    game.GetPlayer().Current_money -= building.buyPrice + potato.Get_buyPrice();


                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy a" + building_name);
                                                    break;
                                                }



                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {

                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine("Thanks for buying a " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }

                                            }

                                            else if (selected_field == 2)
                                            {

                                                building_name = "Rice Field";
                                                Rice rice = new Rice();
                                                building = new Field(game.Map.terrains, rice);
                                                Console.WriteLine("The price of a " + building_name + " is " + building.buyPrice + rice.Get_buyPrice());
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= building.buyPrice + rice.Get_buyPrice())
                                                {
                                                    
                                                    game.GetPlayer().Current_money -= building.buyPrice + rice.Get_buyPrice();

                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy a" + building_name);
                                                    break;
                                                }



                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {

                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine("Thanks for buying a " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }


                                            }


                                        }
                                    }
                                    if (selected_building_shop == 1)
                                    {
                                        List<string> buying_cattle_options = new List<string>(new string[] { "Cow", "Sheep", "Pig", "Previous Menu" });
                                        int selected_cattle;
                                        bool finished_1_0_1 = false;
                                        while (!finished_1_0_1)
                                        {
                                            selected_cattle = MenuManager.PrintMenu(buying_cattle_options);
                                            if (selected_cattle == 3)
                                            {
                                                break;
                                            }
                                            else if (selected_cattle == 0)
                                            {

                                                building_name = "Cow Cattle";
                                                Cow cow = new Cow();
                                                building = new Cattle(game.Map.terrains, cow);
                                                Console.WriteLine("The price of a " + building_name + " is " + building.buyPrice + cow.Get_buyPrice());
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= building.buyPrice + cow.Get_buyPrice())
                                                {

                                                    game.GetPlayer().Current_money -= building.buyPrice + cow.Get_buyPrice();


                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy " + building_name);
                                                    break;
                                                }



                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {

                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine("Thanks for buying " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }


                                            }
                                            else if (selected_cattle == 1)
                                            {

                                                building_name = "Sheep Cattle";
                                                Sheep sheep = new Sheep();
                                                building = new Cattle(game.Map.terrains, sheep);
                                                Console.WriteLine("The price of a " + building_name + " is " + building.buyPrice + sheep.Get_buyPrice());
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= building.buyPrice + sheep.Get_buyPrice())
                                                {

                                                    game.GetPlayer().Current_money -= building.buyPrice + sheep.Get_buyPrice();


                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy " + building_name);
                                                    break;
                                                }



                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {

                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine("Thanks for buying  " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }


                                            }

                                            else if (selected_cattle == 2)
                                            {

                                                building_name = "Pig Cattle";
                                                Pig pig = new Pig();
                                                building = new Cattle(game.Map.terrains, pig);
                                                Console.WriteLine("The price of " + building_name + " is " + building.buyPrice + pig.Get_buyPrice());
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= building.buyPrice + pig.Get_buyPrice())
                                                {

                                                    game.GetPlayer().Current_money -= building.buyPrice + pig.Get_buyPrice();

                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy " + building_name);
                                                    break;
                                                }



                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {

                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine(game.Map.terrains[sel_terrain].Get_Building().Get_product().Get_productName());
                                                    Console.WriteLine("Thanks for buying a " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }

                                            }


                                        }

                                    }
                                    else if (selected_building_shop == 2)  //Comprar Almacen
                                    {
                                        List<string> buying_storage_options = new List<string>(new string[] { "Cattle Storage", "Seeds Storage", "Previous Menu" });
                                        int selected_storage;
                                        bool finished_1_0_2 = false;
                                        
                                        while (!finished_1_0_2)
                                        {
                                            selected_storage = MenuManager.PrintMenu(buying_storage_options);
                                            if (selected_storage == 2)
                                            {
                                                break;
                                            }
                                            else if (selected_storage == 0)
                                            {

                                                building_name = "Cattle Storage";
                                                building = new Storage();
                                                Console.WriteLine("The price of " + building_name + " is " + building.buyPrice);
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= 10000)
                                                {

                                                    game.GetPlayer().Current_money -= 10000;


                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy " + building_name);
                                                    break;
                                                }



                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {
                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine("Thanks for buying " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }

                                            }
                                            else if (selected_storage == 1)
                                            {

                                                building_name = "Seeds Storage";
                                                building = new Storage();
                                                Console.WriteLine("The price of " + building_name + " is " + building.buyPrice);
                                                game.Map.Print_Farm();
                                                Console.WriteLine("Select a terrain in which it will be built: ");
                                                string selected_terrain = Console.ReadLine();
                                                int sel_terrain = Convert.ToInt32(selected_terrain);

                                                if (game.GetPlayer().Current_money >= building.buyPrice)
                                                {

                                                    game.GetPlayer().Current_money -= building.buyPrice;


                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy " + building_name);
                                                    break;
                                                }



                                                if (game.Map.terrains[sel_terrain - 1].Get_bought())
                                                {

                                                    //Se crea el edificio y el producto asociado en el terreno seleccionado
                                                    game.Map.terrains[sel_terrain].Set_Building(building);
                                                    Console.WriteLine("Thanks for buying  " + building_name);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The selected terrain is invalid.");
                                                }

                                            }


                                        }

                                    }
                                    else if (selected_building_shop == 3)
                                    {
                                        Console.WriteLine("You can sell/destroy the following buildings:");
                                        game.Map.Print_Farm_and_type();
                                        string selected_terrain = Console.ReadLine();
                                        int sel_terrain = Convert.ToInt32(selected_terrain); 
                                        bool finished_1_0_3 = false;

                                        while (!finished_1_0_3)
                                        {
                                            if (game.Map.terrains[sel_terrain - 1].Get_bought() && game.Map.terrains[sel_terrain - 1].Get_Building() != null)
                                            {
                                                if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "fld")
                                                {
                                                    if (game.GetPlayer().Current_money > game.Map.terrains[sel_terrain - 1].Get_Building().Get_sell())
                                                    {
                                                        game.GetPlayer().Current_money -= game.Map.terrains[sel_terrain - 1].Get_Building().Get_sell();
                                                        game.Map.terrains[sel_terrain - 1].Set_Building(null);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("You don't have enough money");
                                                    }
                                                }
                                                else if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "cttle")
                                                {
                                                    if (game.GetPlayer().Current_money > game.Map.terrains[sel_terrain - 1].Get_Building().Get_sell())
                                                    {
                                                        game.GetPlayer().Current_money -= game.Map.terrains[sel_terrain - 1].Get_Building().Get_sell();
                                                        game.Map.terrains[sel_terrain - 1].Set_Building(null);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("You don't have enough money");
                                                    }
                                                }
                                                else if (game.Map.terrains[sel_terrain - 1].Get_Building().Get_type() == "strg")  
                                                {
                                                    Storage storage = (Storage)game.Map.terrains[sel_terrain - 1].Get_Building();
                                                    foreach (FinishedProduct prod in storage.GetFinished()) 
                                                    {
                                                        int sell;
                                                        int quality;
                                                        sell = prod.Get_sellPrice();
                                                        quality = prod.Get_product_quality();
                                                        game.GetPlayer().Current_money += sell * quality;
                                                    }
                                                    game.GetPlayer().Current_money += game.Map.terrains[sel_terrain - 1].Get_Building().sellPrice;
                                                    game.Map.terrains[sel_terrain - 1].Set_Building(null);
                                                }
                                            }
                                            Console.ReadLine();
                                        }
                                    }
                                    else if (selected_building_shop == 4) //Menu Anterior
                                    {
                                        
                                        break;
                                    }


                                }
                            }
                            else if (selected_shop == 1)  //CONSUMABLES
                            {
                                Console.WriteLine("You can buy the following consumables:");
                                List<string> buying_consumable_options = new List<string>(new string[] { "Food", "Medication", "Previous Menu" });
                                int selected_consumable;
                                bool finished_1_1_0 = false;
                                while (!finished_1_1_0)
                                {
                                    selected_consumable = MenuManager.PrintMenu(buying_consumable_options);
                                    if (selected_consumable == 2) //Menu Anterior
                                    {
                                        break;
                                    }
                                    else if (selected_consumable == 0)
                                    {

                                        List<string> buying_food_options = new List<string>(new string[] { "Fertilizer", "Irrigation", "Animal Food", "Animal Water", "Previous Menu" });
                                        int selected_food;
                                        bool finished_1_1_1 = false;
                                        while (!finished_1_1_1)
                                        {
                                            selected_food = MenuManager.PrintMenu(buying_food_options);
                                            if (selected_food == 4) //Menu Anterior
                                            {
                                                break;
                                            }
                                            else if (selected_food == 0)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().fertilizer.GetBuyPrice())
                                                {
                                                    game.GetPlayer().fertilizer.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().fertilizer.GetBuyPrice();
                                                    Console.WriteLine("Thanks for buying a Fertilizer! Fertilizer uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy a Fertilizer");
                                                    break;
                                                }
                                            }
                                            else if (selected_food == 1)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().irrigation.GetBuyPrice())
                                                {
                                                    game.GetPlayer().irrigation.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().irrigation.GetBuyPrice();
                                                    Console.WriteLine("Thanks for buying Irrigation! Irrigation uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy Irrigation");
                                                    break;
                                                }
                                            }
                                            else if (selected_food == 2)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().animalFood.GetBuyPrice())
                                                {
                                                    game.GetPlayer().animalFood.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().animalFood.GetBuyPrice();
                                                    Console.WriteLine("Thanks for buying Animal Food! Animal Food uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy Animal Food");
                                                    break;
                                                }
                                            }
                                            else if (selected_food == 3)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().animalWater.GetBuyPrice())
                                                {
                                                    game.GetPlayer().animalWater.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().animalWater.GetBuyPrice();
                                                    Console.WriteLine("Thanks for buying Animal Water! Animal Water uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy Animal Water");
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    else if (selected_consumable == 1)
                                    {
                                        List<string> buying_medication_options = new List<string>(new string[] { "Fungicide", "Herbicide", "Pesticide", "Vaccine", "Previous Menu" });
                                        int selected_medication;
                                        bool finished_1_1_2 = false;
                                        while (!finished_1_1_2)
                                        {
                                            selected_medication = MenuManager.PrintMenu(buying_medication_options);
                                            if (selected_medication == 4) //Menu Anterior
                                            {
                                                break;
                                            }
                                            else if (selected_medication == 0)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().fungicide.GetBuyPrice())
                                                {
                                                    game.GetPlayer().fungicide.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().fungicide.GetBuyPrice();
                                                    Console.WriteLine("Thanks for buying Fungicide! Fungicide uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy Fungicide");
                                                    break;
                                                }
                                            }
                                            else if (selected_medication == 1)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().herbicide.GetBuyPrice())
                                                {
                                                    game.GetPlayer().herbicide.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().herbicide.GetBuyPrice();
                                                    Console.WriteLine("Thanks for buying Herbicide! Herbicide uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy Herbicide");
                                                    break;
                                                }
                                            }
                                            else if (selected_medication == 2)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().pesticide.GetBuyPrice())
                                                {
                                                    game.GetPlayer().pesticide.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().pesticide.GetBuyPrice();
                                                    Console.WriteLine("Thanks for buying Pesticide! Pesticide uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy Pesticide");
                                                    break;
                                                }
                                            }
                                            else if (selected_medication == 3)
                                            {
                                                if (game.GetPlayer().Current_money >= game.GetPlayer().vaccine.GetBuyPrice())
                                                {
                                                    game.GetPlayer().vaccine.AddUse();
                                                    game.GetPlayer().Current_money -= game.GetPlayer().vaccine.GetBuyPrice(); 
                                                    Console.WriteLine("Thanks for buying a Vaccine! Vaccine uses +1");
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You don't have enough money to buy a Vaccine");
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else if (selected_shop == 2) //Comprar terrenos
                            {
                                Console.WriteLine("You can buy a NOT owned property");
                                game.Map.Print_Farm();
                                Console.WriteLine("Select a terrain not in the list above(1-100): ");
                                string terrain_of_choice = Console.ReadLine();
                                int terrain_choice = Convert.ToInt32(terrain_of_choice);
                                int price = game.Map.terrains[terrain_choice].Get_terrain_price();
                                Console.WriteLine("The terrain price is " + price);
                                if (!game.Map.terrains[terrain_choice - 1].Get_bought() && game.GetPlayer().Current_money > price) //Es comprable y hay dinero
                                {
                                    game.GetPlayer().Current_money -= price;
                                    game.Map.terrains[terrain_choice].Set_bought(true);
                                    Console.WriteLine("Terrain n° "+ terrain_of_choice +" has been bought.");
                                    foreach (Tile casilla in game.Map.map)
                                    {
                                        if (casilla.Get_terrainNumber() == terrain_choice)
                                        {
                                            casilla.Set_tile_Name("G");
                                        }
                                    }
                                }
                                else if (!game.Map.terrains[terrain_choice - 1].Get_bought()) //Es comprable pero no hay dinero
                                {
                                    Console.WriteLine("Not enough money to buy the property.");
                                }
                                else
                                {
                                    Console.WriteLine("You already own the terrain.");
                                }
                            }
                            else if (selected_shop == 3)  //Lista de precios
                            {
                                List<string> price_history = new List<string>(new string[] { "Tomato Prices", "Potato Prices", "Rice Prices", "Previous Menu" });
                                int selected_seed_price;
                                bool finished_1_3 = false;
                                while (!finished_1_3)
                                {

                                    selected_seed_price = MenuManager.PrintMenu(price_history);
                                    if (selected_seed_price == 3)
                                    {
                                        break;
                                    }
                                    else if (selected_seed_price == 0) //thirtyList_tomato
                                    {

                                        Console.WriteLine("The Tomato price history is the following:");
                                        foreach (int num in game.thirtyList_tomato)
                                        {
                                            Console.WriteLine(num);
                                        }
                                    }
                                    else if (selected_seed_price == 1) //thirtyList_potato
                                    {

                                        Console.WriteLine("The Potato price history is the following:");
                                        foreach (int num in game.thirtyList_potato)
                                        {
                                            Console.WriteLine(num);
                                        }
                                    }
                                    else if (selected_seed_price == 2) //thirtyList_rice
                                    {

                                        Console.WriteLine("The Rice price history is the following:");
                                        foreach (int num in game.thirtyList_rice)
                                        {
                                            Console.WriteLine(num);
                                        }
                                    }
                                }
                            }
                            else if (selected_shop == 4) //Menu Anterior
                            {
                                break;
                            }
                        }
                        break;
                    case 2: //Pasar Turno
                        Console.WriteLine("Turno pasado...");
                        Console.ReadKey();
                        Console.Clear();
                        game.UpdateGame();
                        break;
                    case 3: //No hay cargar partida asique creo que tampoco hay que guardar (Por ahora sirve para cerrar el juego)
                        finished = true;
                        break;

                }
                
            }
            Console.WriteLine("Fin del juego...");
            Console.ReadLine();
        }


        
    }
}
