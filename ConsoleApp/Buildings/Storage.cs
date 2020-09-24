using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Buildings
{
    class Storage : Building
    {
        protected int capacity;
        public Storage(Terrain[] terrains, FinishedProduct finishedProduct)
        {
            this.item = finishedProduct;
            Game game = new Game();
            FinishedProduct finished_product = new FinishedProduct();
            capacity = 10;

            if (capacity != 10)
            {
                finished_product.productQuality -= 1;

            }


        }
    }

}
