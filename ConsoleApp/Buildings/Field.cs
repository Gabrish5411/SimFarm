using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products;

namespace ConsoleApp.Buildings
{
    class Field : Building
    {
        protected double productivity;
        public int currentHP;
        public int availableFood;
        public int availableWater;
        protected int ripeness;
        protected float maxRipeness;
        public bool ill;
        public bool worms;
        public bool undergowth;

        public Field(Terrain[] terrains, Seed seed)
        {
            this.buyPrice = 20000;
            this.item = seed;
            this.productivity = terrains[tNumber].earthNumber / 100;
            currentHP = 100;
            availableFood = 100;
            availableWater = 100;
            ill = false;
            worms = false;
            undergowth = false;
            ripeness = 0;
            Set_type("fld");
            Set_sell(3000);
        }

        private void GetAttributes() //Con esta funcion sacamos lo que necesitemos del item (Semilla en este caso)
        {
            maxRipeness = item.Get_productionTime(); //Ejemplo
        }

        public void GiveFood(int food)
        {
            this.availableFood += food;
        }
        public void GiveWater(int water)
        {
            this.availableWater += water;
        }
        public void ReportFieldStatus()
        {
            Console.WriteLine("Field of "+this.item.Get_productName()+"s:");
            Console.WriteLine("Ripeness: " + this.ripeness);
            Console.WriteLine("Current health: " + this.currentHP + "/100");
            Console.WriteLine("Current water: "+this.availableWater+"/100");
            Console.WriteLine("Current food: " + this.availableFood + "/100");
            Console.WriteLine("Illness: " + ill);
            Console.WriteLine("Worms: " + worms);
            Console.WriteLine("Undergowth: " + undergowth);
        }
        public bool IsReady()
        {
            return ripeness == maxRipeness ? true : false;
        }
    }
}
