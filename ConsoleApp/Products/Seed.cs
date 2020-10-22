using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products
{
    [Serializable]
    public abstract class Seed : Product
    {
        
        private float wormProbability;
        private int wormPenalty;
        private float undergrowthProbability;
        private int undergrowthPenalty;

        protected void Set(string name, int buyPrice, int sellPrice, int priceVariation, 
            float wormProbability, int wormPenalty, float undergrowthProbability, int undergrowthPenalty)
        {
            this.currentPrice = this.sellPrice;
            this.productName = name;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.priceVariation = priceVariation;
            this.wormProbability = wormProbability;
            this.wormPenalty = wormPenalty;
            this.undergrowthProbability = undergrowthProbability;
            this.undergrowthPenalty = undergrowthPenalty;
        }
        
        
    }
}
