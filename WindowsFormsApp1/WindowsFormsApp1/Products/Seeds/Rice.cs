using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Products.Seeds
{
    [Serializable]
    class Rice : Seed
    {
        public Rice()
        {
            //buyPrice, sellPrice, priceVariation, wProb, wPen, uProb, uPen
            Set("Arroz", 1000, 500, 40, 0.1F, 1, 0.3F, 1);
            foodConsumption = 3;
            waterConsumption = 4;
            wormProbability = 0.5F;
            wormPenalty = 10;
        }
    }
}
