using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products;
using ConsoleApp.Consumables;
using ConsoleApp.Products.Seeds;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace ConsoleApp
{
    class Player
    {
        public Seed tomato;
        public Seed potato;
        public Seed rice;
        private int current_money;
        public Fertilizer fertilizer = new Fertilizer();
        public Irrigation irrigation = new Irrigation();
        public AnimalFood animalFood = new AnimalFood();
        public AnimalWater animalWater = new AnimalWater();
        public Fungicide fungicide = new Fungicide();
        public Herbicide herbicide = new Herbicide();
        public Pesticide pesticide = new Pesticide();
        public Vaccine vaccine = new Vaccine();

        public Player()
        {
            current_money = 50000000;
            tomato = new Tomato();
            potato = new Potato();
            rice = new Rice();





        }
        public int Current_money
        {
            get { return current_money; }
            set { current_money = value; }
        }

        public void ReportInventory()
        {
            Console.WriteLine("Inventory: \nFertilizer uses: " + fertilizer.GetUses() + "\tIrrigation uses: " + irrigation.GetUses());
            Console.WriteLine("Animal food uses: " + animalFood.GetUses() + "\tAnimal water uses: " + animalWater.GetUses());
            Console.WriteLine("Fungicide uses: " + fungicide.GetUses() + "\tHerbicide uses: " + herbicide.GetUses());
            Console.WriteLine("Pesticide uses: " + pesticide.GetUses() + "\tVaccine uses: " + vaccine.GetUses());
        }




        //XNL Serialization
        public void XmlSerialize(Type dataType, object data, string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            TextWriter writer = new StreamWriter(filePath);
            xmlSerializer.Serialize(writer, data);
            writer.Close();
        }

        public object XmlDeserialize(Type dataType, string filePath)
        {
            object obj = null;

            XmlSerializer xmlSerializer = new XmlSerializer(dataType);
            if (File.Exists(filePath))
            {
                TextReader textReader = new StreamReader(filePath);
                obj = xmlSerializer.Deserialize(textReader);
                textReader.Close();
            }

            return obj;
        }
    }
}