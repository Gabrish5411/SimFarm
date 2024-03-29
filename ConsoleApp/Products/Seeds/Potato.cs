﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products.Seeds
{
    [Serializable]
    class Potato : Seed
    {
        public Potato()
        {
            //buyPrice, sellPrice, priceVariation, wProb, wPen, uProb, uPen
            Set("Potato", 1000, 500, 40, 0.1F, 1, 0.3F, 1);
            foodConsumption = 3;
            waterConsumption = 4;
            wormProbability = 0.5F;
            wormPenalty = 10;
        }
    }
}
