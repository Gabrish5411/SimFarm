using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Products.Seeds
{
    [Serializable]
    class Rice : Seed
    {
        public Rice()
        {
            //buyPrice, sellPrice, priceVariation, wProb, wPen, uProb, uPen
            Set("Rice", 1000, 500, 40, 0.1F, 1, 0.3F, 1);
        }
    }
}
