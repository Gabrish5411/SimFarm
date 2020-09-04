using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp.Buildings
{
    class Field : Building
    {
        protected int productivity;
        public int currentHP;
        protected int availableFood;
        protected int availableWater;
        protected int ripeness;
        protected float maxRipeness;
        protected bool ill;
        protected bool worms;
        protected bool undergowth;

        public Field(Terrain[] terrains)
        {
            this.productivity = terrains[tNumber].earthNumber;
            currentHP = 100;
            availableFood = 100;
            availableWater = 100;
            ill = false;
            worms = false;
            undergowth = false;
            ripeness = 0;
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
    }
}
