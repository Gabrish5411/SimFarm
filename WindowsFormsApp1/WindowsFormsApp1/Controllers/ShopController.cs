using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Buildings;
using WindowsFormsApp1.CustomEventArgs;
using WindowsFormsApp1.Products;
using WindowsFormsApp1.Products.Animals;
using WindowsFormsApp1.Products.Seeds;
using WindowsFormsApp1.Tiles;

namespace WindowsFormsApp1.Controllers
{
    public static class ShopController
    {
        static MainForm view;

        public static void initializer(Form view)
        {
            ShopController.view = view as MainForm;
            ShopController.view.AddingOne += OnBuy;
            ShopController.view.BuyTerrain += OnBuyTerrain;
            ShopController.view.BuyFarm += OnBuyFarm;
            ShopController.view.BuyCattle += OnBuyCattle;
            ShopController.view.BuyStorage += OnBuyStorage;
        }

        public static void OnBuy(object sender, DataArgs data, string ConsName)
        {
            if (ConsName == "fertilizer" && data.game.GetPlayer().Current_money > data.game.GetPlayer().fertilizer.GetBuyPrice())
            {
                data.game.GetPlayer().fertilizer.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().fertilizer.GetBuyPrice();
            }
            else if (ConsName == "irrigation" && data.game.GetPlayer().Current_money > data.game.GetPlayer().irrigation.GetBuyPrice())
            {
                data.game.GetPlayer().irrigation.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().irrigation.GetBuyPrice();
            }
            else if (ConsName == "animalFood" && data.game.GetPlayer().Current_money > data.game.GetPlayer().animalFood.GetBuyPrice())
            {
                data.game.GetPlayer().animalFood.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().animalFood.GetBuyPrice();
            }
            else if (ConsName == "animalWater" && data.game.GetPlayer().Current_money > data.game.GetPlayer().animalWater.GetBuyPrice())
            {
                data.game.GetPlayer().animalWater.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().animalWater.GetBuyPrice();
            }
            else if (ConsName == "fungicide" && data.game.GetPlayer().Current_money > data.game.GetPlayer().fungicide.GetBuyPrice())
            {
                data.game.GetPlayer().fungicide.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().fungicide.GetBuyPrice();
            }
            else if (ConsName == "herbicide" && data.game.GetPlayer().Current_money > data.game.GetPlayer().herbicide.GetBuyPrice())
            {
                data.game.GetPlayer().herbicide.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().herbicide.GetBuyPrice();
            }
            else if (ConsName == "pesticide" && data.game.GetPlayer().Current_money > data.game.GetPlayer().pesticide.GetBuyPrice())
            {
                data.game.GetPlayer().pesticide.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().pesticide.GetBuyPrice();
            }
            else if (ConsName == "vaccine" && data.game.GetPlayer().Current_money > data.game.GetPlayer().vaccine.GetBuyPrice())
            {
                data.game.GetPlayer().vaccine.AddUse();
                data.game.GetPlayer().Current_money -= data.game.GetPlayer().vaccine.GetBuyPrice();
            }
            else { MessageBox.Show("No tienes suficiente dinero...", "¡Hay un problema!"); }

        }


        private static void SetTileNames(DataArgs data, int selection, string tileType)
        {
            foreach (Tile casilla in data.game.Map.map)
            {
                if (casilla.Get_terrainNumber() == selection)
                {
                    if (casilla.Get_tileName() == "G" && tileType != "G" && data.game.Map.terrains[casilla.Get_terrainNumber() - 1].Get_bought() == true) //condicion para comprar edificacion en granja
                    {
                        casilla.Set_tile_Name(tileType);
                    }
                    else if (casilla.Get_tileName() != "G" && tileType == "G") //condicion para comprar terrenos y convertirlos a granja
                    {
                        casilla.Set_tile_Name(tileType);
                    }
                }
            }
        }

        public static bool OnBuyTerrain(object sender, DataArgs data, int selection, string tileType)
        {
            if (data.game.Map.terrains[selection - 1].Get_bought())
            {
                MessageBox.Show("Este terreno ya es parte de tu granja!", "Hay un error!");
                return false;
            }
            data.game.Map.terrains[selection - 1].Set_bought(true);
            SetTileNames(data, selection, tileType);
            return true;
        }

        public static bool OnBuyFarm(object sender, DataArgs data, int selection, string buildingType, string tileType)
        {
            if (!data.game.Map.terrains[selection - 1].Get_bought())
            {
                MessageBox.Show("Este terreno no es parte de tu granja, debes comprarlo para construir una edificacion aqui", "Hay un error!");
                return false;
            }
            Seed seed;
            switch (buildingType)
            {
                case "Tomato":
                    seed = new Tomato();
                    break;
                case "Potato":
                    seed = new Potato();
                    break;
                case "Rice":
                    seed = new Rice();
                    break;
                default:
                    seed = new Tomato();
                    break;
            }
            Field field = new Field(data.game.Map.terrains, seed);
            data.game.Map.terrains[selection - 1].Set_Building(field);
            SetTileNames(data, selection, tileType);
            return true;
        }

        public static bool OnBuyCattle(object sender, DataArgs data, int selection, string buildingType, string tileType)
        {
            if (!data.game.Map.terrains[selection - 1].Get_bought())
            {
                MessageBox.Show("Este terreno no es parte de tu granja, debes comprarlo para construir una edificacion aqui", "Hay un error!");
                return false;
            }
            Animal animal;
            switch (buildingType)
            {
                case "Cow":
                    animal = new Cow();
                    break;
                case "Pig":
                    animal = new Pig();
                    break;
                case "Sheep":
                    animal = new Sheep();
                    break;
                default:
                    animal = new Sheep();
                    break;
            }
            Cattle cattle = new Cattle(data.game.Map.terrains, animal);
            data.game.Map.terrains[selection - 1].Set_Building(cattle);
            SetTileNames(data, selection, tileType);
            return true;
        }

        public static bool OnBuyStorage(object sender, DataArgs data, int selection, string tileType)
        {
            if (!data.game.Map.terrains[selection - 1].Get_bought())
            {
                MessageBox.Show("Este terreno no es parte de tu granja, debes comprarlo para construir una edificacion aqui", "Hay un error!");
                return false;
            }
            data.game.Map.terrains[selection - 1].Set_Building(new Storage());
            SetTileNames(data, selection, tileType);
            return true;
        }
    }
}
