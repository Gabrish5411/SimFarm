using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Products;

namespace WindowsFormsApp1.Buildings
{ 
    [Serializable]
    public class Field : Building
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

        public void GiveFood(int food)
        {
            this.availableFood += food;
        }
        public void GiveWater(int water)
        {
            this.availableWater += water;
        }
        public override List<string> Report()
        {
            List<string> result = new List<string>();
            result.Add("Plantacion de "+this.item.Get_productName()+"s:");
            result.Add("Madurez: " + this.ripeness);
            result.Add("Salud: " + this.currentHP + "/100");
            result.Add("Agua: "+this.availableWater+"/100");
            result.Add("Comida: " + this.availableFood + "/100");
            result.Add("Enfermedad: " + ill);
            result.Add("Gusanos: " + worms);
            result.Add("Maleza: " + undergowth);
            return result;
        }
        public override void Update()
        {
            ripeness = ripeness < 10 ? ripeness + 1 : 10;
            currentHP = availableFood < item.Get_minFood() ? currentHP - 5 : currentHP;
            currentHP = ill ? currentHP - 5 : currentHP;
            Seed seed = (Seed)item;
            Random random = new Random();
            double rand = random.NextDouble();
            if (!undergowth) undergowth = (rand <= seed.Get_undergrowthProbability() ? true : false);
            if (!worms) worms = rand <= seed.Get_wormsProbability() ? true : false;
            if (!ill) ill = rand <= item.Get_diseaseProbability() ? true : false;
            availableFood -= item.Get_foodConsumption();
            availableWater -= item.Get_waterConsumption();
        }
        public bool IsReady()
        {
            return ripeness == maxRipeness ? true : false;
        }
    }
}
