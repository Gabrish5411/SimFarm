using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    [Serializable]
    public class Irrigation : Consumable
    {
        public Irrigation()
        {
            Uses = 5;
            buyPrice = 5000;
        }
        public void Use(Field field) //AVAILABLE WATER DE FIELD
        {
            Uses -= 1;
            field.GiveWater(20);

        }
        
    }
}
