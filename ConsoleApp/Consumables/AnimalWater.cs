using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    [Serializable]
    public class AnimalWater : Consumable
    {
        public AnimalWater()  //AVAILABLE WATER DE CATTLE
        {
            Uses = 5;
            buyPrice = 5000;
        }
        public void Use(Cattle cattle)
        {
            Uses -= 1;
            cattle.GiveWater(20);
        }
    }
}
