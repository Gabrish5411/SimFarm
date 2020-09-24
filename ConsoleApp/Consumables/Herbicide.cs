using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Buildings;

namespace ConsoleApp.Consumables
{
    class Herbicide : Consumable
    {
        int successProbability;
        public Herbicide()
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
}
