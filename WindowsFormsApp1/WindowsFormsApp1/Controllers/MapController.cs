using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustomEventArgs;

namespace WindowsFormsApp1.Controllers
{
    public static class MapController
    {
        static Form1 view;

        private static Game OnNewGameButtonClicked(object sender, NewGameArgs e)
        {
            Game game = new Game();
            game.Map = new Map(e.gameoption);
            return game;
        }

        public static void initializer(Form view)
        {
            MapController.view = view as Form1;
            MapController.view.NewGameButtonClicked += OnNewGameButtonClicked;

        }


    }
}
