using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustomEventArgs;

namespace WindowsFormsApp1.Controllers
{
    public static class GameController
    {
        static MainForm view;

        public static void initializer(Form view)
        {
            GameController.view = view as MainForm;
            GameController.view.PrintInventoryRequest += OnAskForInventory;
            GameController.view.PrintHistoric += OnHistoric;
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
        public static string[] OnHistoric(object sender, DataArgs data)
        {
            string[] result = new string[3];
            result[0] = String.Join(",", data.game.thirtyList_tomato);
            result[1] = String.Join(",", data.game.thirtyList_potato);
            result[2] = String.Join(",", data.game.thirtyList_rice);

            return result;
        }
    }
}
