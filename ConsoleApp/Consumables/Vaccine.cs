using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    [Serializable]
    public class Vaccine : Consumable
    {
        public Vaccine()
        {
            Uses = 5;
            buyPrice = 5000;
            Random random = new Random();
        }
        public void Use(Cattle cattle, Random random)      //ILL DE CATTLE
        {
            Uses -= 1;
            int successProbability = random.Next(0, 11);
            if (successProbability >= 5)
            {
                cattle.ill = false;
            }
        }
    }
}
