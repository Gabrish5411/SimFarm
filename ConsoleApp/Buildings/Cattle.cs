using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products;

namespace ConsoleApp.Buildings
{
     class Cattle : Building
    {
        protected double productivity;
        public int currentHP;
        public int availableFood;
        protected int availableWater;
        protected int ripeness;
        protected float maxRipeness;
        public bool ill;
        protected int finalUnits;

        public Cattle(Terrain[] terrains, Animal animal)
        {
            this.buyPrice = 15000;
            this.item = animal;
            this.productivity = terrains[tNumber].earthNumber / 100;
            currentHP = 100;   
            availableFood = 100;
            availableWater = 100;
            ill = false;
            ripeness = 0;
            Set_type("cttl");
            Set_sell(3000);
            
        }

        private void GetAttributes() //Con esta funcion sacamos lo que necesitemos del item (Animal en este caso)
        {
            maxRipeness = item.Get_productionTime(); //Ejemplo
        }

        public void ReportCattleStatus()
        {
            Console.WriteLine("Field of " + this.item.Get_productName() + "s:");
            Console.WriteLine("Ripeness: " + this.ripeness);
            Console.WriteLine("Current health: " + this.currentHP + "/100");
            Console.WriteLine("Current water: " + this.availableWater + "/100");
            Console.WriteLine("Current food: " + this.availableFood + "/100");
            Console.WriteLine("Illness: " + ill);
            
        }
        public bool IsReady()
        {
            return ripeness == maxRipeness ? true : false;
        }

        public void GiveFood(int food)
        {
            this.availableFood += food;
        }
        public void GiveWater(int water)
        {
            this.availableWater += water;
        }
    }
}
