using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Products
    {
        protected string productName;
        protected int buyPrice;
        protected int sellPrice;
        protected int foodConsumption;
        protected int waterConsumption;
        protected int minFood;
        protected int minWater;
        protected int foodPenalty;
        protected int waterPenalty;
        protected float productionTime;
        protected float diseaseProbability;
        protected int diseasePenalty;
        private Random randNum = new Random(); //creado para generar probabilidad de enfermedad de manera aleatoria

        public string Get_productName()
        {
            return productName;
        }
        public void Set_productName(string name)
        {
            productName = name;
        }

        public int Get_buyPrice()
        {
            return buyPrice;
        }

        public void Set_buyPrice(int value)
        {
            buyPrice = value;
        }

        public int Get_sellPrice()
        {
            return sellPrice;
        }

        public void Set_sellPrice(int value)
        {
            sellPrice = value;
        }

        public int Get_foodConsumption()
        {
            return foodConsumption;
        }

        public void Set_foodConsumption(int value)
        {
            foodConsumption = value;
        }

        public int Get_waterConsumption()
        {
            return waterConsumption;
        }

        public void Set_waterConsumption(int value)
        {
            waterConsumption = value;
        }

        public int Get_minFood()
        {
            return minFood;
        }

        public void Set_minFood(int value)
        {
            minFood = value;
        }

        public int Get_minWater()
        {
            return minWater;
        }

        public void Set_minWater(int value)
        {
            minWater = value;
        }


        public int Get_foodPenalty()
        {
            return foodPenalty;
        }

        public void Set_foodPenalty(int value)
        {
            foodPenalty = value;
        }

        public int Get_waterPenalty()
        {
            return waterPenalty;
        }

        public void Set_waterPenalty(int value)
        {
            waterPenalty = value;
        }


        public float Get_productionTime()
        {
            return productionTime;
        }

        public void Set_productionTime(float value)
        {
            productionTime = value;
        }

        public float Get_diseaseProbability()
        {
            return productionTime;
        }

        public void Set_diseaseProbability(float value)
        {
            productionTime = value;
        }

        public int Get_diseasePenalty()
        {
            return diseasePenalty;
        }

        public void Set_diseasePenalty(int value)
        {
            diseasePenalty = value;
        }

    }
}