using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Consumables
{
    class Fungicide : Consumable
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
}
