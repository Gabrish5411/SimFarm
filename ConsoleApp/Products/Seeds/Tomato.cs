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
            this.currentPrice = this.sellPrice;
            this.Set_productName("Tomato");
            this.Set_buyPrice(1000);
            this.Set_sellPrice(500);
            this.Set_variation(50);
            this.Set_wormProb(0.1);
        }
    }
}
