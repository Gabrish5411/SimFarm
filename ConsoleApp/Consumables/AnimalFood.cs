using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    class AnimalFood : Consumable
    {
        public AnimalFood()
        {
            buyPrice = 5000;
            Uses = 5;
        }
        public void Use(Cattle cattle)   //AVAILABLE FOOD DE CATTLE
        {
            Uses -= 1;
            cattle.GiveFood(20);
        }
    }
}
