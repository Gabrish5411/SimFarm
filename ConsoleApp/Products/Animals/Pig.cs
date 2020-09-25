using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products.Animals
{
    class Pig : Animal
    {
        public Pig()
        {
            this.productName = "Pig";
            this.buyPrice = 1000;
            this.animalUnits = 20;
            this.escapeProbability = 0.2;
            this.suddendeathProbability = 0.1;
        }
    }
}
