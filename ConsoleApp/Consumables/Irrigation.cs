using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    class Irrigation : Consumable
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
}
