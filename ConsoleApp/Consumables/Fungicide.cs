using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    [Serializable]
    public class Fungicide : Consumable
    {
        private int successProbability;
        public Fungicide()
        {
            Uses = 5;
            buyPrice = 5000;
        }
        public void Use(Field field, Random random)    //ILL DE FIELD
        {
            Uses -= 1;
            successProbability = random.Next(0, 11);
            if (successProbability >= 5)
            {
                field.ill = false;
            }
        }
    }
}
