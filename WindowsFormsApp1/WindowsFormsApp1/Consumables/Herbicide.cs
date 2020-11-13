using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Buildings;

namespace WindowsFormsApp1.Consumables
{
    [Serializable]
    public class Herbicide : Consumable
    {
        private int successProbability;
        public Herbicide()
        {
            Uses = 5;
            buyPrice = 5000;

        }
        public void Use(Field field, Random random)
        {
            Uses -= 1;
            this.successProbability = random.Next(0, 11);
            if (this.successProbability >= 5)
            {
                field.undergowth = false;
            }
        }
    }
}
