using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Consumables : Products
    {
        protected int availableFood;
        protected int Uses;

        public int Fertilizer()   //AVAILABLE FOOD DE FIELD
        {
            Field.availableFood = availableFood + 20; //Supuesto de que aumenta el alimento en 20
            Uses = 5;   //ejemplo de los usos restantes del fertilizante (tiene 5 unidades de fertilizante con 1 uso c/u)
            buyPrice = 5000; //ejemplo coste
            return availableFood;
        }
        public int AnimalFood()   //AVAILABLE FOOD DE CATTLE
        {
            Cattle.availableFood = availableFood + 20; 
            Uses = 5;   
            buyPrice = 5000; 
            return availableFood;
        }
        public int Irrigation() //AVAILABLE WATER DE FIELD
        {
            Field.availableWater = availableWater + 20; 
            Uses = 5;   
            buyPrice = 5000; 
            return availableWater;
        }
        public int AnimalWater()  //AVAILABLE WATER DE CATTLE
        {
            Cattle.availableWater = availableWater + 20; 
            Uses = 5;   
            buyPrice = 5000; 
            return availableWater;
        }
        public bool Pesticide(bool worms)
        {
            Uses = 5;
            buyPrice = 5000;

            Random random = new Random();
            int successProbability = random.Next(0, 11);      
            if (successProbability >= 5){
                Uses -= 1;
                return worms =  false;

            }
            else 
            {
                Uses -= 1;
                return worms = true;
            }
                        
        }
        public bool Herbicide(bool undergrowth)
        {
            Uses = 5;
            buyPrice = 5000;

            Random random = new Random();
            int successProbability = random.Next(0, 11);
            if (successProbability >= 5)
            {
                Uses -= 1;
                return undergrowth = false;
            }
            else
            {
                Uses -= 1;
                return undergrowth = true;
            }
        }
        public bool Fungicide(bool ill)    //ILL DE FIELD
        {
            Uses = 5;
            buyPrice = 5000;

            Random random = new Random();
            int successProbability = random.Next(0, 11);
            if (successProbability >= 5)
            {
                Uses -= 1;
                return ill = false;

            }
            else
            {
                Uses -= 1;
                return ill = true;
            }
        }
        public bool Vaccine(bool ill)      //ILL DE CATTLE
        {
            Uses = 5;
            buyPrice = 5000;

            Random random = new Random();
            int successProbability = random.Next(0, 11);
            if (successProbability >= 5)
            {
                Uses -= 1;
                return ill = false;

            }
            else
            {
                Uses -= 1;
                return ill = true;
            }
        }
    }
}
