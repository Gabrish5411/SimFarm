using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustomEventArgs;
using WindowsFormsApp1.Tiles;


namespace WindowsFormsApp1.Controllers
{
    public static class MapController
    {
        static Form1 view;


        private static string OnAskForMap(object sender, DataArgs e)
        {
            string result = "";
            int i = 0;
            foreach (Tile casilla in e.game.Map.map)
            {
                if (i == 100)
                {
                    result += "\n";
                    i = 0;
                }
                if (casilla.Get_tileName() == "T")
                {
                    result += "T";
                }
                else if (casilla.Get_tileName() == "G")
                {
                    result += "G";

                }
                else if (casilla.Get_tileName() == "Field")
                {
                    result += "F";
                }
                else if (casilla.Get_tileName() == "Cattle")
                {
                    result += "C";
                }
                else if (casilla.Get_tileName() == "Storage")
                {
                    result += "S";
                }
                else if (casilla.Get_tileName() == "L" | casilla.Get_tileName() == "R")
                {
                    result += "A";
                }
                i++;
                
            }
            return result;
        }


        private static DataArgs OnNewGameButtonClicked(object sender, NewGameArgs e)
        {
            Game game = new Game();
            game.Map = new Map(e.gameoption);
            return new DataArgs() { game = game};
        }


        public static void initializer(Form view)
        {
            MapController.view = view as Form1;
            MapController.view.NewGameButtonClicked += OnNewGameButtonClicked;
            MapController.view.PrintMapRequest += OnAskForMap;
            MapController.view.PrintInventoryRequest += OnAskForInventory;
            MapController.view.AddingOne += OnBuy;
        }

        public static string[] OnAskForInventory(object sender, DataArgs data)
        {
            string[] result = new string[8];
            result[0] = Convert.ToString(data.game.GetPlayer().fertilizer.GetUses());
            result[1] = Convert.ToString(data.game.GetPlayer().irrigation.GetUses());
            result[2] = Convert.ToString(data.game.GetPlayer().animalFood.GetUses());
            result[3] = Convert.ToString(data.game.GetPlayer().animalWater.GetUses());
            result[4] = Convert.ToString(data.game.GetPlayer().fungicide.GetUses());
            result[5] = Convert.ToString(data.game.GetPlayer().herbicide.GetUses());
            result[6] = Convert.ToString(data.game.GetPlayer().pesticide.GetUses());
            result[7] = Convert.ToString(data.game.GetPlayer().vaccine.GetUses());

            return result;
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
            else {MessageBox.Show("No tienes suficiente dinero...", "¡Hay un problema!");}

        }
    }
}
