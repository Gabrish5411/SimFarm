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


        private static string OnAskForMap(object sender, PrintMapArgs e)
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


        private static PrintMapArgs OnNewGameButtonClicked(object sender, NewGameArgs e)
        {
            Game game = new Game();
            game.Map = new Map(e.gameoption);
            return new PrintMapArgs() { game = game};
        }


        public static void initializer(Form view)
        {
            MapController.view = view as Form1;
            MapController.view.NewGameButtonClicked += OnNewGameButtonClicked;
            MapController.view.PrintMapRequest += OnAskForMap;
        }


    }
}
