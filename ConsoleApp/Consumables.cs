using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp
{
    class Consumables
    {
        protected int Uses;
        protected int buyPrice;
        
    }
    class Fertilizer : Consumables
    {
        public void Use(Field field)   //AVAILABLE FOOD DE FIELD
        {
            field.GiveFood(20); //Supuesto de que aumenta el alimento en 20
            Uses = 5;   //ejemplo de los usos restantes del fertilizante (tiene 5 unidades de fertilizante con 1 uso c/u)
            buyPrice = 5000; //ejemplo coste

        }
    }
    class AnimalFood : Consumables
    {
        AnimalFood()
        {
            buyPrice = 5000;
            Uses = 5;
        }
        public void Use(Cattle cattle)   //AVAILABLE FOOD DE CATTLE
        {
            cattle.GiveFood(20);
        }
    }
    class Irrigation : Consumables
    {
        Irrigation()
        {
            Uses = 5;
            buyPrice = 5000;
        }
        public void Use(Field field) //AVAILABLE WATER DE FIELD
        {
            field.GiveWater(20);
        }
    }
    class AnimalWater : Consumables
    {
        AnimalWater()  //AVAILABLE WATER DE CATTLE
        {
            Uses = 5;
            buyPrice = 5000;
        }
        public void Use(Cattle cattle)
        {
            cattle.GiveWater(20);
        }
    }
    class Pesticide : Consumables
    {
        int successProbability;
        Pesticide()
        {
            Uses = 5;
            buyPrice = 5000;
            Random random = new Random();
        }

        public bool Use(bool worms, Random random)
        {
            this.successProbability = random.Next(0, 11);
            if (this.successProbability >= 5)
            {
                Uses -= 1;
                return worms = false;
            }
            else
            {
                Uses -= 1;
                return worms = true;
            }

        }
    }
    class Herbicide : Consumables
    {
        int successProbability;
        Herbicide()
        {
            Uses = 5;
            buyPrice = 5000;
            Random random = new Random();

        }
        public bool Use(bool undergrowth, Random random)
        {
            this.successProbability = random.Next(0, 11);
            if (this.successProbability >= 5)
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
    }
    class Fungicide : Consumables
    {
        Fungicide()
        {
            Uses = 5;
            buyPrice = 5000;
            Random random = new Random();
        }
        public bool Use(bool ill, Random random)    //ILL DE FIELD
        {
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
    class Vaccine : Consumables
    {
        Vaccine()
        {
            Uses = 5;
            buyPrice = 5000;
            Random random = new Random();
        }
        public bool Use(bool ill, Random random)      //ILL DE CATTLE
        {
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
