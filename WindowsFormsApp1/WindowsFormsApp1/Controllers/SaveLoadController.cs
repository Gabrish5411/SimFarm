using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustomEventArgs;

namespace WindowsFormsApp1.Controllers
{
    public static class SaveLoadController
    {
        static MainForm view;

        public static void initializer(Form view)
        {
            SaveLoadController.view = view as MainForm;
            SaveLoadController.view.SavingGame += OnSaveGame;
            SaveLoadController.view.LoadingGame += OnLoadGame;
        }

        public static void OnSaveGame(object sender, DataArgs data)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists("data.save"))
            {
                File.Delete("data.save");
            }

            fileStream = File.Create("data.save");
            bf.Serialize(fileStream, data);
            fileStream.Close();
        }
        public static object OnLoadGame(object sender, EventArgs e)
        {
            object obj = null;

            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists("data.save"))
            {
                fileStream = File.OpenRead("data.save");
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
            }
            return obj;
        }
    }
}
