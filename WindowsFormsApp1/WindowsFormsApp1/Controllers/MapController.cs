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
        static MainForm view;


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
                    if (casilla.Get_farmable()) result += "G";
                    else result += "A";
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
            MapController.view = view as MainForm;
            MapController.view.NewGameButtonClicked += OnNewGameButtonClicked;
            MapController.view.PrintMapRequest += OnAskForMap;
            MapController.view.AskForBuilding += OnAskForBuilding;

        }

        
        

        public static List<string> OnAskForBuilding(object sender, DataArgs data, int selection)
        {
            return data.game.Map.terrains[selection - 1].Get_Building().Report();
            
        }

    }
}

