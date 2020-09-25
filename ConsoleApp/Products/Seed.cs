using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products
{
    class Seed : Product
    {
        
        private double wormProbability;
        private int wormPenalty;
        private float undergrowthProbability;
        private int undergowthPenalty;

        public void Set_wormProb(double prob)
        {
            wormProbability = prob;
        }
        
    }
}
