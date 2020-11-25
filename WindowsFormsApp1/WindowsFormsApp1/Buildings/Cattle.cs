using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Products;

namespace WindowsFormsApp1.Buildings
{
    [Serializable]
     public class Cattle : Building
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
        public override void Update()
        {
            ripeness = (ripeness < 10 ? ripeness + 1 : 10);
            currentHP = (availableWater < item.Get_minWater() ? currentHP - 5 : currentHP);
            currentHP = (availableFood < item.Get_minFood() ? currentHP - 5 : currentHP);
            currentHP = (ill ? currentHP - 5 : currentHP);
            availableFood -= item.Get_foodConsumption();
            availableWater -= item.Get_waterConsumption();
        }


        public override List<string> Report()
        {
            List<string> result = new List<string>();
            result.Add("Granja de " + this.item.Get_productName() + "s:");
            result.Add("Madurez: " + this.ripeness);
            result.Add("Salud: " + this.currentHP + "/100");
            result.Add("Agua: " + this.availableWater + "/100");
            result.Add("Comida: " + this.availableFood + "/100");
            result.Add("Enfermedad: " + ill);
            return result;
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
