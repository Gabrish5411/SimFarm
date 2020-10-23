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
        
        protected float wormProbability;
        protected int wormPenalty;
        protected float undergrowthProbability;
        protected int undergrowthPenalty;

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
        public float Get_undergrowthProbability()
        {
            return undergrowthProbability;
        }
        public float Get_wormsProbability()
        {
            return wormProbability;
        }



    }
}
