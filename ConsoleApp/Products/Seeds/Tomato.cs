using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Products;

namespace ConsoleApp.Products.Seeds
{
    class Tomato : Seed
    {
        public Tomato()
        {
            //buyPrice, sellPrice, priceVariation, wProb, wPen, uProb, uPen
            Set("Tomato", 1000, 500, 40, 0.1F, 1, 0.3F, 1);
        }
    }
}
