﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Buildings;
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
            GameController.view.ApplyStuff += OnApplyStuff;
            GameController.view.GetFinishedProduct += OnGetFinishedProduct;
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
            result[0] = String.Join(", ", data.game.thirtyList_tomato);
            result[1] = String.Join(", ", data.game.thirtyList_potato);
            result[2] = String.Join(", ", data.game.thirtyList_rice);

            return result;
        }
        public static void OnApplyStuff(object sender, DataArgs data, string stuff, string option, int selection)
        {
            if (stuff == "WoF") 
            {
                if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "cttl")
                {
                    switch (option)
                        {
                        case "Comida":
                            data.game.GetPlayer().animalFood.Use((Cattle)data.game.Map.terrains[selection - 1].Get_Building());
                            break;
                        case "Agua":
                            data.game.GetPlayer().animalWater.Use((Cattle)data.game.Map.terrains[selection - 1].Get_Building());
                            break;
                        default:
                            MessageBox.Show("Seleccion invalida", "Error");
                            break;
                    }
                }
                else if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "fld")
                {
                    switch (option)
                    {
                        case "Fertilizante":
                            data.game.GetPlayer().fertilizer.Use((Field)data.game.Map.terrains[selection - 1].Get_Building());
                            break;
                        case "Riego":
                            data.game.GetPlayer().irrigation.Use((Field)data.game.Map.terrains[selection - 1].Get_Building());
                            break;
                        default:
                            MessageBox.Show("Seleccion invalida", "Error");
                            break;
                    }
                }
            }
            else if (stuff == "Meds")
            {
               // Random random = new Random();
                
                if (data.game.Map.terrains[selection].Get_Building().name == "Cattle")
                {
                    switch (option)
                    {
                        case "Vacuna":
                            //int randNum = random.Next(0, 11);
                            //data.game.GetPlayer().vaccine.Use((Cattle)data.game.Map.terrains[selection].Get_Building(), randNum);
                            
                            break;
                        default:
                            MessageBox.Show("Seleccion invalida", "Error");
                            break;
                    }
                }
                else if (data.game.Map.terrains[selection].Get_Building().name == "Field")
                {
                    switch (option)
                    {
                        case "Herbicida":
                           // data.game.GetPlayer().herbicide.Use((Field)data.game.Map.terrains[selection].Get_Building());
                            break;
                        case "Pesticida":
                           // data.game.GetPlayer().pesticide.Use((Field)data.game.Map.terrains[selection].Get_Building());
                            break;
                        case "Fungicida":
                           // data.game.GetPlayer().fungicide.Use((Field)data.game.Map.terrains[selection].Get_Building());
                            break;
                        default:
                            MessageBox.Show("Seleccion invalida", "Error");
                            break;
                    }
                }
            }
        }

        public static void OnGetFinishedProduct(object sender, DataArgs data, int selection)
        {
            
            if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "fld")
            {
                Field field = (Field)data.game.Map.terrains[selection - 1].Get_Building();
                if (field.IsReady())
                {
                    string object_name = data.game.Map.terrains[selection - 1].Get_Building().Get_product().Get_productName();
                    foreach (Terrain terrain in data.game.Map.terrains)
                    {
                        if (terrain.Get_Building() != null)
                        {
                            if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "strg" && data.game.Map.terrains[selection - 1].Get_Building().Get_product().Get_productName() == object_name)
                            {
                                Storage store = (Storage)data.game.Map.terrains[selection - 1].Get_Building();
                                if (!store.IsFull())
                                {
                                    store.AddProduct(new FinishedProduct(object_name));

                                }
                            }
                            else if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "strg")
                            {
                                Storage store = (Storage)data.game.Map.terrains[selection - 1].Get_Building();
                                if (store.GetCurrentProduct() == "Empty")
                                {
                                    store.AddProduct(new FinishedProduct(object_name));

                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El producto no está listo para ser guardado", "Error");
                    
                }
            }
            else if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "cttl")
            {
                Cattle cattle = (Cattle)data.game.Map.terrains[selection - 1].Get_Building();
                if(cattle.IsReady())
                {
                    string object_name = data.game.Map.terrains[selection - 1].Get_Building().Get_product().Get_productName();
                    foreach(Terrain terrain in data.game.Map.terrains)
                    {
                        if (terrain.Get_Building() != null)
                        {
                            if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "strg" && data.game.Map.terrains[selection - 1].Get_Building().Get_product().Get_productName() == object_name)
                            {
                                Storage store = (Storage)data.game.Map.terrains[selection - 1].Get_Building();
                                if (!store.IsFull())
                                {
                                    store.AddProduct(new FinishedProduct(object_name));

                                }
                            }
                            else if (data.game.Map.terrains[selection - 1].Get_Building().Get_type() == "strg")
                            {
                                Storage store = (Storage)data.game.Map.terrains[selection - 1].Get_Building();
                                if (store.GetCurrentProduct() == "Empty")
                                {
                                    store.AddProduct(new FinishedProduct(object_name));
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("El producto no está listo para ser guardado", "Error");
                }
            }
            else
            {
                MessageBox.Show("Seleccion invalida", "Error");
            }
        }
    }
}
