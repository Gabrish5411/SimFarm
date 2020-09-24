using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    class AnimalWater : Consumable
    {
        public AnimalWater()  //AVAILABLE WATER DE CATTLE
        {
            Uses = 5;
            buyPrice = 5000;
        }
        public void Use(Cattle cattle)
        {
            cattle.GiveWater(20);
        }
    }
}
