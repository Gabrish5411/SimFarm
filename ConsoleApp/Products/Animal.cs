using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products
{
    [Serializable]
    public class Animal : Product
    {
        protected int animalUnits;
        protected float escapeProbability;
        protected float suddendeathProbability;
        protected int unitsdeadRange;

        protected void Set(string name, int animalUnits, int buyPrice, float escapeProbability, float suddendeathProbability)
        {
            this.productName = name;
            this.animalUnits = animalUnits;
            this.buyPrice = buyPrice;
            this.escapeProbability = escapeProbability;
            this.suddendeathProbability = suddendeathProbability;
        }
    }
}
