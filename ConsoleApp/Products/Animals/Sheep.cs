using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products.Animals
{
    class Sheep : Animal
    {
        public Sheep()
        {
            this.productName = "Sheep";
            this.buyPrice = 1500;
            this.animalUnits = 20;
            this.escapeProbability = 0.2;
            this.suddendeathProbability = 0.1;
        }
    }
}
