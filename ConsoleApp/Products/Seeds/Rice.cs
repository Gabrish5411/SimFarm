﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products.Seeds
{
    class Rice : Seed
    {
        public Rice()
        {
            this.currentPrice = this.sellPrice;
            this.productName = "Rice";
            this.buyPrice = 1000;
            this.sellPrice = 500;
            this.priceVariation = 40;
            this.wormProbability = 0.1F;
            this.wormPenalty = 1;
            this.undergrowthProbability = 0.3F;
            this.undergowthPenalty = 1;
        }
    }
}
